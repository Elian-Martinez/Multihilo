using System;
using System.Threading;

namespace EjemploHilos
{
    class Program
    {
        public static void Corredor1Vuelta()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Carredor 1 da vuelta # "+i);
                Thread.Sleep(200);
            }
            
        }
        public static void Corredor2Vuelta()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Carredor 2 da vuelta # "+i);
                Thread.Sleep(200);
            }

        }
        public static void Corredor3Vuelta()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Carredor 3 da vuelta # " + i);
                Thread.Sleep(200);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Integrantes: \nElian A. Martinez Cuevas \n 2019 - 7817 \nLuis Manuel Rincón Tejeda\n 2018 - 6061  \n\nDemostración: \n");
            Thread Corredor1 = new Thread(new ThreadStart(Corredor1Vuelta));
            Thread Corredor2 = new Thread(new ThreadStart(Corredor2Vuelta));
            Thread Corredor3 = new Thread(new ThreadStart(Corredor3Vuelta));

            Corredor1.Start();
            Corredor2.Start();
            Corredor3.Start();
            Console.ReadLine();

            
        }
    }
}
