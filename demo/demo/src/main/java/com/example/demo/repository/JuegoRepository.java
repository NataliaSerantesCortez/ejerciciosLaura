package com.example.demo.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.demo.entity.Juego;

@Repository
public interface JuegoRepository extends JpaRepository<Juego,Integer>{
    @Query("SELECT j FROM Juego j WHERE j NOT IN (SELECT j FROM Perfil p JOIN p.listaJuegosJugados j WHERE p.username = :username)")
    List<Juego> findJuegosNoJugados(@Param("username") String username);
} 