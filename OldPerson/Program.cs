using System;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;

            //1
            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome:");
            name = Console.ReadLine();
            System.Console.Write("Idade:");
            age = Convert.ToInt32(Console.ReadLine());
            Person firstPerson = new Person(name, age);

            //2
            System.Console.WriteLine("Dados da segunda pessoa:");
            System.Console.Write("Nome:");
            name = Console.ReadLine();
            System.Console.Write("Idade:");
            age = Convert.ToInt32(Console.ReadLine());

            Person secondPerson = new Person(name, age);

            name = OldestPerson(firstPerson, secondPerson);

            Console.WriteLine("Pessoa mais velha:" + name);
        }

        private static string OldestPerson(Person p1, Person p2){
            int agePerson1 = p1.Age;
            int agePerson2 = p2.Age;

            string oldPersonName = "";

            if (agePerson1 > agePerson2){
                oldPersonName = p1.Name;
            }else{
                oldPersonName = p2.Name;
            }

            return oldPersonName; 
        }
    }
}