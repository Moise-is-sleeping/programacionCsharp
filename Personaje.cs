namespace ConsoleApp1;


public interface IEquipo
{
    
}

enum TipoEquipo
{
    Casco,Peto,guantes,Bots,Amuleto,Anillo
}




public class Personaje
{
    public int Fuerza { get;  private set; }
    public int Inteligencia { get;  private set; }
    public int Destreza { get;  private set; }
    public int Fe { get;  private set; }

    public float Critico { get;  private set; }
    public float DañoCritico { get;  private set; }
    
    private Dictionary<TipoEquipo, IEquipo> Equipo = new Dictionary<TipoEquipo, IEquipo>();

    public Personaje(int fuerza, int inteligencia, int destreza, int fe, float critico, float dañoCritico)
    {
        Fuerza = fuerza;
        Inteligencia = inteligencia;
        Destreza = destreza;
        Fe = fe;
        Critico = critico;
        DañoCritico = dañoCritico;
    }
}