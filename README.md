# LibreriaV1-DESINT


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

-------------------------------------------------------------------------------------------------------------------------------------------

Se han refactorizado varias partes del código, entre ellas algunas de las variables y bucles.

Se han creado algunas constantes, de libro introducido, arr lleno, etcétera



Se arreglaron errores en la interfaz de la lista de libros, que al darle en blanco, daría un null Exception

Se arregló una excepción al darle a modificar cuando no hay ningún libro seleccionado.
Se arregló una excepción al añadir un libro con los campos vacíos.

Se quitó un label sobrante de mensajes, y se utiliza ahora el input.

Se añadió que sea obligatorio elegir el formato.

Se añadió que al vaciar la pantalla vacíe el select de temas



