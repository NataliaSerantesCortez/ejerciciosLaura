/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.cristogames;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import modelo.Conexion;
import modelo.Genero;
import modelo.HibernateUtil;
import modelo.Juego;
import modelo.PKCompuestaResenia;
import modelo.Perfil;
import modelo.Resenia;
import modelo.Usuario;
import org.hibernate.Session;

/**
 *
 * @author Alex
 */
public class CristoGames {

    public static void main(String[] args) {
       /* System.out.println("Hello World!");
        
        // TEST HIBERNATE
        
        // Cojo la sesion de usuario
        Session session = HibernateUtil.getCurrentSession();
        
        // Comienzo transaccion
        session.beginTransaction();
        
        LocalDate fecha = LocalDate.now();
        LocalDateTime fechaConHora = LocalDateTime.parse("2025-02-05T10:29:16");
        // Inserto Genero
        Genero genero = new Genero(0, "Genero inventado");
        // Inserto juego
        Juego juego = new Juego(6, "Crash", "estudio", "crash.png", fecha, genero);
        // Inserto perfil
        Perfil perfil = new Perfil("teffuka", "imagen.png", "holaaaa");
        
        PKCompuestaResenia pk = new PKCompuestaResenia("teffuka", 7, fechaConHora);
        
        Resenia resenia = new Resenia(pk, perfil, juego, "juego muy bueno", 3);

        // Guardo el empleado
        session.persist(genero);
        session.persist(juego);
        session.persist(perfil);
        session.persist(resenia);

        // Termino transaccion guardando los cambios
        session.getTransaction().commit();            
        
        // PRUEBA DE RELACIONES
        
        session.beginTransaction();
        
        System.out.println("AQUI\n\n");
        System.out.println(session.get(Juego.class, 7));
        System.out.println(session.get(Perfil.class, "teffuka"));
        System.out.println(session.get(Resenia.class, pk));
        
        session.getTransaction().commit();        
        
        // Cierro base de datos
        HibernateUtil.closeSessionFactory();*/ 
        
        Conexion conexion = new Conexion();
        
        try {        
            
            LocalDate fecha = LocalDate.now();
            LocalDateTime fechaConHora = LocalDateTime.now();        
            
            Genero genero = new Genero("guerra7");
            Juego juego = new Juego("candycrush", "estudio", "caratula", fecha, genero );
            Perfil perfil = new Perfil("usuario7", "imagen.png", "biografia" );
            Usuario usuario = new Usuario("user@example7", "nat", "ser", "1234", "arg", "admin", perfil );
            
            System.out.println("PRUEBAS DE INSERTAR");
            conexion.insertarGenero(genero);
            conexion.insertarJuego(juego);
            conexion.insertarPerfil(perfil);
            conexion.insertarUsuario(usuario);      
            
            List<Genero> listaGeneros = conexion.leerGeneros();
            List<Juego> listaJuegos = conexion.leerJuegos();
            List<Perfil> listaPerfiles = conexion.leerPerfiles();            
            List<Usuario> listaUsuarios = conexion.leerUsuarios();
            List<Resenia> listaResenias = conexion.leerResenias();
            
            System.out.println( listaUsuarios);
            System.out.println(listaGeneros);            
            System.out.println(listaJuegos);
            System.out.println( listaPerfiles );
            System.out.println( listaResenias );         
            
            System.out.println("PRUEBAS DE OBTENER PERFIL Y USUARIO");
            Perfil perfil1 = conexion.obtenerPerfilPorUsername("usuario7");
            System.out.println(perfil1);
            Usuario usuario1 = conexion.obtenerUsuarioPorCorreo("user@example7");
            System.out.println(usuario1);
           System.out.println("PRUEBAS DE OBTENER GENERO Y JUEGO");
            Genero genero1 = conexion.obtenerGeneroPorId(1);
            System.out.println(genero1);
            Juego juego1 = conexion.obtenerJuegoPorId(1);
            System.out.println(juego1);
            
            PKCompuestaResenia pk = new PKCompuestaResenia(perfil1.getUsername(), juego1.getIdJuego(), fechaConHora);        
            Resenia resenia = new Resenia(pk, perfil1, juego1, "juego malo", 1);
            
            System.out.println("PRUEBAS DE INSERTAR RESEÑA Y JUAGADA; Y OBTENER");
            conexion.insertarResenia(resenia);
            conexion.insertarJugada(juego, perfil);
            
            Resenia resenia1 = conexion.obtenerReseniaPorPK(pk);
            System.out.println(resenia1);
            
            juego.setCaratula("cambio imagen");
            genero.setNombre("cambio nombre7");
            perfil.setAvatar("cambio avatar");
            usuario.setApellidos("cambio apellidos");
            resenia.setCalificacion(2);
            
            System.out.println("PRUEBAS DE MODIFICAR");
            conexion.modificarGenero(genero);
            conexion.modificarJuego(juego);
            conexion.modificarPerfil(perfil);
            conexion.modificarUsuario(usuario);
            conexion.modificarResenia(resenia);
            
            /*perfil1 = conexion.obtenerPerfilPorUsername("usuario6");
            juego1 = conexion.obtenerJuegoPorId(1);
            conexion.modificarJugada(juego, perfil, juego1, perfil1);*/   
            
            listaGeneros = conexion.leerGeneros();
            listaJuegos = conexion.leerJuegos();
            listaPerfiles = conexion.leerPerfiles();            
            listaUsuarios = conexion.leerUsuarios();
            listaResenias = conexion.leerResenias();
            
            System.out.println( listaUsuarios);
            System.out.println(listaGeneros);            
            System.out.println(listaJuegos);
            System.out.println( listaPerfiles );
            System.out.println( listaResenias );
            
            conexion.eliminarGenero(1);
            //conexion.eliminarResenia(pk);
            conexion.eliminarJugada(juego, perfil);
            conexion.eliminarJuego(1);
            conexion.eliminarPerfil("usuario7");
            //conexion.eliminarUsuario("user@example7");
           
            
            listaGeneros = conexion.leerGeneros();
            listaJuegos = conexion.leerJuegos();
            listaPerfiles = conexion.leerPerfiles();            
            listaUsuarios = conexion.leerUsuarios();
            listaResenias = conexion.leerResenias();
            
            System.out.println( listaUsuarios);
            System.out.println(listaGeneros);            
            System.out.println(listaJuegos);
            System.out.println( listaPerfiles );
            System.out.println( listaResenias );
            

        } catch ( Exception e ){
           e.printStackTrace();
        }    
        
        // Cierro base de datos
        HibernateUtil.closeSessionFactory();
    }
}
