public class Entrante : Producto
{

    public int numPersonas { get; set; }
    public bool esFrio { get; set; }

    public Entrante(string nombre, double precio, int numPersonas, bool esFrio) : base(nombre, precio)
    {
        this.numPersonas = numPersonas;
        this.esFrio = esFrio;
    }

    public override void ObtenerDescripcion()
    {
        Console.WriteLine($"Entrante: {Nombre}, Precio: {Precio}€, Personas: {numPersonas}, Frío: {esFrio}");
    }
}