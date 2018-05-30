using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero John = new SuperHero("John", 9, 100, 6, 450);
            John.Training();
            while (John.Health != 1000)
            { 
                John.Meal();        
            }
            SuperHero Donatello = new SuperHero("Donatello", 11, 85, 10, 180);
            Donatello.Training();
            Donatello.Training();
            SuperHero Lamo = new SuperHero("Lamo", 3, 50, 5, 120);
            Lamo.Training();
            Lamo.Meal();

        
        }
    }
}
