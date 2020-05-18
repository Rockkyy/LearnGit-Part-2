using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimals
{
    class Animals
    {
        public static int count = 0;

        public string name;
        public int age;
        public float hapiness;

        public Animals()
        {
            name = "Steave";
            age = 8;
            hapiness = 0.6f;
            count++;
            Print();
        }
        public Animals( string name, int age, float hapiness)
        {
            this.name = name;
            this.age = age;
            this.hapiness = hapiness;
            count++;
            Print();
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapiness: " + hapiness);
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Animals cat = new Animals();
                //cat.name = "Tom";
               // cat.age = 3;
               // cat.hapiness = 0.9f;
               // cat.Print();
                //Animals.count++;
                Animals dog = new Animals("Tom", 5, 1.1f);
                //Animals.count++;
               Console.WriteLine("Counts of animals " +Animals.count);
                Console.ReadKey();
            }
        }
    }
}
    
       
    

