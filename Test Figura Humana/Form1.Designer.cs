namespace Test_Figura_Humana
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFiguraHumana = new System.Windows.Forms.TabControl();
            this.tabDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnEvaluador = new System.Windows.Forms.Button();
            this.btnTemporal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNivelInstruccion = new System.Windows.Forms.ComboBox();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TabDatosAdicionales = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.tabFiguraHumana.SuspendLayout();
            this.tabDatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFiguraHumana
            // 
            this.tabFiguraHumana.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabFiguraHumana.Controls.Add(this.tabDatosGenerales);
            this.tabFiguraHumana.Controls.Add(this.TabDatosAdicionales);
            this.tabFiguraHumana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFiguraHumana.HotTrack = true;
            this.tabFiguraHumana.Location = new System.Drawing.Point(0, 0);
            this.tabFiguraHumana.Multiline = true;
            this.tabFiguraHumana.Name = "tabFiguraHumana";
            this.tabFiguraHumana.SelectedIndex = 0;
            this.tabFiguraHumana.Size = new System.Drawing.Size(800, 450);
            this.tabFiguraHumana.TabIndex = 0;
            // 
            // tabDatosGenerales
            // 
            this.tabDatosGenerales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDatosGenerales.Controls.Add(this.btnEvaluador);
            this.tabDatosGenerales.Controls.Add(this.btnTemporal);
            this.tabDatosGenerales.Controls.Add(this.groupBox1);
            this.tabDatosGenerales.Location = new System.Drawing.Point(4, 27);
            this.tabDatosGenerales.Name = "tabDatosGenerales";
            this.tabDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosGenerales.Size = new System.Drawing.Size(792, 419);
            this.tabDatosGenerales.TabIndex = 0;
            this.tabDatosGenerales.Text = "Datos generales";
            this.tabDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // btnEvaluador
            // 
            this.btnEvaluador.Location = new System.Drawing.Point(586, 17);
            this.btnEvaluador.Name = "btnEvaluador";
            this.btnEvaluador.Size = new System.Drawing.Size(198, 23);
            this.btnEvaluador.TabIndex = 5;
            this.btnEvaluador.Text = "Establecer Evaluador";
            this.btnEvaluador.UseVisualStyleBackColor = true;
            this.btnEvaluador.Click += new System.EventHandler(this.btnEvaluador_Click);
            // 
            // btnTemporal
            // 
            this.btnTemporal.Location = new System.Drawing.Point(6, 229);
            this.btnTemporal.Name = "btnTemporal";
            this.btnTemporal.Size = new System.Drawing.Size(191, 23);
            this.btnTemporal.TabIndex = 4;
            this.btnTemporal.Text = "prueba";
            this.btnTemporal.UseVisualStyleBackColor = true;
            this.btnTemporal.Click += new System.EventHandler(this.btnTemporal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFechaEvaluacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbNivelInstruccion);
            this.groupBox1.Controls.Add(this.dateFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo:";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(266, 139);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(136, 139);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nivel de Instrucción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // cbNivelInstruccion
            // 
            this.cbNivelInstruccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelInstruccion.FormattingEnabled = true;
            this.cbNivelInstruccion.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Superior"});
            this.cbNivelInstruccion.Location = new System.Drawing.Point(136, 110);
            this.cbNivelInstruccion.Name = "cbNivelInstruccion";
            this.cbNivelInstruccion.Size = new System.Drawing.Size(208, 23);
            this.cbNivelInstruccion.TabIndex = 4;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNacimiento.Location = new System.Drawing.Point(136, 81);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateFechaNacimiento.Size = new System.Drawing.Size(208, 23);
            this.dateFechaNacimiento.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(10, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese su apellido";
            this.txtApellido.Size = new System.Drawing.Size(334, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese su nombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // TabDatosAdicionales
            // 
            this.TabDatosAdicionales.Location = new System.Drawing.Point(4, 27);
            this.TabDatosAdicionales.Name = "TabDatosAdicionales";
            this.TabDatosAdicionales.Padding = new System.Windows.Forms.Padding(3);
            this.TabDatosAdicionales.Size = new System.Drawing.Size(792, 419);
            this.TabDatosAdicionales.TabIndex = 1;
            this.TabDatosAdicionales.Text = "Datos adicionales";
            this.TabDatosAdicionales.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de evaluación:";
            // 
            // dateFechaEvaluacion
            // 
            this.dateFechaEvaluacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaEvaluacion.Location = new System.Drawing.Point(136, 167);
            this.dateFechaEvaluacion.Name = "dateFechaEvaluacion";
            this.dateFechaEvaluacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateFechaEvaluacion.Size = new System.Drawing.Size(208, 23);
            this.dateFechaEvaluacion.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabFiguraHumana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Test Figura Humana";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabFiguraHumana.ResumeLayout(false);
            this.tabDatosGenerales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabFiguraHumana;
        private TabPage tabDatosGenerales;
        private TabPage TabDatosAdicionales;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private DateTimePicker dateFechaNacimiento;
        private Label label1;
        private ComboBox cbNivelInstruccion;
        private Label label2;
        private Button btnTemporal;
        private Label label3;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private Button btnEvaluador;
        private DateTimePicker dateFechaEvaluacion;
        private Label label4;
    }
}