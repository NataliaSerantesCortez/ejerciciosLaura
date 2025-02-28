package com.example.demo.controller;


import java.util.List;

import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.example.demo.entity.Usuario;
import com.example.demo.entity.Perfil;
import com.example.demo.service.PerfilService;
import com.example.demo.service.UsuarioService;

import org.springframework.ui.Model;

@Controller
public class UsuarioController {

    private UsuarioService usuarioServ;
    private PerfilService perfilServ;

    public UsuarioController(UsuarioService us, PerfilService ps){
        super();
        this.usuarioServ = us;
        this.perfilServ = ps;
    }
 
    @GetMapping("/usuarios")
    public String listUsuarios(Model modelo){
        modelo.addAttribute("usuarios", this.usuarioServ.getAllUsuarios());

        return "usuarios";
    }

    @GetMapping("/usuarios/new")
    public String crearUsuario(Model modelo, @ModelAttribute("errorMessage") String errorMessage){
        Usuario usuario = new Usuario();

        modelo.addAttribute("usuario", usuario);
        modelo.addAttribute("perfiles", perfilServ.getAllPerfilesSinRepetirEnUsuario());
        modelo.addAttribute("errorMessage", errorMessage);

        return "create_usuario";
    }

    @PostMapping("/usuarios")
    public String saveUsuario(@ModelAttribute("usuario") Usuario usuario, RedirectAttributes redirectAttributes){
        try {
            this.usuarioServ.saveUsuario(usuario);
            return "redirect:/usuarios";
        } catch (DataIntegrityViolationException e) {
            redirectAttributes.addFlashAttribute("errorMessage", "El correo ya está en uso. Intenta con otro.");
            return "redirect:/usuarios/new"; 
        }
    }

    @GetMapping("/usuarios/edit/{correo}")
    public String editarUsuario(@PathVariable String correo, Model modelo){
        List<Perfil> perfilesNoRepetidos = this.perfilServ.getAllPerfilesSinRepetirEnUsuario();
        Usuario usuario = this.usuarioServ.getUsuarioByCorreo(correo);
        if (usuario.getPerfil()!=null){
            perfilesNoRepetidos.add(usuario.getPerfil());
        } 

        modelo.addAttribute("usuario", usuario);
        modelo.addAttribute("perfiles", perfilesNoRepetidos );
        return "edit_usuario";
    }

    @PostMapping("/usuarios/{correo}")
    public String updateUsuario(@PathVariable String correo, @ModelAttribute("usuario") Usuario usuario, Model modelo){
        Usuario usuarioCogido = this.usuarioServ.getUsuarioByCorreo(correo);
        
        usuarioCogido.setNombre(usuario.getNombre());
        usuarioCogido.setApellidos(usuario.getApellidos());
        usuarioCogido.setContrasenia(usuario.getContrasenia());
        usuarioCogido.setPais(usuario.getPais());
        usuarioCogido.setTipo(usuario.getTipo());
        if (usuario.getPerfil()!=null){
            usuarioCogido.setPerfil(usuario.getPerfil());
        } else{
            usuarioCogido.setPerfil(null);
        }

        this.usuarioServ.updateUsuario(usuarioCogido);

        return "redirect:/usuarios";
    }

    @GetMapping("/usuarios/{correo}")
    public String deleteUsuario(@PathVariable String correo){
        this.usuarioServ.deleteUsuarioByCorreo(correo);

        return "redirect:/usuarios";

    }

    @GetMapping("/usuarios/{correo}/perfil")
    public String verPefil(@PathVariable String correo, Model modelo){
        Usuario usuario = this.usuarioServ.getUsuarioByCorreo(correo);
        modelo.addAttribute("usuario", usuario);
        if ( usuario.getPerfil() != null ){
            modelo.addAttribute("perfil",usuario.getPerfil() );
        } else {
            modelo.addAttribute("perfil", new Perfil() );
        }

        return "usuarios_perfil";
    }
    
}
