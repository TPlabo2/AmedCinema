using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoIntegrador2018
{
    class Actores
    {
        private int id;
        private string nombre;
        private string apellido;
        private string reseña;
        private int pais;
        private DateTime edad;

        public Actores(int id, string nombre, string apellido,string reseña, int pais, DateTime edad)
        {
            this.Id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.reseña = reseña;
            this.pais = pais;
            this.edad = edad;
        }

        public Actores()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Reseña { get => reseña; set => reseña = value; }
        public int Pais { get => pais; set => pais = value; }
        public DateTime FechaN { get => edad; set => edad = value; }
        public int Id { get => id; set => id = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return "Nombre : " + nombre + " "+ apellido;
        }

    }
}
