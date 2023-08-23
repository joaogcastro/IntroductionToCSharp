internal class Program
{
    public static void Main(string[] args)
    {
        Veiculo veiculo = new(corExterna: Veiculo.Cor.Branca,
        descricao: "Veiculo do Evandro",
        placa: "ABC-1234",
        modelo: new(new("Fiat"), "Argo"));

        veiculo.Mostrar();

        Moto moto = new("DEF-5698",new(new("Fiat"), "Argo"),"Kawazaki Ninja", Veiculo.Cor.Verde, false);
        moto.Mostrar();
       
    }
}