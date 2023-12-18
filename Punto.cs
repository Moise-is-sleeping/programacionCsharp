namespace ConsoleApp1;

public class Punto : IGrafico
{
    public int x;
    public int y;
    
    public Punto(int x,int y )
    {
        if (x is > 800 or < 0 || y is > 600 or < 0)
        {
            throw new Exception("Error con los parametros");
        }
        {
            this.y = y;
            this.x = x;
        }
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