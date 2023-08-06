namespace Dominio;

public class BasePersona 
{
    public string  Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Direccion { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
}