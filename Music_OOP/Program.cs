using System;

public class MusicalInstrument
{
    public string Name { get; protected set; }
    public string Characteristics { get; protected set; }

    public MusicalInstrument(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Instrument sound");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public virtual void History()
    {
        Console.WriteLine("History of the musical instrument");
    }
}

public class Violin : MusicalInstrument
{
    public Violin(string characteristics) : base("Violin", characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Violin sound");
    }

    public override void History()
    {
        Console.WriteLine("The violin was created in Italy in the 16th century.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone(string characteristics) : base("Trombone", characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Trombone sound");
    }

    public override void History()
    {
        Console.WriteLine("The trombone appeared in the 15th century.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele(string characteristics) : base("Ukulele", characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele sound");
    }

    public override void History()
    {
        Console.WriteLine("The ukulele originated in Hawaii in the 19th century.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello(string characteristics) : base("Cello", characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Cello sound");
    }

    public override void History()
    {
        Console.WriteLine("The cello originated in Italy in the 16th century.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Violin violin = new Violin("String bowed instrument");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();
        Console.WriteLine();

        Trombone trombone = new Trombone("Brass wind instrument");
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();
        Console.WriteLine();

        Ukulele ukulele = new Ukulele("String plucked instrument");
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();
        Console.WriteLine();

        Cello cello = new Cello("String bowed instrument");
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
        Console.WriteLine();
    }
}
