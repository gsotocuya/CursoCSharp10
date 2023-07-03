namespace _09Eventos;

public delegate void AvisaLinea(int valor);
public class clsRepositorioDelegado
{
    #region Eventos

    public event AvisaLinea ReportarAvance;

    #endregion

    #region Metodos

    public void ObtenTodos()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(250);
            ReportarAvance(i + 1);
        }
    }

    #endregion
}