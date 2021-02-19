using System;
using System.Collections.Generic;

namespace CSHARP_Listes_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //création du tableau week en déclarant les jours
            string[] week = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };

            //appel des contenus des indices 1 et 4
            Console.WriteLine("Le contenu de l'indice 1 est " + week[1]);
            Console.WriteLine("Le contenu de l'indice 4 est " + week[4]);

            //appel des contenus du 1er et du 4e emplacement
            Console.WriteLine("\nLe premier élément du tableau est " + week[0]);
            Console.WriteLine("Le quatrième élément du tableau est " + week[3]);

            //modification du contenu à l'index 3, c'est à dire le 4ème jour
            week[3] = "Jeudi";

            //jour du 7e jour: Dimanche
            Array.Resize<string>(ref week, week.Length + 1);
            week[week.Length - 1] = "Dimanche";

            //utilisation d'une boucle pour lister les jours de la semaine contenus de le tableau
            Console.WriteLine("\nLes jours de la semaine sont:");
            foreach(string day in week)
            Console.WriteLine(day);
        }
    }
}
