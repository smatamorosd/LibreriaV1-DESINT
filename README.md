# LibreriaV3-DESINT


- Se ha eliminado el toUpper del metodo toString de Libros. (podría causar errores)
- Se añadió un try catch en el metodo cerrarLibro para capturar la excepcion en caso que el fichero data.dat no exita
- Se arreglaron otros errores menores.
- Se ha marcado el objecto libro como serializable para que se pueda serializar y deserializar el objecto
- Se ha modificado el metodo modificarLibro añadiendo un nuevo parametro al metodo para poder buscar el libro antiguo y posteriormente borrarlo

✨Mejora Propuesta:
- Usar los setter para cambiar el nuevo valor de los atributos del libro en lugar de borrar el libro y añadir un nuevo al final de la lista

