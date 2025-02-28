package com.example.demo.controller;


import java.time.LocalDateTime;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

import com.example.demo.entity.PKCompuestaResenia;
import com.example.demo.entity.Resenia;
import com.example.demo.entity.Juego;
import com.example.demo.entity.Perfil;
import com.example.demo.service.JuegoService;
import com.example.demo.service.PerfilService;
import com.example.demo.service.ReseniaService;

import org.springframework.ui.Model;

@Controller
public class ReseniaController {

    private ReseniaService reseniaServ;
    private JuegoService juegoServ;
    private PerfilService perfilServ;

    public ReseniaController(ReseniaService rs, JuegoService js, PerfilService ps){
        super();
        this.reseniaServ = rs;
        this.juegoServ = js;
        this.perfilServ = ps;
    }
 
    @GetMapping("/resenias")
    public String listResenias(Model modelo){
        modelo.addAttribute("resenias", this.reseniaServ.getAllResenias());

        return "resenias";
    }

    @GetMapping("/resenias/new")
    public String crearResenia(Model modelo){
        Resenia resenia = new Resenia();

        modelo.addAttribute("resenia", resenia);
        modelo.addAttribute("juegos", this.juegoServ.getAllJuegos());
        modelo.addAttribute("perfiles", this.perfilServ.getAllPerfiles());

        return "create_resenia";
    }

    @PostMapping("/resenias")
    public String saveResenia(@ModelAttribute("resenia") Resenia resenia){
        System.out.println("\n\n\n\n ANTES");
        System.out.println(resenia);

        Juego juego = this.juegoServ.getJuegoById(resenia.getpK().getIdJuego());
        Perfil perfil = this.perfilServ.getPerfilByUsername(resenia.getpK().getUsername());
        LocalDateTime fecha = LocalDateTime.now();
        resenia.getpK().setFecha(fecha);
        resenia.setJuego(juego);
        resenia.setPerfil(perfil);

        System.out.println("\n\n\n\n DESPUÉS");
        System.out.println(resenia);
        this.reseniaServ.saveResenia(resenia);
        return "redirect:/resenias";
    }

    @GetMapping("/resenias/edit/{id}/{username}/{fecha}")
    public String editarResenia(@PathVariable("id") Integer idJuego,
                                @PathVariable("username") String username,
                                @PathVariable("fecha") LocalDateTime fecha, Model modelo){
                                  
        PKCompuestaResenia pK = new PKCompuestaResenia(username, idJuego, fecha);
        modelo.addAttribute("resenia", this.reseniaServ.getReseniaById(pK));
        modelo.addAttribute("juegos", this.juegoServ.getAllJuegos());
        modelo.addAttribute("perfiles", this.perfilServ.getAllPerfiles());
        return "edit_resenia";
    }

    @PostMapping("/resenias/{id}/{username}/{fecha}")
    public String updateResenia(@PathVariable("id") Integer idJuego,
                                @PathVariable("username") String username,
                                @PathVariable("fecha") LocalDateTime fecha, 
                                @ModelAttribute("resenia") Resenia resenia, Model modelo) {
        
        PKCompuestaResenia pKAntigua = new PKCompuestaResenia(username, idJuego, fecha);
        Resenia reseniaAntigua = this.reseniaServ.getReseniaById(pKAntigua);

        if (reseniaAntigua != null) {
            this.reseniaServ.deleteReseniaById(pKAntigua);
        }

        LocalDateTime nuevaFecha = LocalDateTime.now();
        PKCompuestaResenia pKNueva = new PKCompuestaResenia(resenia.getPerfil().getUsername(), resenia.getJuego().getIdJuego(), nuevaFecha);
        Resenia nuevaResenia = new Resenia();
        nuevaResenia.setpK(pKNueva);

        Juego juego = this.juegoServ.getJuegoById(nuevaResenia.getpK().getIdJuego());
        Perfil perfil = this.perfilServ.getPerfilByUsername(nuevaResenia.getpK().getUsername());
        nuevaResenia.setJuego(juego);
        nuevaResenia.setPerfil(perfil);
        nuevaResenia.setCalificacion(resenia.getCalificacion());
        nuevaResenia.setTexto(resenia.getTexto());

        this.reseniaServ.saveResenia(nuevaResenia);

        return "redirect:/resenias";
    }

    @GetMapping("/resenias/{id}/{username}/{fecha}")
    public String deleteResenia(@PathVariable("id") Integer idJuego,
                                @PathVariable("username") String username,
                                @PathVariable("fecha") LocalDateTime fecha){
        PKCompuestaResenia pK = new PKCompuestaResenia(username, idJuego, fecha);  
        this.reseniaServ.deleteReseniaById(pK);

        return "redirect:/resenias";
    }
}