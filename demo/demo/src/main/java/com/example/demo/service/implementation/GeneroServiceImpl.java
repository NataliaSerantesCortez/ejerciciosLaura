package com.example.demo.service.implementation;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import com.example.demo.entity.Genero;
import com.example.demo.repository.GeneroRepository;
import com.example.demo.service.GeneroService;

@Service
public class GeneroServiceImpl implements GeneroService{

    private GeneroRepository generoRepo;
    
    public GeneroServiceImpl(GeneroRepository gr){
        super();
        this.generoRepo = gr;
    }

    @Override
    public List<Genero> getAllGeneros() {
        return this.generoRepo.findAll();
    }

    @Override
    public List<String> obtenerTodosLosNombres(){
        List<String> nombresGeneros = new ArrayList<>();

        for ( Genero g : this.generoRepo.findAll()){
            nombresGeneros.add(g.getNombre());
        }

        return nombresGeneros;
    }

    @Override
    public Genero saveGenero(Genero genero) {
        return this.generoRepo.save(genero);
    }

    @Override
    public Genero updateGenero(Genero genero) {
        return this.generoRepo.save(genero);
    }

    @Override
    public Genero getGeneroById(Integer id) {
        return this.generoRepo.findById(id).get();
    }

    @Override
    public void deleteGeneroById(Integer id) {
        this.generoRepo.deleteById(id);
    }
    
}