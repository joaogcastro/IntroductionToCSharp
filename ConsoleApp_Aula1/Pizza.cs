using static Complemento;

public class Pizza
{
    private string _categoria;
    private string _sabor;
    private string _tamanho;
    private static List<Complemento> complementos = new List<Complemento>();

    public string Categoria { get; set; }
    public string Sabor { get; set; }
    public string Tamanho { get; }
    public bool AdicionarComplemento(Complemento complemento)
    {
        complementos.Add(complemento);
        return true;
    }

    public bool RemoverComplemento(Complemento complemento)
    {
        complementos.Remove(complemento);
        return true;
    }
}