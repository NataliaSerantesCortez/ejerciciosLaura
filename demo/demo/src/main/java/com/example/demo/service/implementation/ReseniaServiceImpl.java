package com.example.demo.service.implementation;

import java.util.List;

import org.springframework.stereotype.Service;

import com.example.demo.entity.Resenia;
import com.example.demo.entity.PKCompuestaResenia;
import com.example.demo.repository.ReseniaRepository;
import com.example.demo.service.ReseniaService;

@Service
public class ReseniaServiceImpl implements ReseniaService {
    private ReseniaRepository reseniaRepo;
    
    public ReseniaServiceImpl(ReseniaRepository rr){
        super();
        this.reseniaRepo = rr;
    }

    @Override
    public List<Resenia> getAllResenias() {
        return this.reseniaRepo.findAll();
    }

    @Override
    public Resenia saveResenia(Resenia resenia) {
        return this.reseniaRepo.save(resenia);
    }

    @Override
    public Resenia updateResenia( Resenia resenia) {
        return this.reseniaRepo.save(resenia);
    }

    @Override
    public Resenia getReseniaById(PKCompuestaResenia pK) {
        return this.reseniaRepo.findById(pK).get();
    }

    @Override
    public void deleteReseniaById(PKCompuestaResenia pK) {
        this.reseniaRepo.deleteById(pK);
    }
}
