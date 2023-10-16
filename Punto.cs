namespace ConsoleApp1;

public class Punto : IGrafico
{
    private int x;
    private int y;

    public Punto(int x,int y )
    {
        this.y = y;
        this.x = x;
    }

    public virtual bool Mover(int x, int y)
    {
        if (this.y + y < 600 || this.x + x < 800)
        {
            this.x = x;
            this.y = y;
            return true;
        }
        else
        {
            return false;
        }
    }

    public virtual void Dibujar()
    {
        Console.WriteLine($"Punto x = {x} y = {y}");
    }
}