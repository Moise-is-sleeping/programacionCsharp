namespace ConsoleApp1;

public class Circulo : Punto
{
    private int radio;
    private int x;
    private int y;


    public Circulo(int x, int y, int radio) : base(x,y )
    {
        this.radio = radio;
        this.x = x;
        this.y = y;
    }

    public override bool Mover(int x, int y)
    {
        return (y + radio < 600 && x + radio < 800);
    }

    public override void Dibujar()
    {
        Console.WriteLine($"Circulo x = {x} y = {y} radio = {radio}");
    }
}