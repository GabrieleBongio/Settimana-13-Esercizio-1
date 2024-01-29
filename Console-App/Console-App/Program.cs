using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta();
            atleta1.Name = "Jannik Sinner";
            atleta1.Sport = "Tennis";
            atleta1.Nationality = "Italy";

            Atleta atleta2 = new Atleta();
            atleta2.Name = "Rafael Leao";
            atleta2.Sport = "Football";
            atleta2.Nationality = "Portugal";

            Console.WriteLine(atleta1.Introduce());
            Console.WriteLine(atleta2.Introduce());

            atleta1.Name = "Matteo Berrettini";

            Console.WriteLine(atleta1.Introduce());

            Console.WriteLine("\n");

            Dipendente dipendente1 = new Dipendente();
            dipendente1.Name = "Giorgio";
            dipendente1.Work = "Chef";
            dipendente1.Salary = 12000;

            Dipendente dipendente2 = new Dipendente();
            dipendente2.Name = "Luigi";
            dipendente2.Work = "Fisherman";
            dipendente2.Salary = 10000;

            Console.WriteLine(dipendente1.Introduce());
            Console.WriteLine(dipendente2.Introduce());

            Console.WriteLine("\n");

            Animale animale1 = new Animale();
            animale1.Name = "Bigia";
            animale1.Species = "Cat";
            animale1.Color = "Black";

            Animale animale2 = new Animale();
            animale2.Name = "Filomena";
            animale2.Species = "Sheep";
            animale2.Color = "White";

            Console.WriteLine(animale1.Name + " is a " + animale1.Color + " " + animale1.Species + " and she says " + animale1.Talk());
            Console.WriteLine(animale2.Name + " is a " + animale2.Color + " " + animale2.Species + " and she says " + animale2.Talk());

            Console.WriteLine("\n");

            Veicolo veicolo1 = new Veicolo();
            veicolo1.House = "Porche";
            veicolo1.Model = "911 Carrera";
            veicolo1.Autonomy = 350;

            Console.WriteLine("veicolo1: " +  veicolo1.House + " " + veicolo1.Model);
            Console.WriteLine("veicolo1.DriveFor(250)");
            Console.WriteLine(veicolo1.DriveFor(250));
            Console.WriteLine("veicolo1.Start()");
            Console.WriteLine(veicolo1.Start());
            Console.WriteLine("veicolo1.DriveFor(250)");
            Console.WriteLine(veicolo1.DriveFor(250));
            Console.WriteLine("veicolo1.DriveFor(170)");
            Console.WriteLine(veicolo1.DriveFor(170));
            Console.WriteLine("veicolo1.Refill()");
            Console.WriteLine(veicolo1.Refill());
            Console.WriteLine("veicolo1.Stop()");
            Console.WriteLine(veicolo1.Stop());
            Console.WriteLine("veicolo1.Refill()");
            Console.WriteLine(veicolo1.Refill());
            Console.WriteLine("veicolo1.DriveFor(170)");
            Console.WriteLine(veicolo1.DriveFor(170));
            Console.WriteLine("veicolo1.Start()");
            Console.WriteLine(veicolo1.Start());
            Console.WriteLine("veicolo1.DriveFor(170)");
            Console.WriteLine(veicolo1.DriveFor(170));

            Console.ReadLine();
        }
    }
}
