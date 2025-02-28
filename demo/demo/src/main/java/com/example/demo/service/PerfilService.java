package com.example.demo.service;

import java.util.List;

import com.example.demo.entity.Perfil;

public interface PerfilService {
    
    List<Perfil> getAllPerfiles();

    List<Perfil> getAllPerfilesSinRepetirEnUsuario();

    Perfil savePerfil(Perfil perfil);

    Perfil updatePerfil(Perfil perfil);

    Perfil getPerfilByUsername(String username);

    void deletePerfilByUsername(String username);
}