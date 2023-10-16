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
            return (this.y + y < 600 || this.x + x < 800);
    }

    public virtual void Dibujar()
    {
        Console.WriteLine($"Punto x = {x} y = {y}");
    }
}