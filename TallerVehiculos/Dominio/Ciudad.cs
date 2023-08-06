namespace Dominio;

public class Ciudad
{
    public int IdCiudad { get; set; }
    public string Nombre { get; set; }
    public int NroSucursales { get; set; }
    public int DepartamentoId { get; set; } 
    public Departamento Departamento { get; set; }
}