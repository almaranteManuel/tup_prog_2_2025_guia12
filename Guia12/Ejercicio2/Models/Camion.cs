
namespace Ejercicio2.Models;

public class Camion
{
    private DateTime fecha;
    private int capacidad;
    private double valorAsegurado;

    private Stack<Auto> transporte = new Stack<Auto>();
    public int NroRegisto { get; set; }

    public Camion(DateTime fecha, int capacidad)
    {
        this.fecha = fecha;
        this.capacidad = capacidad;
    }

    public void CargarVehiculo(Auto unAuto)
    {
        if (transporte.Count < capacidad)
            transporte.Push(unAuto);

    }

    public Auto RetirarVehiculo()
    {
        if (transporte.Count > 0)
        { 
            Auto retirado = transporte.Pop();
            return retirado;
        }
        return null;
    }

    public string[] VerCarga()
    {
        string[] carga = new string[transporte.Count];
        int n = 0;
        foreach (Auto unAuto in transporte)
        {
            carga[n++] = unAuto.ToString();
        }

        return carga;
    }

    public override string ToString()
    {
        return $"{NroRegisto}_{fecha:yyyyMMdd}";
    }

    public double ValorAsegurado()
    {
        double total = 0;
        foreach (Auto a in transporte)
        {
            total += a.Precio;
        }
        return total;
    }

    public int CantidadVehiculos()
    {
        return transporte.Count;
    }
}
