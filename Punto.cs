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
        return (this.y + y < 600 && this.y + y > 0 && this.x + x < 800 && this.x + x > 0);
    }

    public virtual string Dibujar()
    {
        return $"Punto x = {x} y = {y}";
    }
}