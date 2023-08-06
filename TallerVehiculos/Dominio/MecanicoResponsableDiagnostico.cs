namespace Dominio;

public class MecanicoResponsableDiagnostico
{
    public int MecanicoId { get; set; } 
    public Mecanico Mecanico { get; set; }
    public int DiagnosticoId { get; set; }
    public Diagnostico Diagnostico { get; set; }
}