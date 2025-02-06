/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;
import java.io.Serializable;

/**
 *
 * @author Alex
 */

@Entity
@Table(name="usuario")
public class Usuario implements Serializable {
    
    //Atributos
    @Id
    @Column(name="correo", nullable = false, length = 60, unique = true)
    private String correo;
    
    @Column(name="nombre", nullable = false, length = 45)
    private String nombre;
    
    @Column(name="apellidos", nullable = false, length = 45)
    private String apellidos;
    
    @Column(name="contrasenia", nullable = false, length = 45)
    private String contrasenia;
    
    @Column(name="pais", nullable = false, length = 45)
    private String pais;
    
    @Column(name="tipo", nullable = false, length = 45)
    private String tipo;
    
    @OneToOne()
    @JoinColumn(name = "username", unique = true)
    private Perfil perfil;
    
    //Constructor con parámetros
    public Usuario(String correo, String nombre, String apellidos, String contrasenia, String pais, String tipo, Perfil perfil) {
        this.correo = correo;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contrasenia = contrasenia;
        this.pais = pais;
        this.tipo = tipo;
        this.perfil = perfil;
    }
    
    //Constructor sin parámetros
    public Usuario() {
        this.perfil = new Perfil();
    }
    
    //Set's
    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public void setContrasenia(String contrasenia) {
        this.contrasenia = contrasenia;
    }

    public void setPais(String pais) {
        this.pais = pais;
    }
    
    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public void setPerfil(Perfil perfil) {
        this.perfil = perfil;
    }
    
    //Get's
    public String getCorreo() {
        return correo;
    }

    public String getNombre() {
        return nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public String getContrasenia() {
        return contrasenia;
    }

    public String getPais() {
        return pais;
    }

    public String getTipo() {
        return tipo;
    }

    public Perfil getPerfil() {
        return perfil;
    }

    @Override
    public String toString() {
        return "Usuario{" + "correo=" + correo + ", nombre=" + nombre + ", apellidos=" + apellidos + ", contrasenia=" + contrasenia + ", pais=" + pais + ", tipo=" + tipo + ", perfil=" + perfil + '}';
    }
    
}
