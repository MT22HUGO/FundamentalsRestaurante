public class Bebida : Producto
{

    public string tamaño { get; set; }
    public bool alcoholica { get; set; }

    public Bebida(string nombre, double precio, string tamaño, bool alcoholica) : base(nombre, precio)
    {
        this.tamaño = tamaño;
        this.alcoholica = alcoholica;
    }

    public override void ObtenerDescripcion()
    {
        if (alcoholica)
        {
            Console.WriteLine($"Bebida: {Nombre}, Precio: {Precio}€, Tamaño: {tamaño}, Alcohólica");
        }
        else
        {
            Console.WriteLine($"Bebida: {Nombre}, Precio: {Precio}€, Tamaño: {tamaño}, No Alcohólica");
        }
    }
}