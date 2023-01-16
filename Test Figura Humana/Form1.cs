using Microsoft.VisualBasic;
using static Test_Figura_Humana.ControlesErroresFormulario;
using FiguraHumanaClases;

namespace Test_Figura_Humana
{
    public partial class Principal : Form
    {
        public static string evaluador = "";
        public static string titulo = "Test Figura Humana";
        public Principal() => InitializeComponent();

        private void Principal_Load(object sender, EventArgs e)
        {
            StreamReader leerEvaluador = File.OpenText(@".\Evaluador.evl");
            evaluador = leerEvaluador.ReadLine();
            leerEvaluador.Close();

        }
        private void btnTemporal_Click(object sender, EventArgs e)
        {
            if (stringTextBoxError(txtNombre, "El nombre está vacío")) return;
            if (stringTextBoxError(txtApellido, "El apellido está vacío")) return;
            if (dateFormatError(dateFechaNacimiento, 10, "La fecha de nacimiento indica que el evaluado tiene menos de 10 años")) return;
            if (seleccionComboBoxError(cbNivelInstruccion, "No ha seleccionado un nivel de instrucción")) return;
            if (seleccionRadioButtonError("No ha seleccionado un sexo", rbMasculino, rbFemenino));

            DatosIniciales datos = new DatosIniciales($"{txtNombre.Text.Trim()} {txtApellido.Text.Trim()}",
                                                      (rbMasculino.Checked ? 1 : 0),
                                                      cbNivelInstruccion.Text,
                                                      dateFechaNacimiento.Value,
                                                      dateFechaEvaluacion.Value);

            MessageBox.Show(datos.temp(evaluador));
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
        #endregion
    }
}