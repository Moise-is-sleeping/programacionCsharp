namespace ConsoleApp1;

public class Circulo : Punto
{
    private int Radio;
    private int X;
    private int Y;


    public Circulo(int x, int y, int radio) : base(x,y )
    {
        Radio = radio;
        X = x;
        Y = y;
    }

    public override bool Mover(int x, int y)
    {
        return (y + Radio < 600 && y + Radio > 0 && x + Radio < 800 && x + Radio > 0);
        
    }

    public override string Dibujar()
    {
        return $"Circulo x = {X} y = {Y} radio = {Radio}";
    }
}