using System;
using System.Collections.Generic;

public abstract class Animal
{
    protected string Nombre { get; set; }
    protected string Sonido { get; set; }

    public Animal(string nombre, string sonido)
    {
        Nombre = nombre;
        Sonido = sonido;
    }

    public void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} hace \"{Sonido}\"");
    }

    public abstract void Alimentar();
}

public class Leon : Animal
{
    public Leon() : base("León", "Ruge")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Leon Come carne");
    }
}

public class PavoReal : Animal
{
    public PavoReal() : base("Pavo Real", "Canto")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("PavoReal Come semillas");
    }
}

public class Cocodrilo : Animal
{
    public Cocodrilo() : base("Cocodrilo", "Grugido")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Cocodrilo Devora carne y quiebra huesos");
    }
}

public class Panda : Animal
{
    public Panda() : base("Panda", "Sonido de bambú")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Panda Come bambú");
    }
}

public class Mono : Animal
{
    public Mono() : base("Mono", "chillido")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Mono Come frutas");
    }
}

public class Oso : Animal
{
    public Oso() : base("Oso", "Rugid")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Oso Come pescado");
    }
}

public class Lobo : Animal
{
    public Lobo() : base("Lobo", "Aullido")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Lobo Caza y come carne");
    }
}

public class Tigre : Animal
{
    public Tigre() : base("Tigre", "Rugido")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Tigre Come carne fresca");
    }
}

public class Jirafa : Animal
{
    public Jirafa() : base("Jirafa", "Nose como le hace una jirafa :c")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Jirafa Come hojas y brotes de árboles altos");
    }
}

public class Rinoceronte : Animal
{
    public Rinoceronte() : base("Rinoceronte", "Bufido")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Rinoceronte Come hierbas");
    }
}

public class Cebra : Animal
{
    public Cebra() : base("Cebra", "Relincho")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Cebra Come hierbas");
    }
}

public class Tortuga : Animal
{
    public Tortuga() : base("Tortuga", "Mi momento a llegado")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Tortuga Come vegetación");
    }
}

public class Pingüino : Animal
{
    public Pingüino() : base("Pingüino", "¡Sonido de graznido!")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Pinguino Come peces");
    }
}

public class Serpiente : Animal
{
    public Serpiente() : base("Serpiente", "Sssss")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Serpiente Come roedores");
    }
}

public class Elefante : Animal
{
    public Elefante() : base("Elefante", "Silba con su nariz")
    {
    }

    public override void Alimentar()
    {
        Console.WriteLine("Elefante Come hierbas y frutas");
    }
}

public class Zoo
{
    private List<Animal> animales;

    public Zoo()
    {
        animales = new List<Animal>
        {
            new Leon(),
            new PavoReal(),
            new Cocodrilo(),
            new Panda(),
            new Mono(),
            new Oso(),
            new Lobo(),
            new Tigre(),
            new Jirafa(),
            new Rinoceronte(),
            new Cebra(),
            new Tortuga(),
            new Pingüino(),
            new Serpiente(),
            new Elefante()
        };
    }

    public void Interactuar()
    {
        Console.WriteLine("Bienvenido al zoológico virtual. ¿Qué te gustaría hacer?");
        Console.WriteLine("1. Escuchar sonidos de los animales");
        Console.WriteLine("2. Alimentar a los animales");
        Console.WriteLine("3. Salir");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Sonido de los animales:");
                foreach (var animal in animales)
                {
                    animal.EmitirSonido();
                }
                break;
            case "2":
                Console.WriteLine("Alimentando a los animales:");
                foreach (var animal in animales)
                {
                    animal.Alimentar();
                }
                break;
            case "3":
                Console.WriteLine("Gracias por visitar mi zoológico virtual");
                return;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        Interactuar();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zoo miZoo = new Zoo();
        miZoo.Interactuar();
    }
}
