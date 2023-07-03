namespace _06libPedidos;

public class clsClientes : clsPersonas
{
    #region Propiedades

    public string Rfc { get; set; }
    public int idCliente
    {
        get { return IdPersona; }
        set { IdPersona = value; }
    }
    #endregion

    #region Constructor

    #endregion

    #region Metodos

    public override string ToString()
    {
        string cadena = $"idCliente = {idCliente.ToString()} NombreCompleto = {NombreCompleto} Rfc = {Rfc} ";
        return cadena;
    }

    #endregion
}