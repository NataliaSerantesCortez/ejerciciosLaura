/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package productorconsumidor;

/**
 *
 * @author natal
 */
public class HebraProductora implements Runnable {
    public Thread thr;
    private BufferCircular buffer;    
    private boolean termina;

    public HebraProductora ( String nombre, boolean termina, BufferCircular buffer ){
        this.thr = new Thread( this, nombre );
        this.buffer = buffer;
        this.termina = termina;
    }
    
    @Override
    public void run() {
        do {
            buffer.producirEnBuffer(thr.getName());
        } while ( !termina );  
    }    
}
