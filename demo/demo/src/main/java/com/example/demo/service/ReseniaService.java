package com.example.demo.service;

import java.util.List;

import com.example.demo.entity.PKCompuestaResenia;
import com.example.demo.entity.Resenia;

public interface ReseniaService {
    List<Resenia> getAllResenias();

    Resenia saveResenia(Resenia juego);

    Resenia updateResenia(Resenia juego);

    Resenia getReseniaById(PKCompuestaResenia pK);

    void deleteReseniaById(PKCompuestaResenia pK);
}
