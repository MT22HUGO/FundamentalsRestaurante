public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public virtual void ObtenerDescripcion()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}€");
    }
}