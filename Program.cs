using ConsoleApp1;

GraficoCompuesto Compuesto = new GraficoCompuesto();
for (int i = 0; i < 3; i++) 
{
    Console.WriteLine("1) Punto 2) Circulo 3)Rectangulo ");
    int type = Convert.ToInt32(Console.ReadLine());
    Compuesto.Agregar(type);
}
Console.WriteLine("Mover:");
Console.WriteLine("x?");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y?");
int y = Convert.ToInt32(Console.ReadLine());
if (Compuesto.Mover(x, y))
{
    Compuesto.Dibujar();
}
else
{
    Console.WriteLine("Se sale de la pantalla");
}

;
