/*
 * @file HibernateUtil.java
 * @brief Programación de la clase HibernateUtil perteneciente al modelo del programa.
 * @version 1.0
 * @date 03/02/2025
 * @author Alexmrdgz
 * @copyright Copyright (c) 2025
 */

package modelo;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.ServiceRegistry;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;

public class HibernateUtil {
    
    //Atributos
    private static SessionFactory sessionFactory = null;
    private static Session session = null;
    
    //Métodos
    
    //Crea la factoria de sesiones
    public static void buildSessionFactory() {
        Configuration configuration = new Configuration();
        configuration.configure();
    
        // Se registran las clases que hay que mapear con cada tabla de la base de datos
        configuration.addAnnotatedClass(Genero.class);
        configuration.addAnnotatedClass(Juego.class);
        configuration.addAnnotatedClass(Perfil.class);
        configuration.addAnnotatedClass(Resenia.class);
        configuration.addAnnotatedClass(Usuario.class);
        
        ServiceRegistry serviceRegistry = new StandardServiceRegistryBuilder().applySettings(
        configuration.getProperties()).build();
        sessionFactory = configuration.buildSessionFactory(serviceRegistry);
    }
    
    //Abre una nueva sesión
    public static void openSession() {
        if (sessionFactory == null) {
            buildSessionFactory();
        }
        session = sessionFactory.openSession();
    }
    
    //Devuelve la sesión actual
    public static Session getCurrentSession() {
        if ((session == null) || (!session.isOpen())) {
            openSession();
        }
        return session;
    }
    
    //Cierra Hibernate
    public static void closeSessionFactory() {
        if (session != null) {
          session.close();
        }   
        
        if (sessionFactory != null) {
            sessionFactory.close();
        }
    }   
}
