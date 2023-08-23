internal class Moto: Veiculo
{
    private bool _bau;

    public bool Bau
    {
        get => _bau;
        set => _bau = value;
    }

    public Moto()
    {
        _bau = false;
    }

    public Moto (string placa, Modelo modelo, string descricao, Cor corExterna, bool bau) :base(placa, modelo, descricao, corExterna)
    {
        _bau = bau;
    }
}