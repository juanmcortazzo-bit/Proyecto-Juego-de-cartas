class Carta
{
    public string nombre;
    public string categoria;
    public int vida;
    public int defensa;
    public int ataque;

  public Carta(string n, string cat, int hp, int def, int atk)
    {
        this.nombre = n;
        this.categoria = cat;
        this.vida = hp;
        this.defensa = def;
        this.ataque = atk;
    }

public void Atacar(Carta objetivo, Personaje personaje)
    {
        int daño = this.ataque - objetivo.defensa;

        if(daño < 0)
        {
            
            daño = 0;
            

        }
        

        objetivo.vida -= daño;

        if (objetivo.vida <= 0)
        {
            personaje.vida -= daño;
        }

        Console.WriteLine(this.nombre + " hizo " + daño + " de daño a " + objetivo.nombre);
        Console.WriteLine("Vida restante de " + objetivo.nombre + ": " + objetivo.vida);
        Console.WriteLine("Vida restante de " + personaje.nombre + ": " + personaje.vida);


    }




}