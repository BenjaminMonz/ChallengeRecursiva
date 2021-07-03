using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRecurisva
{
    class Persona
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Equipo_fut { get; set; }
        public String Estado_civil { get; set; }
        public String Estudios { get; set; }

        public Persona(string[] persona)
        {
            
            Nombre = persona[0];
            Edad = int.Parse(persona[1]);
            Equipo_fut = persona[2];
            Estado_civil = persona[3];
            Estudios = persona[4];

        }

        public Persona()
        {
            


        }
    }
}
