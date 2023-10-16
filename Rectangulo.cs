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

        return (x + ancho < 800 && x + ancho > 0 && y + alto < 600 && y + alto > 0);

    }
    public override string Dibujar()
    {
        return $"Rectangulo x = {x} y = {y} ancho = {ancho} alto = {alto}";
    }
}