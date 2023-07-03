namespace _06libPedidos;

public class clsProductos
{
    #region Propiedades
    public int idProducto { get; set; }
    public string Descripcion { get; set; }
    public string CodigoBarras { get; set; }
    #endregion

    #region Constructor
    #endregion

    #region Metodos

    public override string ToString()
    {
        return $"idProducto: {idProducto.ToString()} " +
               $"Descripcion: {Descripcion} " +
               $"Codigo Barras:{CodigoBarras}";
    }

    #endregion 
}