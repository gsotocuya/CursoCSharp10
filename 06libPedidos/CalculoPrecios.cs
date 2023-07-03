namespace _06libPedidos;

internal static class CalculoPrecios
{
    #region Metodos

    internal static decimal DesglosaImpuesto(decimal precio, decimal porcentajeIva, decimal porcentajeIeps,
        out decimal montoIva, out decimal montoIeps)
    {
        decimal resultado = 0;
        resultado = precio / (1 + porcentajeIva / 100m);
        montoIva = Math.Round(resultado * (porcentajeIva / 100m), 2);
        resultado = resultado / (1 + porcentajeIeps / 100m);
        montoIeps = Math.Round(resultado * (porcentajeIeps / 100m), 2);
        return Math.Round(resultado,2);
    }

    #endregion
}