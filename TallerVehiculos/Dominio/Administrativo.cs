namespace Dominio;

public class Administrativo :BasePersona
{
    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    public int  DiagnosticoId { get; set; }
    public Diagnostico Diagnostico { get; set; }
    public int EpsId   { get; set; }
    public Eps Eps { get; set; }
    public int ArlId { get; set; }
    public Arl Arl { get; set; }
    public int SucrusalId { get; set; } 
    public Sucursal Sucursal { get; set; }

}