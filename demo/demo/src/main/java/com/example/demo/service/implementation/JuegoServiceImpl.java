package com.example.demo.service.implementation;

import java.util.List;

import org.springframework.stereotype.Service;

import com.example.demo.entity.Juego;
import com.example.demo.repository.JuegoRepository;
import com.example.demo.service.JuegoService;

@Service
public class JuegoServiceImpl implements JuegoService{

    private JuegoRepository juegoRepo;
    
    public JuegoServiceImpl(JuegoRepository jr){
        super();
        this.juegoRepo = jr;
    }

    @Override
    public List<Juego> obtenerJuegosNoJugados(String username) {
        return this.juegoRepo.findJuegosNoJugados(username);
    }

    @Override
    public List<Juego> getAllJuegos() {
        return this.juegoRepo.findAll();
    }

    @Override
    public Juego saveJuego(Juego juego) {
        return this.juegoRepo.save(juego);
    }

    @Override
    public Juego updateJuego(Juego juego) {
        return this.juegoRepo.save(juego);
    }

    @Override
    public Juego getJuegoById(Integer id) {
        return this.juegoRepo.findById(id).get();
    }

    @Override
    public void deleteJuegoById(Integer id) {
        this.juegoRepo.deleteById(id);
    }
    
}
