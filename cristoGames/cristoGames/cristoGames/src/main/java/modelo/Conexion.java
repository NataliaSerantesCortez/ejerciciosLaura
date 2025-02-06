/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import jakarta.persistence.Query;
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
        return null;
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
        return null;
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
        return null;
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
        return null;
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
        return null;
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
        //hacer un get a la base de datos
    }
    
    public void eliminarJuego( Integer idJuego ) throws Exception{
        //hacer un get a la base de datos
    }
    
    public void eliminarPerfil( String username ) throws Exception{
        //hacer un get a la base de datos
    }
    
    public void eliminarUsuario( String correo ) throws Exception{
        //hacer un get a la base de datos
    }
    
    public void eliminarResenia( PKCompuestaResenia pk ) throws Exception{
        //hacer un get a la base de datos
    }
    
    public void eliminarJugada( Integer idJuego, String username ) throws Exception{
        //hacer un get a la base de datos
    }
    
    public void modificarGenero( Genero genero ) throws Exception{
        
    }
    
    public void modificarJuego( Juego juego ) throws Exception{
        
    }
    
    public void modificarPerfil( Perfil perfil ) throws Exception{
        
    }
    
    public void modificarUsuario( Usuario usuario ) throws Exception{
        
    }
    
    public void modificarResenia( Resenia resenia ) throws Exception{
        
    }
    
    public void modificarJugada( Juego juego, Perfil perfil ) throws Exception{
        
    }
    
    public void cerrarBaseDeDatos() {
        HibernateUtil.closeSessionFactory();
    }
}
