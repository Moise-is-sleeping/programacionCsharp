namespace ConsoleApp1;

public class Circulo : Punto
{
    private int radio;
    
    public Circulo(int x, int y, int radio) : base(x,y )
    {
        if (radio + x is > 800 or < 0 || radio + y is > 600 or < 0)
        {
            throw new Exception("Error con los parametros");
        }
        {
            this.radio = radio;
        }

    }

    public override bool Mover(int x, int y)
    {
        return (y + radio < 600 && y + radio > 0 && x + radio < 800 && x + radio > 0);
        
    }

    public override string Dibujar()
    {
        return $"Circulo x = {x} y = {y} radio = {radio}";
    }
}