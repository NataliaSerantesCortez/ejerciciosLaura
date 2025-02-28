package com.example.demo.service;

import java.util.List;

import com.example.demo.entity.Juego;

public interface JuegoService {
    
    List<Juego> getAllJuegos();

    List<Juego> obtenerJuegosNoJugados(String username);

    Juego saveJuego(Juego juego);

    Juego updateJuego(Juego juego);

    Juego getJuegoById(Integer id);

    void deleteJuegoById(Integer id);

}
