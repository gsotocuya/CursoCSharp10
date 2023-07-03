namespace _09Eventos;

public class Argumentos : EventArgs
{
    public int Valor { get; set; }
}
public class clsRepositorioEventHandler
{
    #region Event

    public event EventHandler<Argumentos> ReportaAvance;

    #endregion

    #region Metodos

    public void ObtenTodos()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(250);
            ReportaAvance(this, new Argumentos{Valor = i + 1});
        }
    }

    #endregion
}