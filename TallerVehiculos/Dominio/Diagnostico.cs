namespace Dominio;

public class Diagnostico
{
    public int IdDiagnostico { get; set; }
    public string DescripcionDiagnostico { get; set; } 
    public DateTime FechaDiagnostico { get; set; }
    public List<Mecanico> Mecanicos { get; set; }
    public List<MecanicoResponsableDiagnostico> MecanicoResponsableDiagnosticos { get; set; }
}