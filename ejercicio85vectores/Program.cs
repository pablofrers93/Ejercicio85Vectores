// 85.Ingrese en un vector de 10 posiciones la velocidad expresadas en km/h que alcanzaron
//los autos en una carrera que tienen que estar entre 100 y 300 kms. Al finalizar el ingreso
//de los mismos hacer lo siguiente:
//• Mostrar un listado de los valores alcanzados con su equivalente en millas/h.
// • Informar además la mayor y menor velocidades, así como también la velocidad
//media.
//• Marque con un asterisco aquellas velocidades superiores al promedio de velocidad
//• Informe la cantidad de velocidades inferiores al promedio.
using System;

namespace ejercicio85vectores
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] velocidades = new int[10];
            int i = 0;
            int velocidad = 0;
            double promedioVelocidades = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese las velocidades entre 100 y 300 km/h y presione enter");
                velocidad = Convert.ToInt32(Console.ReadLine());


                if (velocidad > 99 & velocidad < 301)
                    velocidades[i] = velocidad;
                else
                {
                    do
                    {
                        Console.WriteLine("la velocidad tiene que ser entre 100 y 300");
                        Console.WriteLine("Ingrese las velocidades entre 100 y 300 km/h y presione enter");
                        velocidad = Convert.ToInt32(Console.ReadLine());

                    }
                    while (velocidad < 99 | velocidad > 301);


                    velocidades[i] = velocidad;

                }


            }

            InformarVelocidadesEnKilometros(velocidades,i);
            InformarVelocidadesEnMillas(velocidades, i);
            InformarMayorYMenorVelocidades(velocidades, i);

            promedioVelocidades = obtenerPromedioVelocidades(velocidades, i);
            Console.WriteLine($"La velocidad promedio es de {promedioVelocidades}");

            InformarVelocidadesInferioresPromedio(velocidades, i, promedioVelocidades);
            
        }

        

        private static double obtenerPromedioVelocidades(int[] velocidades, int i)
        {
            int suma = 0;
            double promedio = 0;

            for (i=1; i<10; i++)
            {   
                suma += velocidades[i];
            }

            promedio = suma / velocidades.Length;
            return promedio;
        }

        private static void InformarVelocidadesInferioresPromedio(int[] velocidades, int i, double promedio)
        {
            Console.WriteLine("Velocidades inferiores al promedio: ");
            for (i = 1; i < 10; i++)
            {
                if (velocidades[i] < promedio)
                    Console.Write(velocidades[i] + " - ");
            }
        }

        private static void InformarMayorYMenorVelocidades(int[] velocidades, int i)
        {
            int menor = 500;
            int mayor = 0;

            for (i=1; i<10; i++)
            {
                if (velocidades[i] < menor)
                    menor = velocidades[i];

                if (velocidades[i] > mayor)
                    mayor = velocidades[i];
            }

            Console.WriteLine("La menor velocidad fue de {0} KM/H", menor);
            Console.WriteLine("La mayor velocidad fue de {0} KM/H", mayor);
        }

        private static void InformarVelocidadesEnMillas(int[] velocidades, int i)
        {
            Console.WriteLine("Valores expresados en millas");
            for (i = 1; i < 10; i++)
            {
                Console.Write(velocidades[i] * 0.62 + " - ");
            }
        }

        private static void InformarVelocidadesEnKilometros(int[] velocidades, int i)
        {
            Console.WriteLine("Valores expresados en kilometros:");
            for (i = 1; i < 10; i++)
            {
                Console.Write(velocidades[i] + " - ");
            }
        }
    }
}
