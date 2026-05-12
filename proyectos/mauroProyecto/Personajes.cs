using System.Collections.Generic;

class Personaje
{
    public string nombre;
    public int vida;

    public List<Carta> baraja;

    public Personaje(string n, int hp)
    {
        this.nombre = n;
        this.vida = hp;

        baraja = new List<Carta>();
    }
}