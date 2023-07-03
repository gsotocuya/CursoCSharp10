string nombre = "Marcos Hernandez";
Console.WriteLine(nombre == "MARCOS HERNANDEZ");//Console.WriteLine(nombre != "MARCOS HERNANDEZ");//Console.WriteLine(nombre != "Marcos Hernandez"); //Console.WriteLine(nombre == "Marcos Hernandez");
Console.WriteLine(nombre.Equals("MARCOS HERNANDEZ", StringComparison.OrdinalIgnoreCase));
if(nombre == "MARCOS HERNANDEZ") 
    Console.WriteLine("El nombre:" + nombre + " es igual a MARCOS HERNANDEZ");
else
    Console.WriteLine("El nombre:" + nombre + " no es igual a MARCOS HERNANDEZ");
if(nombre.Equals("MARCOS HERNANDEZ", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("El nombre:" + nombre + " es igual a MARCOS HERNANDEZ");
else
    Console.WriteLine("El nombre:" + nombre + " no es igual a MARCOS HERNANDEZ");
DateTime fecha = DateTime.Now;
Console.WriteLine(fecha.ToShortDateString());
Console.WriteLine(fecha.ToLongDateString());
Console.WriteLine(fecha.ToString("yyyy-MM-dd HH:mm:ss"));