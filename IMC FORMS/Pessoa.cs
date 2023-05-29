public class Pessoa
{
    private string nome;
    private string cpf;
    private string idade;
    private string sexo;
    private double peso;
    private double altura;


    public Pessoa(string nome, string cpf, string idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public string GetCPF()
    {
        return this.cpf;
    }
    public void SetCPF(string cpf)
    {
        this.cpf = cpf;
    }

    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetIdade()
    {
        return this.idade;
    }
    public void SetIdade(string idade)
    {
        this.idade = idade;
    }

    public string GetSexo()
    {
        return this.sexo;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }

    public double GetPeso()
    {
        return this.peso;
    }
    public void SetPeso(double peso)
    {
        this.peso = peso;
    }

    public double GetAltura()
    {
        return this.altura;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public (double, string, string) CalcularIMC()

    {
        double imc = this.peso / (this.altura * this.altura);

        if (imc < 18.5)
        {
            string classi = "Classificação = Magreza";
            string grau = "Obesidade grau: 0";
            return (imc, classi, grau);
        }
        else if (imc > 18.5 && imc <= 24.9)
        {
            string classi = "Classificação = Normal";
            string grau = "Obesidade grau: 0";
            return (imc, classi, grau);
        }
        else if (imc > 24.9 && imc <= 29.9)
        {
            string classi = "Classificação = Sobrepeso";
            string grau = "Obesidade grau: I";
            return (imc, classi, grau);
        }
        else if (imc > 29.9 && imc <= 39.9)
        {
            string classi = "Classificação = Obesidade";
            string grau = "Obesidade grau: II";
            return (imc, classi, grau);
        }
        else if (imc >= 39.9)
        {
            string classi = "Classificação = Obesidade grave";
            string grau = "Obesidade grau: III";
            return (imc, classi, grau);
        }

        else
        {
            string classi = "Erro";
            string grau = "Erro";
            return (imc, classi, grau);
        }
    }
}