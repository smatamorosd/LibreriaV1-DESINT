# LibreriaV1-DESINT


TODO: comentar los cambios de front

Cambios:

Null al darle a lstLibros

    public int borrarLibro(String nombre)
    {
        int response = 0;
        int loc = posicionLibro(nombre);
        if (libros[loc]!=null) {
            response = 1;
            libros[loc] = libros[reg - 1];
            reg--;
        }
        return response;
    }
    
     public void BorrarLibro(String titulo)
        {
            int posicionLibro = PosicionLibro(titulo);
            if (posicionLibro != -1)
            {
                for (int i = posicionLibro; i < libros.Length - 1; i++)
                {
                    libros[i] = libros[i + 1];
                }
            }
            libros[libros.Length - 1] = null;
        }
