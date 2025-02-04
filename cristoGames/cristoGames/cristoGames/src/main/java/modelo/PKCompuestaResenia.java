/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import jakarta.persistence.Embeddable;
import java.io.Serializable;
import java.time.LocalDateTime;

/**
 *
 * @author Alex
 */

@Embeddable
public class PKCompuestaResenia implements Serializable {
    
    private String username;
    private int idJuego;
    private LocalDateTime fecha;
    
    //Constructor con parámetros
    public PKCompuestaResenia(String username, int idJuego, LocalDateTime fecha) {
        this.username = username;
        this.idJuego = idJuego;
        this.fecha = fecha;
    }
    
    //Constructor sin parámetros
    public PKCompuestaResenia() {
        
    }
    
    //Set's
    public void setUsername(String username) {
        this.username = username;
    }

    public void setIdJuego(int idJuego) {
        this.idJuego = idJuego;
    }

    public void setFecha(LocalDateTime fecha) {
        this.fecha = fecha;
    }
    
    //Get's
    public String getUsername() {
        return username;
    }

    public int getIdJuego() {
        return idJuego;
    }

    public LocalDateTime getFecha() {
        return fecha;
    }  
}
