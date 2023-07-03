namespace _06libPedidos;

public static class FuncionesPrincipales
{
    #region Metodos

    public static void EjemploCliente()
    {
        
clsClientes cliente;
cliente = new clsClientes();
cliente.idCliente = 1;
cliente.NombreCompleto = "Marcos Hernandez";
cliente.Rfc = "HEH010165";
Console.WriteLine(cliente.ToString()); 
    }

    public static void EjemploRecordProducto()
    {
        clsProductos Producto = new clsProductos();
        Producto.idProducto = 1;
        Producto.Descripcion = "REF MANZANA 600 ML";
        Producto.CodigoBarras = "0001";
        clsProductos Producto2 = new clsProductos();
        Producto2 = Producto;
        Producto2.CodigoBarras = "0";

        recProductos rProducto = new recProductos(1, "REF MANZANA 600 ML", "0001");
        recProductos rProducto2 = rProducto with {CodigoBarras = "0"};
        Console.WriteLine("Producto: " + Producto);
        Console.WriteLine("Producto2: " + Producto2);
        Console.WriteLine("rProducto: " + rProducto);
        Console.WriteLine("rProducto2: " + rProducto2);

        if(Producto == Producto2)
            Console.WriteLine("Los objetos son iguales");
        else
            Console.WriteLine("Los objetos son diferentes");
        if(rProducto == rProducto2)
            Console.WriteLine("Los registros son iguales");
        else
            Console.WriteLine("Los registros son diferentes");

    }

    public static void EjemploDesglosaImpuestos()
    {
        clsProductosPrecios Producto = new clsProductosPrecios();
        Producto.idProducto = 1;
        Producto.Descripcion = "REF MANZANA 600 ML";
        Producto.CodigoBarras = "0001";
        Producto.PrecioPublico = 17.5m;
        Producto.PrecioMayoreo = 17;
        Producto.PorcentajeIva = 16;
        Producto.PorcentajeIeps = 8;
        decimal precioSinImpuestos, MontoIva, MontoIeps;
        Console.WriteLine(Producto);
        recMontosImpuestos Montos = new recMontosImpuestos(0,0);
        precioSinImpuestos = Producto.DesglosaImpuestos(Montos);
        Console.WriteLine(precioSinImpuestos.ToString("C"));
        Console.WriteLine(Montos.ToString());
        ;
    }
    #endregion
}