Producto Patatas = new Entrante("Patatas bravas", 10.0, 4, false);
Producto Nachos = new Entrante("Nachos", 7.0, 2, false);
Producto EnsaladillaRusa = new Entrante("Ensaladilla Rusa", 6.0, 1, true);

Patatas.ObtenerDescripcion();
Nachos.ObtenerDescripcion();
EnsaladillaRusa.ObtenerDescripcion();

Producto Calamares = new Entrante("Calamares a la romana", 15.0, 3, false);
Producto Gazpacho = new Entrante("Gazpacho", 5.0, 2, true);
Producto Macarrones = new PlatoPrincipal("Macarrones carbonara", 12.0, 15, false);
Producto Ensalada = new PlatoPrincipal("Ensalada", 8.0, 5, true);
Producto Nestea = new Bebida("Nestea", 2.5, "0.33L", false);
Producto Cerveza = new Bebida("Cerveza", 3.0, "0.5L", true);
Producto Frambuesa = new Postre("Frambuesa", 4.0, 100, false);
Producto TartaChocolate = new Postre("Tarta de chocolate", 5.0, 200, true);

Console.WriteLine("\n===================== Carta =====================\n");

List<Producto> carta = new List<Producto>();
carta.Add(Calamares);
carta.Add(Gazpacho);
carta.Add(Macarrones);
carta.Add(Ensalada);
carta.Add(Nestea);
carta.Add(Cerveza);
carta.Add(Frambuesa);
carta.Add(TartaChocolate);

foreach (Producto producto in carta)
{
    Console.WriteLine(carta.IndexOf(producto) + 1 + ". " + producto.Nombre + " - " + producto.Precio + "€");
}

Console.WriteLine("\n================= Carta Filtrada ================\n");

int contador = 1;
foreach (Producto producto in carta)
{
    if (producto is Bebida)
    {
        Console.Write(contador + ". "); producto.ObtenerDescripcion();
        contador++;
    }
}

Console.WriteLine("\n ¿Que producto quieres por numero?");
string elegido = Console.ReadLine();
if (int.TryParse(elegido, out int elegidoNum))
{
    if (elegidoNum >= 1 && elegidoNum <= carta.Count)
    {
        Console.WriteLine("Has elegido:");
        Console.WriteLine(carta[elegidoNum - 1].Nombre + " - " + carta[elegidoNum - 1].Precio + "€");
    }
    else
    {
        Console.WriteLine("Ese producto no existe.");
    }
}
else
{
    Console.WriteLine("Debes introducir un número.");
}

Console.WriteLine("\n ¿Que producto quieres por nombre?");
string elegidoNombre = Console.ReadLine();
elegidoNombre = elegidoNombre.ToLower();
Producto productoEncontrado = null;
foreach (Producto producto in carta)
{
    if (producto.Nombre.ToLower() == elegidoNombre)
    {
        productoEncontrado = producto;
    }
}

if (productoEncontrado != null)
{
    Console.WriteLine("Producto encontrado: ");
    Console.WriteLine(productoEncontrado.Nombre + " - " + productoEncontrado.Precio + "€");
}
else
{
    Console.WriteLine("No se ha encontrado el producto.");
}

Console.WriteLine("\n Precio maximo?");
string precioMax = Console.ReadLine();
if (decimal.TryParse(precioMax, out decimal precioMaxNum))
{
    Console.WriteLine("Productos de hasta " + precioMaxNum + "€:");
    int contadorProd = 0;
    foreach(Producto producto in carta)
    {if (decimal.Parse(producto.Precio.ToString()) <= precioMaxNum)
        {
            Console.WriteLine(producto.Nombre + " - " + producto.Precio + "€");
            contadorProd++;
        }
    }if (contadorProd == 0)
    {
        Console.WriteLine("No hay productos con ese precio o inferior.");
    }
}else
{
    Console.WriteLine("Debes introducir un número.");
}
