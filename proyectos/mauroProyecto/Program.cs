using System;
class Program{
static void Main()
{
    //Jugadores (n,hp)
Personaje jugador1 = new Personaje("Peter", 100);
Personaje jugador2 = new Personaje("Julian", 100);

    //Cartas (n,hp,def,atk)
Carta c1 = new Carta("Espadachín","Guerrero", 80, 30, 70);
Carta c2 = new Carta("Mago","Magica", 55, 10, 100);

jugador1.baraja.Add(c1);
jugador2.baraja.Add(c2);

    // Mostrar jugador 1
    //    Console.WriteLine("=== JUGADOR 1 ===");

    //   Console.WriteLine("Nombre: " + jugador1.nombre);

    //    Console.WriteLine("Vida: " + jugador1.vida);

    //    Console.WriteLine("\nCartas:");

    //    foreach(Carta carta in jugador1.baraja)
    //  {
    //        Console.WriteLine(carta.nombre);
    //    }

     // Mostrar jugador 2
    //    Console.WriteLine("\n=== JUGADOR 2 ===");

    //    Console.WriteLine("Nombre: " + jugador2.nombre);

    //    Console.WriteLine("Vida: " + jugador2.vida);

    //    Console.WriteLine("\nCartas:");

    //    foreach(Carta carta in jugador2.baraja)
    //    {
    //        Console.WriteLine(carta.nombre);
    //    }
    
    //    jugador1.baraja[0].Atacar(jugador2.baraja[0]);
int turno = 0;
Boolean fin = false;
String ganador = "";
    while(fin == false){
        Console.WriteLine("En el turno " + turno);
        turno++;
        
        //turno de j1

        jugador1.baraja[0].Atacar(jugador2.baraja[0],jugador2);

        if (jugador2.vida <= 0)
            {
                ganador = jugador1.nombre;
                fin = true;
            }        
        
                
        //turno de j2

        jugador2.baraja[0].Atacar(jugador1.baraja[0],jugador1);

        if (jugador1.vida <= 0)
            {
                ganador = jugador2.nombre;
                fin = true;
            }        
        
                
        
        }
        //Falta agregar el ganador
        Console.WriteLine("Finaliza la partida con el ganador siendo " + ganador);
}
    }  