﻿

using System;

namespace LibreriaV3._1.Modelo
{
    //Marcamos los objetos como serializables (en C# todos los objetos en session state
    //tienen que ser serializables).
    [Serializable]
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
           return Titulo;
       }

    }
}
