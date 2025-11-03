using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        Sistema sis = new Sistema();
        int nro;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region el sistema recibe camiones, asique armo un camion ficticio para iniciarlo con autos  a la concesionaria
            ///esto se deduce muy bien cuando ven como funciona el recibir camion y descargar camion - botones de la derecha

            List<Auto> lista = new List<Auto>
        {
            new Auto(100, "Audi AA"),
            new Auto(101, "Audi AA")
        };


            Camion camion = new Camion(DateTime.Now, 10);
            camion.NroRegisto = sis.NroOrden;
            foreach (Auto auto in lista)
            {
                camion.CargarVehiculo(auto);
            }
            #endregion

            //muestro lo que hay en  el listbox la darsena  (sector de carga) de la concesionaria
            listBox1.Items.AddRange(lista.ToArray());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int capacidad = Convert.ToInt32(tbCapacidad.Text);

            nro = sis.GenerarCamion(fecha, capacidad);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auto seleccionado = listBox1.SelectedItem as Auto;

            if (seleccionado != null)
            {
                sis.CargarCamion(nro, seleccionado);
                listBox1.Items.Remove(seleccionado);
                listBox1.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auto");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Auto descargado = sis.DescargarCamion(nro);

            listBox2.Items.Add(descargado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Aca exportamos/creamos un archivo csv con la lista de autos transportados
            sis.CerrarCamion(nro);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    listBox1.Items.Clear();

                    sr.ReadLine();//descartar cabecera
                    while (sr.EndOfStream == false)
                    {
                        #region parsing
                        string linea = sr.ReadLine();

                        string[] campos = linea.Split(';');

                        int nro = Convert.ToInt32(campos[0]);
                        string modelo = campos[1];
                        double precio = Convert.ToDouble(campos[2]);
                        #endregion

                        Auto nuevo = new Auto(nro, modelo);
                        nuevo.Precio = precio;

                        listBox1.Items.Add(nuevo); //Ahi tiene sentido el listbox2 para usarlo de lista intermedia
                    }

                    //acá recien se cuantos autos tengo , ahi puedo cargar el camion
                    Camion camion = new Camion(DateTime.Now, listBox1.Items.Count);

                    sis.RecibirCamion(camion);

                    //antes debo registrarlo , porque el sistema le tiene que dar un nro de registro
                    foreach (Auto auto in listBox1.Items)
                    {
                        sis.CargarCamion(camion.NroRegisto, auto);
                    }
                    nro = camion.NroRegisto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();
                }
            }
        }
    }
}
