package com.example.demo.service.implementation;

import java.util.List;

import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Service;

import com.example.demo.entity.Usuario;
import com.example.demo.repository.UsuarioRepository;
import com.example.demo.service.UsuarioService;

@Service
public class UsuarioServiceImpl implements UsuarioService{

    private UsuarioRepository usuarioRepo;
    
    public UsuarioServiceImpl(UsuarioRepository ur){
        super();
        this.usuarioRepo = ur;
    }

    @Override
    public List<Usuario> getAllUsuarios() {
        return this.usuarioRepo.findAll();
    }

    @Override
    public Usuario saveUsuario(Usuario usuario) {
        if (this.usuarioRepo.existsById(usuario.getCorreo())) {
            throw new DataIntegrityViolationException("El correo ya está en uso.");
        }
        if (usuario.getPerfil() != null && usuario.getPerfil().getUsername() == null) {
            usuario.setPerfil(null);
        }
        return this.usuarioRepo.save(usuario);
    }

    @Override
    public Usuario updateUsuario(Usuario usuario) {
        if (usuario.getPerfil() != null && usuario.getPerfil().getUsername() == null) {
            usuario.setPerfil(null);
        }
        return this.usuarioRepo.save(usuario);
    }

    @Override
    public Usuario getUsuarioByCorreo(String correo) {
        return this.usuarioRepo.findById(correo).get();
    }

    @Override
    public void deleteUsuarioByCorreo(String correo) {
        this.usuarioRepo.deleteById(correo);
    }
    
}