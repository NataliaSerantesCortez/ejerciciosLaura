/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package productorconsumidor;

/**
 *
 * @author natal
 */
public class HebraConsumidora implements Runnable {
    public Thread thr;
    private BufferCircular buffer;    
    private boolean termina;

    public HebraConsumidora ( String nombre, boolean termina, BufferCircular buffer ){
        this.thr = new Thread( this, nombre );
        this.buffer = buffer;
        this.termina = termina;
    }
    
    @Override
    public void run() {
        do {
            buffer.consumirEnBuffer(thr.getName());
        } while ( !termina ); 
    }
    
}
