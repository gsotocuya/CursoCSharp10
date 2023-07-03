using _06libPedidos;

clsClientes cliente;
cliente = new clsClientes();
cliente.idCliente = 1;
cliente.NombreCompleto = "Marcos Hernandez";
cliente.Rfc = "HEH010165";
Console.WriteLine(cliente.ToString());