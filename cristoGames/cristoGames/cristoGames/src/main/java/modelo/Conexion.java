/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import jakarta.persistence.Query;
import java.time.LocalDateTime;
import java.util.List;
import org.hibernate.Session;

/**
 *
 * @author natal
 */
public class Conexion {
    //constructores
    public Conexion(){
    }
    
    public List<Genero> leerGeneros() throws Exception{
        List<Genero> listaGeneros; 
        Session sesion = null;
        try {
            sesion = HibernateUtil.getCurrentSession();
            Query query = sesion.createQuery("FROM Genero", Genero.class);            
            listaGeneros = query.getResultList();            
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        } finally {
            if (sesion != null && sesion.isOpen()) {
                sesion.close();
            }
        }
        return listaGeneros;
    }
    
    public Genero obtenerGeneroPorId( Integer id ) throws Exception{
        Genero genero = null;
            
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            genero = sesion.get(Genero.class, id);
            sesion.getTransaction().commit();
           // sesion.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            throw e;
        }        
        return genero;
    }
    
    public List<Juego> leerJuegos() throws Exception{
        List<Juego> listaJuegos; 
        Session sesion = null;
        try {
            sesion = HibernateUtil.getCurrentSession();
            Query query = sesion.createQuery("FROM Juego", Juego.class);            
            listaJuegos = query.getResultList();            
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        } finally {
            if (sesion != null && sesion.isOpen()) {
                sesion.close();
            }
        }
        return listaJuegos;
    }
    
    public Juego obtenerJuegoPorId( Integer id ) throws Exception{
        Juego juego = null;
            
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            juego = sesion.get(Juego.class, id);
            sesion.getTransaction().commit();
           // sesion.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            throw e;
        }        
        return juego;
    }
    
    public List<Perfil> leerPerfiles() throws Exception{
        List<Perfil> listaPerfiles; 
        Session sesion = null;
        try {
            sesion = HibernateUtil.getCurrentSession();
            Query query = sesion.createQuery("FROM Perfil", Perfil.class);            
            listaPerfiles = query.getResultList();            
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        } finally {
            if (sesion != null && sesion.isOpen()) {
                sesion.close();
            }
        }
        return listaPerfiles;
    }
    
    public Perfil obtenerPerfilPorUsername( String username ) throws Exception{
        Perfil perfil = null;
            
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            perfil = sesion.get(Perfil.class, username);
            sesion.getTransaction().commit();
            //sesion.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            throw e;
        }        
        return perfil;
    }
    
    public List<Usuario> leerUsuarios() throws Exception{
        List<Usuario> listaUsuarios; 
        Session sesion = null;
        try {
            sesion = HibernateUtil.getCurrentSession();
            Query query = sesion.createQuery("FROM Usuario", Usuario.class);            
            listaUsuarios = query.getResultList();            
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        } finally {
            if (sesion != null && sesion.isOpen()) {
                sesion.close();
            }
        }
        return listaUsuarios;
    }
    
    public Usuario obtenerUsuarioPorCorreo( String correo ) throws Exception{
        Usuario usuario = null;
            
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            usuario = sesion.get(Usuario.class, correo);
            sesion.getTransaction().commit();
            //sesion.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            throw e;
        }        
        return usuario;
    }
    
    public List<Resenia> leerResenias() throws Exception{
        List<Resenia> listaResenias; 
        Session sesion = null;
        try {
            sesion = HibernateUtil.getCurrentSession();
            Query query = sesion.createQuery("FROM Resenia", Resenia.class);            
            listaResenias = query.getResultList();            
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        } finally {
            if (sesion != null && sesion.isOpen()) {
                sesion.close();
            }
        }
        return listaResenias;
    }
    
    public Resenia obtenerReseniaPorPK( PKCompuestaResenia pk ) throws Exception{
        Resenia resenia = null;
            
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            resenia = sesion.get(Resenia.class, pk);
            sesion.getTransaction().commit();
           // sesion.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            throw e;
        }        
        return resenia;
    }
    
    public void insertarGenero( Genero genero ) throws Exception{
        try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            sesion.persist(genero);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void insertarJuego( Juego juego ) throws Exception{
        try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            sesion.persist(juego);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void insertarPerfil( Perfil perfil ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            sesion.persist(perfil);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void insertarUsuario( Usuario usuario ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            sesion.persist(usuario);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void insertarResenia( Resenia resenia ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            sesion.persist(resenia);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void insertarJugada( Juego juego, Perfil perfil ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            juego.getListaPerfilesJugadores().add(perfil);
            perfil.getListaJuegosJugados().add(juego);
            sesion.update(juego);
            sesion.update(perfil);
            
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void eliminarGenero( Integer idGenero ) throws Exception{
        try {
            Session sesion = HibernateUtil.getCurrentSession();
            Genero genero = sesion.get(Genero.class, idGenero);
            sesion.beginTransaction();            
            sesion.delete(genero);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }      
    }
    
    public void eliminarJuego( Integer idJuego ) throws Exception{
         try {
            Session sesion = HibernateUtil.getCurrentSession();   
            sesion.beginTransaction(); 
            
            Juego juego = sesion.get(Juego.class, idJuego); 
            
            if ( juego !=null ){
                sesion.delete(juego);
            } else {
                System.out.println("el juego con id : " + idJuego + " no existe");
            }
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }     
    }
    
    public void eliminarPerfil( String username ) throws Exception{
         try {
            Session sesion = HibernateUtil.getCurrentSession();
            Perfil perfil = sesion.get(Perfil.class, username);
            sesion.beginTransaction();            
            sesion.delete(perfil);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }     
    }
    
    public void eliminarUsuario( String correo ) throws Exception{
         try {
            Session sesion = HibernateUtil.getCurrentSession();
            Usuario usuario = sesion.get(Usuario.class, correo);
            sesion.beginTransaction();            
            sesion.delete(usuario);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }     
    }
    
    public void eliminarResenia( PKCompuestaResenia pk ) throws Exception{
         try {
            Session sesion = HibernateUtil.getCurrentSession();
            Resenia resenia = sesion.get(Resenia.class, pk);
            sesion.beginTransaction();            
            sesion.delete(resenia);
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }     
    }
    
    public void eliminarJugada( Juego juego, Perfil perfil ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            juego.getListaPerfilesJugadores().remove(perfil);
            perfil.getListaJuegosJugados().remove(juego);
            sesion.update(juego);
            sesion.update(perfil);
            
            sesion.getTransaction().commit();
            sesion.close();
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarGenero( Genero genero ) throws Exception{
        try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            sesion.merge(genero);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarJuego( Juego juego ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            sesion.merge(juego);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarPerfil( Perfil perfil ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            sesion.merge(perfil);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarUsuario( Usuario usuario ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            sesion.merge(usuario);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarResenia( Resenia resenia ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            //ponemos la hora actual al hacer la nueva reseña
            LocalDateTime fechaConHora = LocalDateTime.now();
            resenia.getpK().setFecha(fechaConHora);            
            
            sesion.merge(resenia);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void modificarJugada( Juego juego, Perfil perfil, Juego juegoNuevo, Perfil perfilNuevo ) throws Exception{
         try{
            Session sesion = HibernateUtil.getCurrentSession();
            sesion.beginTransaction();
            
            //insertar nuevo
            juegoNuevo.getListaPerfilesJugadores().add(perfilNuevo);
            perfilNuevo.getListaJuegosJugados().add(juegoNuevo);
            sesion.update(juegoNuevo);
            sesion.update(perfilNuevo);
            
            //eliminar viejo
            juego.getListaPerfilesJugadores().remove(perfil);
            perfil.getListaJuegosJugados().remove(juego);
            sesion.update(juego);
            sesion.update(perfil);
            
            sesion.getTransaction().commit();
            sesion.close();     
        } catch ( Exception e ){
            System.out.println(e.getMessage());
            throw e;
        }
    }
    
    public void cerrarBaseDeDatos() {
        HibernateUtil.closeSessionFactory();
    }
}
