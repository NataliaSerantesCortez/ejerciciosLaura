package com.example.demo.service.implementation;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.demo.entity.Juego;
import com.example.demo.entity.Perfil;
import com.example.demo.repository.JuegoRepository;
import com.example.demo.repository.PerfilRepository;
import com.example.demo.service.JuegaService;

@Service
public class JuegaServiceImpl implements JuegaService{
    private JuegoRepository juegoRepo;
    private PerfilRepository perfilRepo;

    @Autowired
    public JuegaServiceImpl(JuegoRepository juegoRepo, PerfilRepository perfilRepo) {
        this.juegoRepo = juegoRepo;
        this.perfilRepo = perfilRepo;
    }

    @Override
    public void agregarRelacion(String username, Integer idJuego) {
        Juego juego = this.juegoRepo.findById(idJuego).get();
        Perfil perfil = this.perfilRepo.findById(username).get();
        juego.getListaPerfilesJugadores().add(perfil);
        perfil.getListaJuegosJugados().add(juego);
        this.juegoRepo.save(juego);
        this.perfilRepo.save(perfil);
    }

    @Override
    public void eliminarRelacion(String username, Integer idJuego) {
        Juego juego = this.juegoRepo.findById(idJuego).get();
        Perfil perfil = this.perfilRepo.findById(username).get();
        juego.getListaPerfilesJugadores().remove(perfil);
        perfil.getListaJuegosJugados().remove(juego);
        this.juegoRepo.save(juego);
        this.perfilRepo.save(perfil);
    }

    @Override
    public void modificarRelacion(String username, int idJuegoAntiguo, int idJuegoNuevo) {
        eliminarRelacion(username, idJuegoAntiguo);
        agregarRelacion(username, idJuegoNuevo);
    }
}
