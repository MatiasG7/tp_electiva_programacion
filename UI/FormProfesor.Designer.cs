namespace UI
{
    partial class FormProfesor
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
            this.textBoxProfNombre = new System.Windows.Forms.TextBox();
            this.textBoxProfDNI = new System.Windows.Forms.TextBox();
            this.labelProfFNac = new System.Windows.Forms.Label();
            this.labelProfNombre = new System.Windows.Forms.Label();
            this.labelProfDNI = new System.Windows.Forms.Label();
            this.buttonProfAceptar = new System.Windows.Forms.Button();
            this.buttonProfModif = new System.Windows.Forms.Button();
            this.buttonProfCancelar = new System.Windows.Forms.Button();
            this.buttonProfCrear = new System.Windows.Forms.Button();
            this.dateTimePickerProfFNac = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerProfFIng = new System.Windows.Forms.DateTimePicker();
            this.labelProfFIng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProfNombre
            // 
            this.textBoxProfNombre.Location = new System.Drawing.Point(24, 84);
            this.textBoxProfNombre.Name = "textBoxProfNombre";
            this.textBoxProfNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfNombre.TabIndex = 10;
            // 
            // textBoxProfDNI
            // 
            this.textBoxProfDNI.Location = new System.Drawing.Point(24, 35);
            this.textBoxProfDNI.Name = "textBoxProfDNI";
            this.textBoxProfDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfDNI.TabIndex = 9;
            // 
            // labelProfFNac
            // 
            this.labelProfFNac.AutoSize = true;
            this.labelProfFNac.Location = new System.Drawing.Point(21, 117);
            this.labelProfFNac.Name = "labelProfFNac";
            this.labelProfFNac.Size = new System.Drawing.Size(93, 13);
            this.labelProfFNac.TabIndex = 8;
            this.labelProfFNac.Text = "Fecha Nacimiento";
            // 
            // labelProfNombre
            // 
            this.labelProfNombre.AutoSize = true;
            this.labelProfNombre.Location = new System.Drawing.Point(21, 68);
            this.labelProfNombre.Name = "labelProfNombre";
            this.labelProfNombre.Size = new System.Drawing.Size(44, 13);
            this.labelProfNombre.TabIndex = 7;
            this.labelProfNombre.Text = "Nombre";
            // 
            // labelProfDNI
            // 
            this.labelProfDNI.AutoSize = true;
            this.labelProfDNI.Location = new System.Drawing.Point(21, 19);
            this.labelProfDNI.Name = "labelProfDNI";
            this.labelProfDNI.Size = new System.Drawing.Size(26, 13);
            this.labelProfDNI.TabIndex = 6;
            this.labelProfDNI.Text = "DNI";
            // 
            // buttonProfAceptar
            // 
            this.buttonProfAceptar.Location = new System.Drawing.Point(292, 355);
            this.buttonProfAceptar.Name = "buttonProfAceptar";
            this.buttonProfAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonProfAceptar.TabIndex = 15;
            this.buttonProfAceptar.Text = "Aceptar";
            this.buttonProfAceptar.UseVisualStyleBackColor = true;
            this.buttonProfAceptar.Click += new System.EventHandler(this.buttonProfAceptar_Click);
            // 
            // buttonProfModif
            // 
            this.buttonProfModif.Location = new System.Drawing.Point(292, 355);
            this.buttonProfModif.Name = "buttonProfModif";
            this.buttonProfModif.Size = new System.Drawing.Size(75, 23);
            this.buttonProfModif.TabIndex = 14;
            this.buttonProfModif.Text = "Modificar";
            this.buttonProfModif.UseVisualStyleBackColor = true;
            this.buttonProfModif.Click += new System.EventHandler(this.buttonProfModif_Click);
            // 
            // buttonProfCancelar
            // 
            this.buttonProfCancelar.Location = new System.Drawing.Point(404, 355);
            this.buttonProfCancelar.Name = "buttonProfCancelar";
            this.buttonProfCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonProfCancelar.TabIndex = 13;
            this.buttonProfCancelar.Text = "Cancelar";
            this.buttonProfCancelar.UseVisualStyleBackColor = true;
            this.buttonProfCancelar.Click += new System.EventHandler(this.buttonProfCancelar_Click);
            // 
            // buttonProfCrear
            // 
            this.buttonProfCrear.Location = new System.Drawing.Point(292, 355);
            this.buttonProfCrear.Name = "buttonProfCrear";
            this.buttonProfCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonProfCrear.TabIndex = 12;
            this.buttonProfCrear.Text = "Crear";
            this.buttonProfCrear.UseVisualStyleBackColor = true;
            this.buttonProfCrear.Click += new System.EventHandler(this.buttonProfCrear_Click);
            // 
            // dateTimePickerProfFNac
            // 
            this.dateTimePickerProfFNac.Location = new System.Drawing.Point(24, 133);
            this.dateTimePickerProfFNac.Name = "dateTimePickerProfFNac";
            this.dateTimePickerProfFNac.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerProfFNac.TabIndex = 16;
            // 
            // dateTimePickerProfFIng
            // 
            this.dateTimePickerProfFIng.Location = new System.Drawing.Point(24, 182);
            this.dateTimePickerProfFIng.Name = "dateTimePickerProfFIng";
            this.dateTimePickerProfFIng.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerProfFIng.TabIndex = 18;
            // 
            // labelProfFIng
            // 
            this.labelProfFIng.AutoSize = true;
            this.labelProfFIng.Location = new System.Drawing.Point(21, 166);
            this.labelProfFIng.Name = "labelProfFIng";
            this.labelProfFIng.Size = new System.Drawing.Size(75, 13);
            this.labelProfFIng.TabIndex = 17;
            this.labelProfFIng.Text = "Fecha Ingreso";
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerProfFIng);
            this.Controls.Add(this.labelProfFIng);
            this.Controls.Add(this.dateTimePickerProfFNac);
            this.Controls.Add(this.buttonProfAceptar);
            this.Controls.Add(this.buttonProfModif);
            this.Controls.Add(this.buttonProfCancelar);
            this.Controls.Add(this.buttonProfCrear);
            this.Controls.Add(this.textBoxProfNombre);
            this.Controls.Add(this.textBoxProfDNI);
            this.Controls.Add(this.labelProfFNac);
            this.Controls.Add(this.labelProfNombre);
            this.Controls.Add(this.labelProfDNI);
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProfNombre;
        private System.Windows.Forms.TextBox textBoxProfDNI;
        private System.Windows.Forms.Label labelProfFNac;
        private System.Windows.Forms.Label labelProfNombre;
        private System.Windows.Forms.Label labelProfDNI;
        private System.Windows.Forms.Button buttonProfAceptar;
        private System.Windows.Forms.Button buttonProfModif;
        private System.Windows.Forms.Button buttonProfCancelar;
        private System.Windows.Forms.Button buttonProfCrear;
        private System.Windows.Forms.DateTimePicker dateTimePickerProfFNac;
        private System.Windows.Forms.DateTimePicker dateTimePickerProfFIng;
        private System.Windows.Forms.Label labelProfFIng;
    }
}