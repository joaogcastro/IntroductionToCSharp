internal class Carro : Veiculo
{
    private int _nPortas;

    public int NPortas
    {
        get => _nPortas;
        set => _nPortas = value;
    }

    public Carro()
    {
        _nPortas = 0;
    }

    public Carro(string placa, string descricao, Cor corExterna, int nPortas) : base(placa, descricao, corExterna)
    {
        _nPortas = nPortas;
    }

    public override void Mostrar()
    {
        Console.WriteLine("Placa: " + _placa);
        Console.WriteLine("Modelo: " + _descricao);
        Console.WriteLine("Cor do carro: " + _corExterna);
        Console.WriteLine("Numero portas: " + _nPortas);
    }
}