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

List <Producto> carta = new List<Producto>();
carta.Add(Calamares);
carta.Add(Gazpacho);
carta.Add(Macarrones);
carta.Add(Ensalada);
carta.Add(Nestea);
carta.Add(Cerveza);
carta.Add(Frambuesa);
carta.Add(TartaChocolate);