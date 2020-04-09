using System;

namespace Lesson_10
{
    class Animal // базовый класс
    {
        public string name {get; set;}
        public string animal { get; set;}
        public int age { get; set;}
        public void Info()
        {
            Console.WriteLine($"{animal} : {name}, возраст: {age}");
        }
        public Animal(string animal, string name, int age)
        {
            this.animal = animal;
            this.name = name;
            this.age = age;
        }
        public Animal(){}
    }
    class Zoo: Animal //производный класс
    {
       char sector { get; set; }
       public Zoo(char sector, string animal, string name, int age)
       :base(animal, name, age)
       {
           this.sector = sector;
       }
       public Zoo(){}
       public void GetSector()
       {
           Console.WriteLine($"Sector: {sector}");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zoo zo = new Zoo('A',              
            "Крокодил",              
            "Гоша",              
            34);             
            zo.Info();             
            zo.GetSector(); 

        }
    }
}
