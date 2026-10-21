public class Postre : Producto
{

    public int calorias { get; set; }
    public bool dulce { get; set; }

    public Postre(string nombre, double precio, int calorias, bool dulce) : base(nombre, precio)
    {
        this.calorias = calorias;
        this.dulce = dulce;
    }
    public override void ObtenerDescripcion()
    {
        if (dulce)
        {
            Console.WriteLine($"Postre: {Nombre}, Precio: {Precio}€, Calorías: {calorias}, Dulce");
        }
        else
        {
            Console.WriteLine($"Postre: {Nombre}, Precio: {Precio}€, Calorías: {calorias}, No Dulce");
        }
    }
}