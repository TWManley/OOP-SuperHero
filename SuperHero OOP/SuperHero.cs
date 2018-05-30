using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_OOP
{
    class SuperHero
    {

        
        private int speed;
        private int weight;
        private string name;
        private int health;
        private int power;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
         public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public SuperHero()
        {
            //Default Constructor
        }

        public SuperHero(string name,int power,int health)
        {
            this.name = name;
            this.power = power;
            this.health = health;
        }
        public SuperHero(string name="jon",int power=10,int health=100,int speed=10,int weight=200)
        {
            this.name = name;
            this.power = power;
            this.health = health;
            this.weight = weight;
            this.speed = speed;
        }
        public void Training()
        {
            this.power = this.power + 1;
            Console.WriteLine("{0} power level has increased to {1}",this.name,this.power);
        }
        public void Meal()
        {
            this.health = this.health + 25;
            Console.WriteLine("{0} has eaten a very delicious meal and has increased by 25 and is now {1}", this.name, this.health);
        }


    }
    
}
