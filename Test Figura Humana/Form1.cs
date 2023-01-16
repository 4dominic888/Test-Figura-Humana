using Microsoft.VisualBasic;
using static Test_Figura_Humana.ControlesErroresFormulario;
using FiguraHumanaClases;

namespace Test_Figura_Humana
{
    public partial class Principal : Form
    {
        public static string evaluador = "";
        public static string titulo = "Test Figura Humana";
        public static List<Observacion> observaciones = new List<Observacion>();
        public Principal()
        {
            InitializeComponent();
            #region observaciones
            observaciones.Add(new Observacion("Inicio de la evaluación", ""));
            observaciones.Add(new Observacion("Durante la evaluación", ""));
            observaciones.Add(new Observacion("Al finalizar la evaluación", ""));
            observaciones.Add(new Observacion("Descripción de la realización", ""));
            observaciones.Add(new Observacion("FISICA", ""));
            observaciones.Add(new Observacion("CONDUCTUAL", ""));
            observaciones.Add(new Observacion("EMOCIONAL", ""));
            observaciones.Add(new Observacion("AMBIENTAL", ""));
            foreach (Observacion item in observaciones) { item.contenido = "No hay contenido agregado"; listaObservaciones.Items.Add(item.titulo); }
            #endregion
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            StreamReader leerEvaluador = File.OpenText(@".\Evaluador.evl");
            evaluador = leerEvaluador.ReadLine();
            leerEvaluador.Close();
        }

        #region Botones
        private void btnEvaluador_Click(object sender, EventArgs e)
        {
            string nuevoEvaluador = Interaction.InputBox("Ingrese el nombre completo del evaluador", titulo, evaluador);
            evaluador = (nuevoEvaluador.Trim() == "") ? evaluador : nuevoEvaluador;
            StreamWriter escribir = File.CreateText(@".\Evaluador.evl");
            escribir.Write(evaluador);
            escribir.Close();
        }

        private void btnTemporal_Click(object sender, EventArgs e)
        {
            if (stringTextBoxError(txtNombre, "El nombre está vacío")) return;
            if (stringTextBoxError(txtApellido, "El apellido está vacío")) return;
            if (dateFormatError(dateFechaNacimiento, 10, "La fecha de nacimiento indica que el evaluado tiene menos de 10 años")) return;
            if (seleccionComboBoxError(cbNivelInstruccion, "No ha seleccionado un nivel de instrucción")) return;
            if (seleccionRadioButtonError("No ha seleccionado un sexo", rbMasculino, rbFemenino)) ;

            DatosIniciales datos = new DatosIniciales($"{txtNombre.Text.Trim()} {txtApellido.Text.Trim()}",
                                                      (rbMasculino.Checked ? 1 : 0),
                                                      cbNivelInstruccion.Text,
                                                      dateFechaNacimiento.Value,
                                                      dateFechaEvaluacion.Value);
        }
        #endregion

        private void menuContextualObservaciones_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listaObservaciones.SelectedItem != null) menuOpcionEditar.Enabled = true;
            else menuOpcionEditar.Enabled = false;
        }
        private void listaObservaciones_DoubleClick(object sender, EventArgs e) => listaObservaciones.ClearSelected();
        private void menuOpcionEditar_Click(object sender, EventArgs e)
        {
            VerObservacion ventana = new VerObservacion();
            string opcion = listaObservaciones.Items[listaObservaciones.SelectedIndex].ToString();
            ventana.Text = opcion;

            foreach (Observacion item in observaciones) 
                if (opcion.Equals(item.titulo))
                {
                    ventana.richObservacion.Text = item.contenido;
                    DialogResult result = ventana.ShowDialog();
                    if(DialogResult.Cancel == result)
                    {
                        item.contenido = (ventana.richObservacion.Text.Trim() is "") ? item.contenido : ventana.richObservacion.Text.Trim();
                        ventana.Dispose();
                    }
                }
        }
    }
}