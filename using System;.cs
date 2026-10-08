using System;

// --- Interfaces ---
public interface ICurable { void Curar(); }
public interface IDefendible { void Defender(); }

// --- Clase Base ---
public abstract class Personaje
{
    private int vida;
    private int nivel;

    public string Nombre { get; set; }
    
    public int Vida
    {
        get => vida;
        protected set => vida = Math.Clamp(value, 0, 100); // 0 a 100
    }

    public int Nivel
    {
        get => nivel;
        protected set => nivel = value < 1 ? 1 : value;
    }

    protected Personaje(string nombre, int vida, int nivel)
    {
        Nombre = nombre;
        Vida = vida;
        Nivel = nivel;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Nombre: {Nombre} | Vida: {Vida} | Nivel: {Nivel}");
    }

    public abstract void Atacar();

    public void RecibirDanio(int cantidad)
    {
        Vida -= cantidad;
        Console.WriteLine($"{Nombre} recibe {cantidad} puntos de daño. Vida restante: {Vida}");
        if (Vida <= 0) Console.WriteLine($"{Nombre} ha sido derrotado.");
    }
}

// --- Clases Derivadas ---
public class Guerrero : Personaje, IDefendible
{
    public int Fuerza { get; set; }
    public Guerrero(string n, int v, int niv, int f) : base(n, v, niv) => Fuerza = f;

    public override void Atacar() => Console.WriteLine($"{Nombre} ataca con su espada causando {Fuerza} puntos de daño.");
    public void Defender() => Console.WriteLine($"{Nombre} levanta su escudo y se prepara para defenderse.");
}

public class Mago : Personaje, ICurable
{
    public int Mana { get; set; }
    public Mago(string n, int v, int niv, int m) : base(n, v, niv) => Mana = m;

    public override void Atacar() => Console.WriteLine($"{Nombre} lanza un hechizo causando {Mana} puntos de daño.");
    public void Curar()
    {
        Vida += 20;
        Console.WriteLine($"{Nombre} utiliza magia de curación. Vida recuperada: 20. Vida actual: {Vida}");
    }
}

public class Arquero : Personaje
{
    public int Flechas { get; set; }
    public Arquero(string n, int v, int niv, int f) : base(n, v, niv) => Flechas = f;

    public override void Atacar()
    {
        if (Flechas > 0)
        {
            Flechas--;
            Console.WriteLine($"{Nombre} dispara una flecha causando 25 puntos de daño. Flechas restantes: {Flechas}");
        }
        else Console.WriteLine($"{Nombre} no tiene flechas.");
    }
}

// --- Programa Principal ---
public class Program
{
    public static void Main()
    {
        Personaje[] personajes = {
            new Guerrero("Kratos", 100, 5, 30),
            new Mago("Merlín", 80, 6, 40),
            new Arquero("Legolas", 90, 4, 10)
        };

        Console.WriteLine("===== PERSONAJES =====");
        foreach (var p in personajes)
        {
            p.MostrarEstado();
            p.Atacar();
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("\n===== HABILIDADES =====");
        ((Guerrero)personajes[0]).Defender();
        ((Mago)personajes[1]).RecibirDanio(30);
        ((Mago)personajes[1]).Curar();
        ((Arquero)personajes[2]).Atacar();
    }
}