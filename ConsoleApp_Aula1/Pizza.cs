using Complemento;
 
public class Pizza{
    private string _categoria;
    private string _sabor;
    private string _tamanho;
    private static List<Complemento> complementos = new List<Complemento;

    public string Categoria { get; set; }
    public string Sabor { get; set;}
    public string Tamanho { get;}
    public boolean AdicionarComplemento(Complemento complemento){
        complementos.Add(complemento);
        return true;
    }

    public boolean RemoverComplemento(Complemento complemento){
        complementos.remove(complemento);
        return true;
    }
}