

namespace Ejercicio2.Models;

public class Sistema
{
    List<Camion> camiones = new List<Camion>();
    List<Auto> autos = new List<Auto>();
    int nro = 1;
    public int NroOrden
    { 
        get
        {
            return nro++;
        }
    }

    public Sistema() { }

    public int GenerarCamion(DateTime fecha, int capacidad)
    {
        Camion nuevo = new Camion(fecha, capacidad);
        camiones.Add(nuevo);

        return nuevo.NroRegisto = NroOrden;
    }

    public void RecibirCamion(Camion unCamion)
    {
        camiones.Add(unCamion);
    }

    public void CargarCamion(int nroOrden, Auto unAuto)
    {
        Camion buscado = null;
        foreach (Camion c in camiones)
        {
            if (c.NroRegisto == nroOrden)
            {
               buscado = c;
            }
        }

        if (buscado != null)
        {
            buscado.CargarVehiculo(unAuto);
        }
    }

    public Auto DescargarCamion(int nroOrden)
    {
        Camion buscado = null;
        Auto retirado = null;
        foreach (Camion c in camiones)
        {
            if (c.NroRegisto == nroOrden)
            {
                buscado = c;
            }
        }

        if (buscado != null)
        {
            retirado = buscado.RetirarVehiculo();
            autos.Add(retirado);
        }

        return retirado;
    }

    public void CerrarCamion(int nro)
    {
        Camion camion = null;
        foreach (Camion c in camiones)
        {
            if (c.NroRegisto == nro)
            {
                camion = c;
            }
        }
        if (camion != null)
        {
            {

                string path = camion.ToString() + ".csv";

                FileStream fs = null;
                StreamWriter sw = null;
                try
                {

                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("NroRegistro;Modelo");
                    foreach (string linea in camion.VerCarga())
                    {
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
