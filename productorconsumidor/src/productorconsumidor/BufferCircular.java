/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package productorconsumidor;

import java.util.concurrent.Semaphore;

/**
 *
 * @author natal
 */
public class BufferCircular {
    private int tamanio;
    private int[] buffer;
    private int posicionProducir;
    private int posicionConsumir;
    
    private Semaphore semMutex;
    private Semaphore semConsumidor;
    private Semaphore semProductor;

    public BufferCircular(int tamanio){
        this.tamanio = tamanio;
        this.buffer = new int[tamanio];
        for ( int i = 0; i < tamanio; i++){
            this.buffer[i] = 0;
        }

        this.posicionProducir = 0;
        this.posicionConsumir = 0;
        
        this.semMutex = new Semaphore(1,true);
        this.semConsumidor = new Semaphore(0,true);
        this.semProductor = new Semaphore(tamanio,true);
    }

    public void producirEnBuffer ( String nombre ){
        try {
            this.semProductor.acquire();
            this.semMutex.acquire();
            
            this.buffer[posicionProducir] = 1;
            System.out.println( nombre + " produce en posición " + this.posicionProducir);
            imprimirBuffer(this.posicionProducir);
            this.posicionProducir = (this.posicionProducir+1)%this.tamanio;
            
            this.semMutex.release();
        } catch ( InterruptedException e ){
            System.out.println(e.getMessage());
        } finally {
            this.semConsumidor.release();
        }        
    }

    public void consumirEnBuffer ( String nombre ){
        try {
            this.semConsumidor.acquire();
            this.semMutex.acquire();
            
            this.buffer[posicionConsumir] = 0;
            System.out.println( nombre + " consume en posición " + this.posicionConsumir);
            imprimirBuffer(this.posicionConsumir);
            this.posicionConsumir = (this.posicionConsumir+1)%this.tamanio;
            
            this.semMutex.release();
        } catch ( InterruptedException e ){
            System.out.println(e.getMessage());
        } finally {
            this.semProductor.release();
        }        
    }

    public void imprimirBuffer ( int posicion ){
        final String RESET = "\u001B[0m";
        final String RED = "\u001B[31m";
        final String GREEN = "\u001B[32m";

        System.out.print("[");
        for ( int i = 0; i < this.tamanio; i++ ){
            if ( posicion == i && this.buffer[i] == 0 ){
                System.out.print(RED + " " + this.buffer[i] + " " + RESET);
            } else if ( posicion == i && this.buffer[i] == 1 ){
                System.out.print(GREEN + " " + this.buffer[i] + " " + RESET);
            } else {
                System.out.print(" " + this.buffer[i] + " ");
            }
        }
        System.out.println("]\n");
    }
}
