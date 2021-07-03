using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRecurisva
{
    class Program
    {
        static void Main(string[] args)
        {
  
            CantTotalRegistrados();
            Console.WriteLine("---------");
            PromedioHinchasRacing();
            Console.WriteLine("---------");
            VectorPersonasOrdenados();
            Console.WriteLine("---------");



            Console.ReadKey();
        }

        public static void CantTotalRegistrados()
        {
            var lectura = new System.IO.StreamReader(@"C:\Users\USER\source\repos\ChallengeRecurisva\ChallengeRecurisva\archivo.csv");
            int cont = 0;
            while (!lectura.EndOfStream)
            {
                lectura.ReadLine();
                cont++;
            }
            lectura.Close();
            Console.WriteLine("La cantidad total de personas registradas es: " + cont);
            Console.ReadKey();
        }

        public static void PromedioHinchasRacing()
        {
            var lectura = new System.IO.StreamReader(@"C:\Users\USER\source\repos\ChallengeRecurisva\ChallengeRecurisva\archivo.csv");
            int cont = 0;
            int promedio = 0;
            while (!lectura.EndOfStream)
            {
                Persona per = new Persona(lectura.ReadLine().Split(';'));
                if (per.Equipo_fut == "Racing")
                {
                    cont++;
                    promedio += per.Edad;
                }

            }
            lectura.Close();
            int promediofinal = promedio / cont;

            Console.WriteLine("El promedio de edad entre los hinchas de Racing es:" + promediofinal);
            Console.ReadKey();

        }

        public static void ordenarvector(Persona [] Vec)
        {
            int Min;
            Persona Aux = new Persona();
            for (int i = 0; i < Vec.Length; i++)
            {

                Min = i;
                for (int k = i; k < Vec.Length; k++)
                {
                    if (Vec[Min].Edad > Vec[k].Edad) Min = k;
                }

                Aux = Vec[i];
                Vec[i] = Vec[Min];
                Vec[Min] = Aux;

            }

        }
       public static void VectorPersonasOrdenados()
        {
            var lectura = new System.IO.StreamReader(@"C:\Users\USER\source\repos\ChallengeRecurisva\ChallengeRecurisva\archivo.csv");
            Persona[] listaP = new Persona[100];
            int cont = 0;
            while (!lectura.EndOfStream)
            {
                Persona per = new Persona(lectura.ReadLine().Split(';'));
                if (per.Estado_civil == "Casado" && per.Estudios == "Universitario" && cont<100)
                {
                    listaP[cont] = per;
                    cont++;
                }
                    
            }

            ordenarvector(listaP);


            for (int i = 0; i < listaP.Length; i++)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Nombre: " + listaP[i].Nombre);
                Console.WriteLine("Edad: "+ listaP[i].Edad);
                Console.WriteLine("Equipo: " + listaP[i].Equipo_fut);
            }

            lectura.Close();
        }

        public static void NombresComune()
        {

        }



    }

   
}
