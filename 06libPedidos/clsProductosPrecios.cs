namespace _06libPedidos;

public class clsProductosPrecios : clsProductos
{
    #region Propiedades

    public decimal PrecioPublico { get; set; }
    public decimal PrecioMayoreo { get; set; }
    public decimal PorcentajeIva { get; set; }
    public decimal PorcentajeIeps { get; set; }

    #endregion

    #region Metodos

    public override string ToString()
    {
        return base.ToString() + 
               $"Precio públic: {PrecioPublico.ToString("C")} "+
               $"Precio mayoreo: {PrecioMayoreo.ToString("C")} " +
               $"Porcentaje Iva: {PorcentajeIva.ToString()} " +
               $"Porcentaje Ieps: {PorcentajeIeps.ToString()}"; 
    }

    public decimal DesglosaImpuestos(out decimal MontoIva, out decimal MontoIeps)
    {
        decimal resultado = 0;
        CalculoPrecios.DesglosaImpuesto(PrecioPublico, PorcentajeIva, PorcentajeIeps,
            out MontoIva, out MontoIeps);
        return resultado;
    }
    #endregion
}