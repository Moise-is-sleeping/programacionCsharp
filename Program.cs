

var discoteca = new Disco("Comedia");
Console.WriteLine(discoteca.Nombre);
internal class Disco
{
    public Disco(string nombre)
    {
        Nombre = nombre;
    }
    public string Nombre { get; set; }


}

interface IFiestero
{
    public void TomaPirula();
    public int VendePpirula();
}