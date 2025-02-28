package com.example.demo.controller;


import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

import com.example.demo.entity.Juego;
import com.example.demo.entity.Genero;
import com.example.demo.service.GeneroService;
import com.example.demo.service.JuegoService;

import org.springframework.ui.Model;

@Controller
public class JuegoController {

    private JuegoService juegoServ;
    private GeneroService generoServ;

    public JuegoController(JuegoService js, GeneroService gs){
        super();
        this.juegoServ = js;
        this.generoServ = gs;
    }
 
    @GetMapping("/juegos")
    public String listJuegos(Model modelo){
        modelo.addAttribute("juegos", this.juegoServ.getAllJuegos());

        return "juegos";
    }

    @GetMapping("/juegos/new")
    public String crearJuego(Model modelo){
        Juego juego = new Juego();

        modelo.addAttribute("juego", juego);
        modelo.addAttribute("generos", generoServ.getAllGeneros());

        return "create_juego";
    }

    @PostMapping("/juegos")
    public String saveJuego(@ModelAttribute("juego") Juego juego){
        this.juegoServ.saveJuego(juego);
        return "redirect:/juegos";
    }

    @GetMapping("/juegos/edit/{id}")
    public String editarJuego(@PathVariable Integer id, Model modelo){
        modelo.addAttribute("juego", this.juegoServ.getJuegoById(id));
        modelo.addAttribute("generos", generoServ.getAllGeneros());
        return "edit_juego";
    }

    @PostMapping("/juegos/{id}")
    public String updateJuego(@PathVariable Integer id, @ModelAttribute("juego") Juego juego, Model modelo){
        Juego juegoCogido = this.juegoServ.getJuegoById(id);
        
        juegoCogido.setNombre(juego.getNombre());
        juegoCogido.setEstudio(juego.getEstudio());
        juegoCogido.setCaratula(juego.getCaratula());
        juegoCogido.setLanzamiento(juego.getLanzamiento());

        Genero genero = this.generoServ.getGeneroById(juego.getGenero().getIdGenero());
        juegoCogido.setGenero(genero);

        this.juegoServ.updateJuego(juegoCogido);

        return "redirect:/juegos";
    }

    @GetMapping("/juegos/{id}")
    public String deleteJuego(@PathVariable Integer id){
        this.juegoServ.deleteJuegoById(id);

        return "redirect:/juegos";

    }
    @GetMapping("/juegos/{id}/resenias")
    public String listResenias(@PathVariable Integer id, Model modelo){
        Juego juego = this.juegoServ.getJuegoById(id);
        modelo.addAttribute("juego", juego);
        modelo.addAttribute("resenias",juego.getListaResenias() );
        return "juegos_resenias";
    }

    @GetMapping("/juegos/{id}/jugadores")
    public String listJugadores(@PathVariable Integer id, Model modelo){
        Juego juego = this.juegoServ.getJuegoById(id);
        modelo.addAttribute("juego", juego);
        modelo.addAttribute("jugadores",juego.getListaPerfilesJugadores() );
        return "juegos_jugadores";
    }
}