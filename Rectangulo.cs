namespace ConsoleApp1;

public class Rectangulo:Punto
{
    private int ancho;
    private int alto;
    
    public Rectangulo(int x,int y, int alto, int ancho) : base(x,y )
    {
        if (alto + x is > 800 or < 0 || alto + y is > 600 or < 0 || ancho + x is > 800 or < 0 || ancho + y is > 600 or < 0)
        {
            throw new Exception("Error con los parametros");
        }
        {
            this.alto = alto;
            this.ancho = ancho;
        }
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