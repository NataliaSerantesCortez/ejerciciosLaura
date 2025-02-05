/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.cristogames;

import java.time.LocalDate;
import java.time.LocalDateTime;
import modelo.Genero;
import modelo.HibernateUtil;
import modelo.Juego;
import modelo.PKCompuestaResenia;
import modelo.Perfil;
import modelo.Resenia;
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
    }
}
