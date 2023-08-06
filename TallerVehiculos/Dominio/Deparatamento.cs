namespace Dominio;

public class Departamento
{
    public int IdDepartamento { get; set; }
    public string Nombre { get; set; }
    public List<Ciudad> Ciudades { get; set; }
}