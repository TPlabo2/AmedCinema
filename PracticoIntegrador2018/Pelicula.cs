using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoIntegrador2018
{
    class Pelicula
    {
        private int id;
        private string nombre;
        private DateTime duracion;
        private int genero, idioma, clasificacion, subtitulos, director;

        public Pelicula(int id, string nombre, DateTime duracion, int genero, int idioma, int clasificacion, int subtitulos, int director)
        {
            this.id = id;
            this.nombre = nombre;
            this.duracion = duracion;
            this.genero = genero;
            this.idioma = idioma;
            this.clasificacion = clasificacion;
            this.subtitulos = subtitulos;
            this.director = director;
        }

        public Pelicula()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Duracion { get => duracion; set => duracion = value; }
        public int Genero { get => genero; set => genero = value; }
        public int Idioma { get => idioma; set => idioma = value; }
        public int Clasificacion { get => clasificacion; set => clasificacion = value; }
        public int Subtitulos { get => subtitulos; set => subtitulos = value; }
        public int Director { get => director; set => director = value; }
        public int Id { get => id; set => id = value; }

        public string toString()
        {
            return "Nombre: " + this.nombre;
        }
    }
}
