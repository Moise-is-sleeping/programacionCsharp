namespace ConsoleApp1;

public class Rectangulo:Punto
{
    private int ancho;
    private int alto;
    private int x;
    private int y;

    public Rectangulo(int x,int y, int alto, int ancho) : base(x,y )
    {
        this.y = y;
        this.x = x;
        this.alto = alto;
        this.ancho = ancho;
    }

    public override bool Mover(int x, int y)
    {
        if(x + ancho < 800 && y + alto < 600)
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
    public override void Dibujar()
    {
        Console.WriteLine($"Rectangulo x = {x} y = {y} ancho = {ancho} alto = {alto}");
    }
}