using System;
using System.Collections.Generic;

namespace CSHARP_Listes_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };

            Console.WriteLine("Le contenu de l'indice 1 est " + week[1]);
            Console.WriteLine("Le contenu de l'indice 4 est " + week[4]);

            Console.WriteLine("\nLe premier élément du tableau est " + week[0]);
            Console.WriteLine("Le quatrième élément du tableau est " + week[3]);

            week[3] = "Jeudi";

            Console.WriteLine("\nCORRECTION \nLe 4ème jour est " + week[3]);

            Array.Resize(ref week, week.Length + 1);
            week[week.Length - 1] = "Dimanche";

            Console.WriteLine("\nLes jours de la semaine sont:");
            foreach(string day in week)
            Console.WriteLine(day);
        }
    }
}
