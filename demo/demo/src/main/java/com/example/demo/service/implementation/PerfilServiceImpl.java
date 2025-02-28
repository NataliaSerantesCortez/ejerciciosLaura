package com.example.demo.service.implementation;

import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Service;

import com.example.demo.entity.Perfil;
import com.example.demo.entity.Usuario;
import com.example.demo.repository.PerfilRepository;
import com.example.demo.repository.UsuarioRepository;
import com.example.demo.service.PerfilService;

@Service
public class PerfilServiceImpl implements PerfilService{

    private PerfilRepository perfilRepo;
    private UsuarioRepository usuarioRepo;
    
    public PerfilServiceImpl(PerfilRepository pr, UsuarioRepository ur){
        super();
        this.perfilRepo = pr;
        this.usuarioRepo = ur;
    }

    @Override
    public List<Perfil> getAllPerfiles() {
        return this.perfilRepo.findAll();
    }

    @Override
    public List<Perfil> getAllPerfilesSinRepetirEnUsuario(){
        List<Perfil> listaPerfiles = this.perfilRepo.findAll();
        List<Usuario> listaUsuarios = this.usuarioRepo.findAll();

        Set<String> usernamesEnUsuarios = listaUsuarios.stream()
            .filter(usuario -> usuario.getPerfil() != null)
            .map(usuario -> usuario.getPerfil().getUsername()) 
            .collect(Collectors.toSet()); 

        List<Perfil> listaSinRepetir = listaPerfiles.stream()
            .filter(perfil -> !usernamesEnUsuarios.contains(perfil.getUsername()))
            .collect(Collectors.toList());
            
        return listaSinRepetir;
    }

    @Override
    public Perfil savePerfil(Perfil perfil) {
        if (this.perfilRepo.existsById(perfil.getUsername())) {
            throw new DataIntegrityViolationException("El username ya está en uso.");
        }
        return this.perfilRepo.save(perfil);
    }

    @Override
    public Perfil updatePerfil(Perfil perfil) {
        return this.perfilRepo.save(perfil);
    }

    @Override
    public Perfil getPerfilByUsername(String username) {
        return this.perfilRepo.findById(username).get();
    }

    @Override
    public void deletePerfilByUsername(String username) {
        this.perfilRepo.deleteById(username);
    }
    
}