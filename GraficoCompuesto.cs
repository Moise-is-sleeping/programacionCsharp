namespace ConsoleApp1;

public class GraficoCompuesto:IGrafico
{
    private List<Punto> ListaGraficos = new List<Punto>();
    

    public void Agregar(int number)
    {
        switch (number)
        {
            case 1:
            {
                Console.WriteLine("x?");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                int y = Convert.ToInt32(Console.ReadLine());
                ListaGraficos.Add(new Punto(x,y));
                break;
            }
            case 2:
            {
                Console.WriteLine("x?");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Radio?");
                int radio = Convert.ToInt32(Console.ReadLine());
                ListaGraficos.Add(new Circulo(x,y,radio));
                break;
            }
            case 3:
            {
                Console.WriteLine("x?");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ancho?");
                int ancho = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Alto?");
                int alto = Convert.ToInt32(Console.ReadLine());
                ListaGraficos.Add(new Rectangulo(x,y,alto,ancho));
                break;
            }

        }
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

    public void Dibujar()
    {
        foreach (var item in ListaGraficos)
        {
            item.Dibujar();
        }
    }
}