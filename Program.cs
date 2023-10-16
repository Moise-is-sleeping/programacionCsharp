using ConsoleApp1;


GraficoCompuesto Compuesto = new GraficoCompuesto();
Compuesto.Insert(new Punto(245, 367));
Compuesto.Insert(new Circulo(245, 367,12));
Compuesto.Insert(new Punto(900, 367));




if (Compuesto.Mover(23, 56))
{
    Console.WriteLine(Compuesto.Dibujar());
}
