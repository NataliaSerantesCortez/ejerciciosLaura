package com.example.demo.service;

public interface JuegaService {
    void agregarRelacion(String username, Integer idJuego);
    void eliminarRelacion(String username, Integer idJuego);
    void modificarRelacion(String username, int idJuegoAntiguo, int idJuegoNuevo);
}
