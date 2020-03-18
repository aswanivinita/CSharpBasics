using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64InterfaceInheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IExtraCurriculActivities eca = new Student();
            eca.Dance();
            eca.Karate();
            eca.Sing();

            IDance dance = new Student();
            dance.Dance();

            IKarate karate = new Student();
            karate.Karate();

            ISing sing = new Student();
            sing.Sing();


        }
    }
    
    interface IDance
    {
        void Dance();

    }

    interface IKarate
    {
        void Karate();
    }

    interface ISing
    {
        void Sing();
    }

    interface IExtraCurriculActivities: IKarate, ISing, IDance
    {
        
    }

    class Student : IExtraCurriculActivities
    {
        public void Dance()
        {
            Console.WriteLine("Dance Class");
        }

        public void Karate()
        {
            Console.WriteLine("Karate Class");
        }

        public void Sing()
        {
            Console.WriteLine("Singing Class");
        }
    }
}
