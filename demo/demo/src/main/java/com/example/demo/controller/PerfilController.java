package com.example.demo.controller;


import java.util.List;

import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.example.demo.entity.Juego;
import com.example.demo.entity.Perfil;
import com.example.demo.entity.Usuario;
import com.example.demo.service.JuegoService;
import com.example.demo.service.JuegaService;
//import com.example.demo.entity.Resenia;
import com.example.demo.service.PerfilService;

import org.springframework.ui.Model;

@Controller
public class PerfilController {

    private PerfilService perfilServ;
    private JuegoService juegoServ;
    private JuegaService juegaServ;

    public PerfilController(PerfilService ps, JuegaService js, JuegoService juegs){
        super();
        this.perfilServ = ps;
        this.juegaServ = js;
        this.juegoServ = juegs;
    }
 
    @GetMapping("/perfiles")
    public String listPerfiles(Model modelo){
        modelo.addAttribute("perfiles", this.perfilServ.getAllPerfiles());

        return "perfiles";
    }

    @GetMapping("/perfiles/new")
    public String crearPerfil(Model modelo, @ModelAttribute("errorMessage") String errorMessage){
        Perfil perfil = new Perfil();

        modelo.addAttribute("perfil", perfil);
        modelo.addAttribute("errorMessage", errorMessage);

        return "create_perfil";
    }

    @PostMapping("/perfiles")
    public String savePerfil(@ModelAttribute("perfil") Perfil perfil,  RedirectAttributes redirectAttributes){
        try {            
            this.perfilServ.savePerfil(perfil);            
            return "redirect:/perfiles";
        } catch (DataIntegrityViolationException e) {
            redirectAttributes.addFlashAttribute("errorMessage", "El username ya está en uso. Intenta con otro.");
            return "redirect:/perfiles/new"; 
        }
    }

    @GetMapping("/perfiles/{username}/juegos/new")
    public String crearJuegoJugado(@PathVariable String username, Model modelo){
        Perfil perfil = this.perfilServ.getPerfilByUsername(username);
        List<Juego> juegosDisponibles = this.juegoServ.obtenerJuegosNoJugados(username);
        Juego juego = new Juego();
        
        modelo.addAttribute("juego", juego);
        modelo.addAttribute("juegosDisponibles", juegosDisponibles);
        modelo.addAttribute("perfil", perfil);

        return "create_jugada";
    }

    @PostMapping("/perfiles/{username}/juegos")
    public String saveJuegoJugado(@PathVariable String username, @ModelAttribute("juego") Juego juego){
        this.juegaServ.agregarRelacion(username, juego.getIdJuego());
        return "redirect:/perfiles/{username}/juegos";
    }

    @GetMapping("/perfiles/edit/{username}")
    public String editarPerfil(@PathVariable String username, Model modelo){
        modelo.addAttribute("perfil", this.perfilServ.getPerfilByUsername(username));
        return "edit_perfil";
    }

    @PostMapping("/perfiles/{username}")
    public String updatePerfil(@PathVariable String username, @ModelAttribute("perfil") Perfil perfil, Model modelo){
        Perfil perfilCogido = this.perfilServ.getPerfilByUsername(username);
        
        perfilCogido.setAvatar(perfil.getAvatar());
        perfilCogido.setBiografia(perfil.getBiografia());

        this.perfilServ.updatePerfil(perfilCogido);

        return "redirect:/perfiles";
    }

    @GetMapping("/perfiles/{username}/juegos/edit/{id}")
    public String editJugada(@PathVariable String username, @PathVariable int id, Model model) {   
        Perfil perfil = perfilServ.getPerfilByUsername(username);
        Juego juegoViejo = juegoServ.getJuegoById(id);
        Juego juegoNuevo = new Juego();

        List<Juego> juegosDisponibles = juegoServ.obtenerJuegosNoJugados(username);
        
        model.addAttribute("perfil", perfil);
        model.addAttribute("juegoViejo", juegoViejo);
        model.addAttribute("juegoNuevo", juegoNuevo);
        model.addAttribute("juegosDisponibles", juegosDisponibles);
        
        return "edit_jugada";
    }

    @PostMapping("/perfiles/{username}/juegos/{id}")
    public String updateJugada(@PathVariable String username, @PathVariable int id, 
                            @ModelAttribute Juego juegoNuevo) {
        juegaServ.modificarRelacion(username, id, juegoNuevo.getIdJuego());
        return "redirect:/perfiles/{username}/juegos";
    }

    @GetMapping("/perfiles/{username}")
    public String deletePerfil(@PathVariable String username){
        this.perfilServ.deletePerfilByUsername(username);

        return "redirect:/perfiles";

    }

    @GetMapping("/perfiles/{username}/juegos/{id}")
    public String deleteJuegoJugado(@PathVariable String username, @PathVariable Integer id){
        this.juegaServ.eliminarRelacion(username, id);

        return "redirect:/perfiles/{username}/juegos";

    }

    @GetMapping("/perfiles/{username}/resenias")
    public String listResenias(@PathVariable String username, Model modelo){
        Perfil perfil = this.perfilServ.getPerfilByUsername(username);
        modelo.addAttribute("perfil", perfil);
        modelo.addAttribute("resenias",perfil.getListaJuegosReseniados() );
        return "perfiles_resenias";
    }

    

    @GetMapping("/perfiles/{username}/juegos")
    public String listJuegosJugados(@PathVariable String username, Model modelo){
        Perfil perfil = this.perfilServ.getPerfilByUsername(username);
        modelo.addAttribute("perfil", perfil);
        modelo.addAttribute("juegos",perfil.getListaJuegosJugados() );
        return "perfiles_juegos";
    }

    @GetMapping("/perfiles/{username}/usuario")
    public String usuarioAsociado(@PathVariable String username, Model modelo){
        Perfil perfil = this.perfilServ.getPerfilByUsername(username);
        modelo.addAttribute("perfil", perfil);
        if ( perfil.getUsuario() != null ){
            modelo.addAttribute("usuario",perfil.getUsuario() );
        } else {
            modelo.addAttribute("usuario", new Usuario() );
        }
        return "perfiles_usuario";
    }

}
