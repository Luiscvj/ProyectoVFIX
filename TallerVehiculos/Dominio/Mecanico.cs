namespace Dominio;

public class Mecanico :BasePersona
{
    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    public List<Diagnostico> Diagnosticos { get; set; }
    public List<MecanicoResponsableDiagnostico> MecanicoResponsableDiagnostico { get; set; }
    }