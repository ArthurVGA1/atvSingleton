public class Caldeira
{
    private static Caldeira _instancia;
    public bool vazia { get; private set; } = true;
    public bool fervida { get; private set; } = false;

    private Caldeira() { } 

    public static Caldeira GetInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new Caldeira();
        }
        return _instancia;
    }

    public void encher()
    {
        if (vazia)
        {
            vazia = false;
            fervida = false;
            Console.WriteLine("Caldeira cheia");
        }
        else
        {
            Console.WriteLine("Erro: Caldeira já está cheia.");
        }
    }

    public void ferver()
    {
        if (!vazia && !fervida)
        {
            fervida = true;
            Console.WriteLine("A caldeira está fervendo");
        }
        else if (vazia)
        {
            Console.WriteLine("Erro: A caldeira está vazia.");
        }
        else
        {
            Console.WriteLine("Erro: A caldeira já está fervida.");
        }
    }

    public void drenar()
    {
        if (fervida && !vazia)
        {
            fervida = false;
            vazia = true;
            Console.WriteLine("Caldeira drenada");
        }
        else if (vazia)
        {
            Console.WriteLine("Erro: A caldeira está vazia");
        }
        else
        {
            Console.WriteLine("Erro: A caldeira não está fervida");
        }
    }
}

public class FabricaDeChocolate
{
    public void TestarCaldeira()
    {
        var caldeira = Caldeira.GetInstancia();

        caldeira.drenar();  
        caldeira.encher();  
        caldeira.ferver();  
        caldeira.ferver();  
        caldeira.drenar();  
        caldeira.encher();  
        caldeira.drenar();  
    }
}

class Program
{
    static void Main(string[] args)
    {
        FabricaDeChocolate fabrica = new FabricaDeChocolate();
        fabrica.TestarCaldeira();
    }
}
