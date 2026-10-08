public class PlatoPrincipal : Producto
{

    public int tiempoPreparacion { get; set; }
    public bool esVegano { get; set; }

    public PlatoPrincipal(string nombre, double precio, int tiempoPreparacion, bool esVegano) : base(nombre, precio)
    {
        this.tiempoPreparacion = tiempoPreparacion;
        this.esVegano = esVegano;
    }

    public override void ObtenerDescripcion()
    {
        if (esVegano)
        {
            Console.WriteLine($"Plato Principal: {Nombre}, Precio: {Precio}€, tiempo de preparación: {tiempoPreparacion}, Vegano");
        }
        else
        {
            Console.WriteLine($"Plato Principal: {Nombre}, Precio: {Precio}€, tiempo de preparación: {tiempoPreparacion}, No Vegano");
        }
    }
}