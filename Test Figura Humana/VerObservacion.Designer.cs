namespace Test_Figura_Humana
{
    partial class VerObservacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richObservacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richObservacion
            // 
            this.richObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richObservacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richObservacion.Location = new System.Drawing.Point(0, 0);
            this.richObservacion.Name = "richObservacion";
            this.richObservacion.Size = new System.Drawing.Size(714, 367);
            this.richObservacion.TabIndex = 0;
            this.richObservacion.Text = "";
            // 
            // VerObservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 367);
            this.Controls.Add(this.richObservacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "VerObservacion";
            this.Text = "Ver Observacion";
            this.ResumeLayout(false);

        }

        #endregion
        internal RichTextBox richObservacion;
    }
}