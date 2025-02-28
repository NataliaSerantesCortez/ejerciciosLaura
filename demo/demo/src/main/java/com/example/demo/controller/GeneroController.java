package com.example.demo.controller;


import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

import com.example.demo.entity.Genero;
import com.example.demo.service.GeneroService;

import org.springframework.ui.Model;

@Controller
public class GeneroController {

    private GeneroService generoServ;
    private List<String> generos;

    public GeneroController(GeneroService gs){
        super();
        this.generoServ = gs;
        generos = Arrays.asList(
        "Acción", "Aventura", "RPG", "Shooter", "Estrategia", "Survival Horror",
        "Lucha", "Plataformas", "Carreras", "Simulación", "Deportes", "Música",
        "Party", "Metroidvania", "Roguelike", "MOBA", "Battle Royale",
        "MMORPG", "Sandbox", "Puzles", "Stealth", "Hack and Slash",
        "Terror", "Táctico", "Defensa de Torres", "Idle", "Visual Novel",
        "Beat 'em up", "Bullet Hell", "Realidad Virtual", "Auto Battler"
         );
    }
 
    @GetMapping("/generos")
    public String listGeneros(Model modelo){
        modelo.addAttribute("generos", this.generoServ.getAllGeneros());

        return "generos";
    }

    @GetMapping("/generos/new")
    public String crearGenero(Model modelo){
        Genero genero = new Genero();

        List<String> generosExistentes = generoServ.obtenerTodosLosNombres();
        List<String> generosDisponibles = generos.stream()
        .filter(g -> !generosExistentes.contains(g))
        .collect(Collectors.toList());

        modelo.addAttribute("genero", genero);
        modelo.addAttribute("generosDisponibles", generosDisponibles); 

        return "create_genero";
    }

    @PostMapping("/generos")
    public String saveGenero(@ModelAttribute("genero") Genero genero){
        this.generoServ.saveGenero(genero);
        return "redirect:/generos";
    }

    @GetMapping("/generos/edit/{id}")
    public String editarGenero(@PathVariable Integer id, Model modelo){ 
        Genero genero = this.generoServ.getGeneroById(id);      
        List<String> generosExistentes = generoServ.obtenerTodosLosNombres();
        List<String> generosDisponibles = generos.stream()
        .filter(g -> !generosExistentes.contains(g))
        .collect(Collectors.toList());
        //para agregar también el propio
        generosDisponibles.add(genero.getNombre());

        modelo.addAttribute("genero", genero);
        modelo.addAttribute("generosDisponibles", generosDisponibles);

        return "edit_genero";
    }

    @PostMapping("/generos/{id}")
    public String updateGenero(@PathVariable Integer id, @ModelAttribute("genero") Genero genero, Model modelo){
        Genero generoCogido = this.generoServ.getGeneroById(id);
        
        generoCogido.setNombre(genero.getNombre());

        this.generoServ.updateGenero(generoCogido);

        return "redirect:/generos";
    }

    @GetMapping("/generos/{id}")
    public String deleteGenero(@PathVariable Integer id){
        this.generoServ.deleteGeneroById(id);

        return "redirect:/generos";
    }

    @GetMapping("/generos/{id}/juegos")
    public String juegosGenero(@PathVariable Integer id, Model modelo){
        Genero genero = this.generoServ.getGeneroById(id);

        modelo.addAttribute("genero", genero);
        modelo.addAttribute("juegos", genero.getListaJuegos());

        return "generos_juegos";
    }
}