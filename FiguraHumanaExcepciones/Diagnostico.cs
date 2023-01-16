
namespace FiguraHumanaClases
{
    public class Diagnostico
    {
        DatosIniciales DatosGenerales { get; set; }
    }
    public class DatosIniciales
    {
        string NombreCompleto { get; set; }
        int Sexo { get; set; }
        string Escolaridad { get; set; }
        DateTime FechaNacimiento { get; set; }
        DateTime FechaEvaluacion { get; set; }

        /// <summary>
        /// Constructor para la clase Datos Iniciales.
        /// </summary>
        /// <param name="NombreCompleto">El nombre completo del paciente</param>
        /// <param name="Sexo">1. Masculino   0. Femenino</param>
        /// <param name="Escolaridad">El grado de instrucción del paciente</param>
        /// <param name="FechaNacimiento">La fecha de nacimiento del paciente</param>
        /// <param name="FechaEvaluacion">La fecha de evaluación</param>
        public DatosIniciales(string NombreCompleto, int Sexo, string Escolaridad, DateTime FechaNacimiento, DateTime FechaEvaluacion)
        {
            this.NombreCompleto = NombreCompleto;
            this.Sexo = Sexo;
            this.Escolaridad = Escolaridad;
            this.FechaNacimiento = FechaNacimiento;
            this.FechaEvaluacion = FechaEvaluacion;
        }
        public int Edad() => DateTime.Today.Year - FechaNacimiento.Year;
        public string temp(string evaluador)
        {
            return $"Nombres: {NombreCompleto}\n" +
                   $"Edad: {Edad()} años\n" +
                   $"Sexo: {(Sexo is 1 ? "Masculino" : "Femenino")}\n" +
                   $"Escolaridad : {Escolaridad}\n" +
                   $"Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}\n" +
                   $"Fecha de evaluación: {FechaEvaluacion.ToShortDateString()}\n" +
                   $"Evaluador: {evaluador}";

        }
    }
}