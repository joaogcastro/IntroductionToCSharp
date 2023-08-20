public class Acompanhamento
{
    private string _tipoAcompanhamento;
    private string _descricao;
    private int _tamanho;

    public string TipoAcompanhamento
    {
        get => _tipoAcompanhamento;
        set => _tipoAcompanhamento = value;
    }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }

    public int Tamanho
    {
        get => _tamanho;
        set => _tamanho = value;
    }
}