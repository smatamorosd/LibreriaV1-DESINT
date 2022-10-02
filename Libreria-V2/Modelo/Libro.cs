using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_V2.Modelo
{
    public class Libro
    {
            public string Autor { get; set; }
            public string Titulo { get; set; }
            public string Tema { get; set; }
            public string Paginas { get; set; }
            public string Precio { get; set; }
            public string Formatouno { get; set; }
            public string Formatodos { get; set; }
            public string Formatotres { get; set; }
            public string Estado { get; set; }

            public Libro(string autor, string titulo, string tema, string paginas, string precio, string formatouno, string formatodos, string formatotres, string estado)
            {
                this.Autor = autor;
                this.Titulo = titulo;
                this.Tema = tema;
                this.Paginas = paginas;
                this.Precio = precio;
                this.Formatouno = formatouno;
                this.Formatodos = formatodos;
                this.Formatotres = formatotres;
                this.Estado = estado;
         
            }
            public Libro() { }

        public override string ToString()
        {
            return Titulo.ToUpper();
        }

        public override bool Equals(object? obj)
        {
            return obj is Libro libro &&
                   Autor == libro.Autor &&
                   Titulo == libro.Titulo &&
                   Tema == libro.Tema &&
                   Paginas == libro.Paginas &&
                   Precio == libro.Precio &&
                   Formatouno == libro.Formatouno &&
                   Formatodos == libro.Formatodos &&
                   Formatotres == libro.Formatotres &&
                   Estado == libro.Estado;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Autor);
            hash.Add(Titulo);
            hash.Add(Tema);
            hash.Add(Paginas);
            hash.Add(Precio);
            hash.Add(Formatouno);
            hash.Add(Formatodos);
            hash.Add(Formatotres);
            hash.Add(Estado);
            return hash.ToHashCode();
        }
    }
}
