/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package productorconsumidor;

/**
 *
 * @author natal
 */
public class Principal {
    public static void main(String[] args) {
         try{
            if (args.length > 0) {
                System.out.println("Argumentos recibidos:");
                for (String arg : args) {
                    System.out.println(arg);
                }
            } else {
                System.out.println("No se recibieron argumentos.");
            }
            if ( args.length != 5 ){ 
                System.out.println( "La cantidad de argumentos es incorrecta" );
                System.exit( 1 );
            }
            int tamanioBuffer = Integer.parseInt( args[0] );
            int numHebrasProd = Integer.parseInt( args[1] );
            boolean terminanProd = Boolean.parseBoolean( args[2] );
            int numHebrasCons = Integer.parseInt( args[3] );
            boolean terminanCons = Boolean.parseBoolean( args[4] );
            
            System.out.println("tamaño= " + tamanioBuffer + "; num Hebras Prod= " + numHebrasProd + "; num Hebras Cons= " 
                    + numHebrasCons + "; terminan Prod= " + terminanProd + " ; terminan Cons= " + terminanCons);

            BufferCircular buffer = new BufferCircular(tamanioBuffer);

            HebraProductora[] hebrasProd = new HebraProductora[numHebrasProd];
            HebraConsumidora[] hebrasCons = new HebraConsumidora[numHebrasCons];
            //creación de las hebras
            for ( int i = 0; i < numHebrasProd; i++ ){
                String nombreProd = "HebraProductora(" + i + ")";
                hebrasProd[i] = new HebraProductora(nombreProd,terminanProd,buffer);
            }
            for ( int i = 0; i < numHebrasCons; i++ ){
                String nombreCons = "HebraConsumidora(" + i + ")";
                hebrasCons[i] = new HebraConsumidora(nombreCons,terminanCons,buffer);
            }

            //lanzo las hebras
            if ( numHebrasProd < numHebrasCons ){
                for ( int i = 0; i < numHebrasProd; i++ ){                    
                    hebrasProd[i].thr.start();                    
                    hebrasCons[i].thr.start();
                }
                for ( int i = numHebrasProd; i < numHebrasCons; i++ ){
                    hebrasCons[i].thr.start();
                }
            } else if ( numHebrasProd == numHebrasCons ){
                for ( int i = 0; i < numHebrasProd; i++ ){
                    hebrasProd[i].thr.start();
                    hebrasCons[i].thr.start();
                }
            } else {
                for ( int i = 0; i < numHebrasCons; i++ ){
                    hebrasProd[i].thr.start();
                    hebrasCons[i].thr.start();
                }
                for ( int i = numHebrasCons; i < numHebrasProd; i++ ){
                    hebrasProd[i].thr.start();
                }
            }

            //el main espera que terminen las hebras
            for ( int i = 0; i < numHebrasProd; i++ ){
                hebrasProd[i].thr.join();
            }
            for ( int i = 0; i < numHebrasCons; i++ ){
                hebrasCons[i].thr.join();
            }

        } catch ( InterruptedException e ){
            System.out.println( e.getMessage() );
        }
    }
}
