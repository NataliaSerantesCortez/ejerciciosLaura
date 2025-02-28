package com.example.demo.service;

import java.util.List;

import com.example.demo.entity.Genero;

public interface GeneroService {
    
    List<Genero> getAllGeneros();
    
    List<String> obtenerTodosLosNombres();

    Genero saveGenero(Genero genero);

    Genero updateGenero(Genero genero);

    Genero getGeneroById(Integer id);

    void deleteGeneroById(Integer id);
}