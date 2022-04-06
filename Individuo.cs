public class Individuo {
    public string? Nome { get; set; }
    
    public double Peso { get; set; }

    public double Altura { get; set; }

    public double IMC { get => Math.Round(Peso / (Altura*Altura), 2); }

    public double PesoIdeal { get => Math.Round(21 * (Altura*Altura), 2); }

    public double PesoParaPerder { get => Math.Round(PesoIdeal > Peso ? PesoIdeal - Peso : Peso - PesoIdeal, 2); }

    #region Status
    public string Status(){
        if(IMC <= 0)
        {
            return "Valores inválidos!";
        }
        else if(IMC <= 18.5)
        {
            return $"Status: Abaixo do peso; Você precisa ganhar {PesoParaPerder}kg para ter o peso normal.";
        }
        else if(IMC <= 24.9)
        {
            return "Status: Peso normal;";
        }
        else if(IMC <= 29.9)
        {
            return $"Status: Sobrepeso; Você precisa perder {PesoParaPerder}kg para ter o peso normal.";
        }
        else if(IMC <= 34.9)
        {
            return $"Status: Obesidade Grau I; Você precisa perder {PesoParaPerder}kg para ter o peso normal.";
        }
        else if(IMC <= 39.9)
        {
            return $"Status: Obesidade Grau II; Você precisa perder {PesoParaPerder}kg para ter o peso normal.";
        }
        else if(IMC >= 40)
        {
            return $"Status: Obesidade Grau III ou Mórbida; Você precisa perder {PesoParaPerder}kg para ter o peso normal";
        }

        throw new Exception("Houve um erro!");
    }
#endregion

    #region Construtores
    public Individuo(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }

    public Individuo()
    {
        Nome = "";
        Peso = 0.0;
        Altura = 0.0;
    }
    #endregion
}