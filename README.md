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
jj
