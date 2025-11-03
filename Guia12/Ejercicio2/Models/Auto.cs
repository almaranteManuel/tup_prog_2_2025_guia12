
namespace Ejercicio2.Models;

public class Auto
{
    private int numeroRegistro;
    private string modelo;
    public double Precio {  get; set; }

    public Auto(int registro, string modelo)
    {
        this.numeroRegistro = registro;
        this.modelo = modelo;
    }

    public int NroRegistro()
    {
        return numeroRegistro;
    }

    public override string ToString()
    {
        return $"{numeroRegistro} - {modelo} - {Precio}";
    }
}
