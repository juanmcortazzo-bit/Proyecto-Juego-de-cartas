using System;
class Program{
static void Main()
{
    //Jugadores (n,hp)
Personaje jugador = new Personaje("Peter", 100);

    //Cartas (n,hp,def,atk)
Carta carta1 = new Carta("Carta1", 10, 10, 10);
Carta carta2 = new Carta("Carta2", 20, 20, 20);

    //Consola
Console.WriteLine("Jugador " + jugador.nombre + "\nHP: " + jugador.vida);
Console.WriteLine(jugador.nombre);









}
}