namespace _06libPedidos;

public class ctrObtenProductos
{
    #region Propiedades

    private intRepositorioProductos repoProductos;
    public Dictionary<string, recProductos> Productos { get; set; }

    #endregion

    #region Constructor

    public ctrObtenProductos( intRepositorioProductos prepoProductos)
    {
        repoProductos = prepoProductos;
        Productos = new Dictionary<string, recProductos>();
    }

    #endregion

    #region Metodos

    public void ObtenProductos()
    {
        Productos.Clear();
        Productos = repoProductos.ObtenTodos();
    }

    public bool ObtenProducto(string codigoBarras, out recProductos producto)
    {
        return Productos.TryGetValue(codigoBarras, out producto);
    }
    #endregion
}