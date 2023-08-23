internal class Program{
    public static void Main(string[] args){
        Carro carro = new("ABC-1234", "FIAT Argo", Veiculo.Cor.Branca, 4);
        carro.Mostrar();
    }
}