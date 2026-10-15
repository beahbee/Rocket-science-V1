using System;

class Program {
  static void Main() 
   { 
     double velocidade= 0;
     double altitude= 0;
     double aceleracao= 20;

Console.WriteLine ("Simulador de lancamento de foguete");
Console.WriteLine ("  ");

     for (int tempo = 0; tempo <= 10; tempo++)
     { 
        velocidade = aceleracao * tempo;
        altitude = 0.5 * aceleracao * tempo * tempo;

        Console.WriteLine( 
            "Tempo: " + tempo + " s" +
            " | Velocidade: " + velocidade + " m/s" +
            " | Altitude: " + altitude + " m"
                                           );
                                       }

Console.WriteLine("  ");
        Console.WriteLine("Simulacao finalizada!");
                                          }
                                     }
