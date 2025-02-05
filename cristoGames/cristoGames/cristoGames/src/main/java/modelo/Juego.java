/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;
import java.io.Serializable;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Alex
 */

@Entity
@Table(name="juego")
public class Juego implements Serializable {
    
    //Atributos
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name="idJuego", nullable = false, unique = true)
    private int idJuego;
    
    @Column(name="nombre", length = 45, nullable = false)
    private String nombre;
    
    @Column(name="estudio", length = 45, nullable = false)
    private String estudio;
    
    @Column(name="caratula", length = 100, nullable = true)
    private String caratula;
    
    @Column(name="lanzamiento", nullable = false)
    private LocalDate lanzamiento;
    
    @ManyToOne
    @JoinColumn(name = "idGenero")
    private Genero genero;
    
    @ManyToMany(mappedBy = "listaJuegosJugados")
    private List<Perfil> listaPerfilesJugadores;
    
    @OneToMany(mappedBy = "juego")
    private List<Resenia> listaResenias;
    
    //Constructor con parámetros
    public Juego(int idJuego, String nombre, String estudio, String caratula, LocalDate lanzamiento, Genero genero, List<Perfil> listaPerfilesJugadores, List<Resenia> listaResenias) {
        this.idJuego = idJuego;
        this.nombre = nombre;
        this.estudio = estudio;
        this.caratula = caratula;
        this.lanzamiento = lanzamiento;
        this.genero = genero;
        this.listaPerfilesJugadores = listaPerfilesJugadores;
        this.listaResenias = listaResenias;
    }
    
    //Constructor con parámetros 2
    public Juego(int idJuego, String nombre, String estudio, String caratula, LocalDate lanzamiento, Genero genero) {
        this.idJuego = idJuego;
        this.nombre = nombre;
        this.estudio = estudio;
        this.caratula = caratula;
        this.lanzamiento = lanzamiento;
        this.genero = genero;
        this.listaPerfilesJugadores = new ArrayList<>();
        this.listaResenias = new ArrayList<>();
    }
    
    //Constructor sin parámetros
    public Juego() {
        this.genero = new Genero();
    }
    
    //Set's
    public void setIdJuego(int idJuego) {
        this.idJuego = idJuego;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEstudio(String estudio) {
        this.estudio = estudio;
    }

    public void setCaratula(String caratula) {
        this.caratula = caratula;
    }

    public void setLanzamiento(LocalDate lanzamiento) {
        this.lanzamiento = lanzamiento;
    }

    public void setGenero(Genero genero) {
        this.genero = genero;
    }

    public void setListaPerfilesJugadores(List<Perfil> listaPerfilesJugadores) {
        this.listaPerfilesJugadores = listaPerfilesJugadores;
    }

    public void setListaResenias(List<Resenia> listaResenias) {
        this.listaResenias = listaResenias;
    }
    
    //Get's
    public int getIdJuego() {
        return idJuego;
    }

    public String getNombre() {
        return nombre;
    }

    public String getEstudio() {
        return estudio;
    }

    public String getCaratula() {
        return caratula;
    }

    public LocalDate getLanzamiento() {
        return lanzamiento;
    }

    public Genero getGenero() {
        return genero;
    }

    public List<Perfil> getListaPerfilesJugadores() {
        return listaPerfilesJugadores;
    }

    public List<Resenia> getListaResenias() {
        return listaResenias;
    }
}
