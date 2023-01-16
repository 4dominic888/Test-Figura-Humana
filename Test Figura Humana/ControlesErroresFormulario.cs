using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Figura_Humana
{
    internal static class ControlesErroresFormulario
    {
        private static void mensajeCaja(string mensaje) => MessageBox.Show(mensaje, Principal.titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public static bool stringTextBoxError(TextBox textBox, string mensaje = "El texto está vacío")
        {
            if (textBox.Text.Trim() == "") { mensajeCaja(mensaje); return true; }
            else return false;
        }
        public static bool dateFormatError(DateTimePicker dateTime, int minimo, string mensaje = "Fecha no válida")
        {
            if ((DateTime.Today.Year - dateTime.Value.Year) < minimo) { mensajeCaja(mensaje); return true; }
            else return false;
        }
        public static bool seleccionComboBoxError(ComboBox combobox, string mensaje = "No ha seleccionado un valor válido")
        {
            if (combobox.SelectedIndex is -1) { mensajeCaja(mensaje); return true; }
            else return false;
        }
        public static bool seleccionRadioButtonError(string mensaje = "No se ha elegido un RadioButton" ,params RadioButton[] buttons)
        {
            bool ningunoActivado = true;
            foreach (RadioButton item in buttons) if (item.Checked) ningunoActivado = false;
            if (ningunoActivado) { mensajeCaja(mensaje); return true; }
            else return false;
        }
    }
}
