namespace Dominio;


public class Sucursal
{
    public int IdSucursal { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public bool Estado { get; set; }
    public int EncargadoId { get; set; }
    public Administrativo Administrativo { get; set; }
    public int CiudadId { get; set; }
    public Ciudad Ciudad { get; set; }
}