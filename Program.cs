using ConsoleApp1;


GraficoCompuesto Compuesto = new GraficoCompuesto();
Compuesto.Insert(new Punto(245, 367));
Compuesto.Insert(new Circulo(245, 367,12));
Compuesto.Insert(new Punto(800, 367));




if (Compuesto.Mover(90, 56))
{
    Console.WriteLine(Compuesto.Dibujar());
}
