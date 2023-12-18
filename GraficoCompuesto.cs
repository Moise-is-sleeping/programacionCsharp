namespace ConsoleApp1;

public class GraficoCompuesto:IGrafico
{
    private List<IGrafico> ListaGraficos = new List<IGrafico>();




    public void Insert(Punto shape)
    {
        ListaGraficos.Add(shape);
    }

    public bool Mover(int x, int y)
    {
        bool check = true;
        foreach (var dibujo in ListaGraficos)
        {
            if (!dibujo.Mover(x, y))
            {
                check = false;
            }
        }
        return check;
    }

    public string Dibujar()
    {
        string text = null;
        foreach (var item in ListaGraficos)
        {
            text += item.Dibujar() +"\n";
        }

        return text;
    }
}