package com.example.demo.service;

import java.util.List;

import com.example.demo.entity.Usuario;

public interface UsuarioService {
    
    List<Usuario> getAllUsuarios();

    Usuario saveUsuario(Usuario usuario);

    Usuario updateUsuario(Usuario usuario);

    Usuario getUsuarioByCorreo(String correo);

    void deleteUsuarioByCorreo(String correo);
}
