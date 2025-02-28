package com.example.demo.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.demo.entity.PKCompuestaResenia;
import com.example.demo.entity.Resenia;

@Repository
public interface ReseniaRepository extends JpaRepository<Resenia,PKCompuestaResenia>{

} 
