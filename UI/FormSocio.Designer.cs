namespace UI
{
    partial class FormSocio
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
            this.components = new System.ComponentModel.Container();
            this.textBoxSocCuotaSocial = new System.Windows.Forms.TextBox();
            this.labelSocCuotaSocial = new System.Windows.Forms.Label();
            this.buttonSocAceptar = new System.Windows.Forms.Button();
            this.buttonSocModif = new System.Windows.Forms.Button();
            this.buttonSocCancelar = new System.Windows.Forms.Button();
            this.buttonSocCrear = new System.Windows.Forms.Button();
            this.labelSocComisiones = new System.Windows.Forms.Label();
            this.listBoxSocComisiones = new System.Windows.Forms.ListBox();
            this.textBoxSocDireccion = new System.Windows.Forms.TextBox();
            this.labelSocDireccion = new System.Windows.Forms.Label();
            this.textBoxSocEmail = new System.Windows.Forms.TextBox();
            this.labelSocEmail = new System.Windows.Forms.Label();
            this.dateTimePickerSocFIng = new System.Windows.Forms.DateTimePicker();
            this.labelSocFIng = new System.Windows.Forms.Label();
            this.dateTimePickerSocFNac = new System.Windows.Forms.DateTimePicker();
            this.textBoxSocNombre = new System.Windows.Forms.TextBox();
            this.textBoxSocDNI = new System.Windows.Forms.TextBox();
            this.labelSocFNac = new System.Windows.Forms.Label();
            this.labelSocNombre = new System.Windows.Forms.Label();
            this.labelSocDNI = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSocCuotaSocial
            // 
            this.textBoxSocCuotaSocial.Location = new System.Drawing.Point(21, 353);
            this.textBoxSocCuotaSocial.Name = "textBoxSocCuotaSocial";
            this.textBoxSocCuotaSocial.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocCuotaSocial.TabIndex = 58;
            this.textBoxSocCuotaSocial.TextChanged += new System.EventHandler(this.textBoxSocCuotaSocial_TextChanged);
            this.textBoxSocCuotaSocial.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSocCuotaSocial_Validating);
            this.textBoxSocCuotaSocial.Validated += new System.EventHandler(this.textBoxSocCuotaSocial_Validated);
            // 
            // labelSocCuotaSocial
            // 
            this.labelSocCuotaSocial.AutoSize = true;
            this.labelSocCuotaSocial.Location = new System.Drawing.Point(18, 337);
            this.labelSocCuotaSocial.Name = "labelSocCuotaSocial";
            this.labelSocCuotaSocial.Size = new System.Drawing.Size(67, 13);
            this.labelSocCuotaSocial.TabIndex = 57;
            this.labelSocCuotaSocial.Text = "Cuota Social";
            // 
            // buttonSocAceptar
            // 
            this.buttonSocAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocAceptar.Location = new System.Drawing.Point(315, 400);
            this.buttonSocAceptar.Name = "buttonSocAceptar";
            this.buttonSocAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonSocAceptar.TabIndex = 56;
            this.buttonSocAceptar.Text = "Aceptar";
            this.buttonSocAceptar.UseVisualStyleBackColor = true;
            this.buttonSocAceptar.Click += new System.EventHandler(this.buttonSocAceptar_Click_1);
            // 
            // buttonSocModif
            // 
            this.buttonSocModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocModif.Location = new System.Drawing.Point(315, 400);
            this.buttonSocModif.Name = "buttonSocModif";
            this.buttonSocModif.Size = new System.Drawing.Size(75, 23);
            this.buttonSocModif.TabIndex = 55;
            this.buttonSocModif.Text = "Modificar";
            this.buttonSocModif.UseVisualStyleBackColor = true;
            this.buttonSocModif.Click += new System.EventHandler(this.buttonSocModif_Click_1);
            // 
            // buttonSocCancelar
            // 
            this.buttonSocCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocCancelar.Location = new System.Drawing.Point(422, 400);
            this.buttonSocCancelar.Name = "buttonSocCancelar";
            this.buttonSocCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonSocCancelar.TabIndex = 54;
            this.buttonSocCancelar.Text = "Cancelar";
            this.buttonSocCancelar.UseVisualStyleBackColor = true;
            this.buttonSocCancelar.Click += new System.EventHandler(this.buttonSocCancelar_Click_1);
            // 
            // buttonSocCrear
            // 
            this.buttonSocCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocCrear.Location = new System.Drawing.Point(315, 400);
            this.buttonSocCrear.Name = "buttonSocCrear";
            this.buttonSocCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonSocCrear.TabIndex = 53;
            this.buttonSocCrear.Text = "Crear";
            this.buttonSocCrear.UseVisualStyleBackColor = true;
            this.buttonSocCrear.Click += new System.EventHandler(this.buttonSocCrear_Click_1);
            // 
            // labelSocComisiones
            // 
            this.labelSocComisiones.AutoSize = true;
            this.labelSocComisiones.Location = new System.Drawing.Point(492, 19);
            this.labelSocComisiones.Name = "labelSocComisiones";
            this.labelSocComisiones.Size = new System.Drawing.Size(60, 13);
            this.labelSocComisiones.TabIndex = 52;
            this.labelSocComisiones.Text = "Comisiones";
            // 
            // listBoxSocComisiones
            // 
            this.listBoxSocComisiones.FormattingEnabled = true;
            this.listBoxSocComisiones.Location = new System.Drawing.Point(495, 35);
            this.listBoxSocComisiones.Name = "listBoxSocComisiones";
            this.listBoxSocComisiones.Size = new System.Drawing.Size(300, 290);
            this.listBoxSocComisiones.TabIndex = 51;
            this.listBoxSocComisiones.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxSocComisiones_Format);
            // 
            // textBoxSocDireccion
            // 
            this.textBoxSocDireccion.Location = new System.Drawing.Point(21, 247);
            this.textBoxSocDireccion.Name = "textBoxSocDireccion";
            this.textBoxSocDireccion.Size = new System.Drawing.Size(210, 20);
            this.textBoxSocDireccion.TabIndex = 50;
            this.textBoxSocDireccion.TextChanged += new System.EventHandler(this.textBoxSocDireccion_TextChanged);
            this.textBoxSocDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSocDireccion_Validating);
            this.textBoxSocDireccion.Validated += new System.EventHandler(this.textBoxSocDireccion_Validated);
            // 
            // labelSocDireccion
            // 
            this.labelSocDireccion.AutoSize = true;
            this.labelSocDireccion.Location = new System.Drawing.Point(18, 231);
            this.labelSocDireccion.Name = "labelSocDireccion";
            this.labelSocDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelSocDireccion.TabIndex = 49;
            this.labelSocDireccion.Text = "Dirección";
            // 
            // textBoxSocEmail
            // 
            this.textBoxSocEmail.Location = new System.Drawing.Point(21, 194);
            this.textBoxSocEmail.Name = "textBoxSocEmail";
            this.textBoxSocEmail.Size = new System.Drawing.Size(210, 20);
            this.textBoxSocEmail.TabIndex = 48;
            this.textBoxSocEmail.TextChanged += new System.EventHandler(this.textBoxSocEmail_TextChanged);
            this.textBoxSocEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSocEmail_Validating);
            this.textBoxSocEmail.Validated += new System.EventHandler(this.textBoxSocEmail_Validated);
            // 
            // labelSocEmail
            // 
            this.labelSocEmail.AutoSize = true;
            this.labelSocEmail.Location = new System.Drawing.Point(18, 178);
            this.labelSocEmail.Name = "labelSocEmail";
            this.labelSocEmail.Size = new System.Drawing.Size(32, 13);
            this.labelSocEmail.TabIndex = 47;
            this.labelSocEmail.Text = "Email";
            // 
            // dateTimePickerSocFIng
            // 
            this.dateTimePickerSocFIng.Location = new System.Drawing.Point(21, 300);
            this.dateTimePickerSocFIng.Name = "dateTimePickerSocFIng";
            this.dateTimePickerSocFIng.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerSocFIng.TabIndex = 46;
            // 
            // labelSocFIng
            // 
            this.labelSocFIng.AutoSize = true;
            this.labelSocFIng.Location = new System.Drawing.Point(18, 284);
            this.labelSocFIng.Name = "labelSocFIng";
            this.labelSocFIng.Size = new System.Drawing.Size(75, 13);
            this.labelSocFIng.TabIndex = 45;
            this.labelSocFIng.Text = "Fecha Ingreso";
            // 
            // dateTimePickerSocFNac
            // 
            this.dateTimePickerSocFNac.Location = new System.Drawing.Point(21, 141);
            this.dateTimePickerSocFNac.Name = "dateTimePickerSocFNac";
            this.dateTimePickerSocFNac.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerSocFNac.TabIndex = 44;
            // 
            // textBoxSocNombre
            // 
            this.textBoxSocNombre.Location = new System.Drawing.Point(21, 88);
            this.textBoxSocNombre.Name = "textBoxSocNombre";
            this.textBoxSocNombre.Size = new System.Drawing.Size(210, 20);
            this.textBoxSocNombre.TabIndex = 43;
            this.textBoxSocNombre.TextChanged += new System.EventHandler(this.textBoxSocNombre_TextChanged);
            this.textBoxSocNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSocNombre_Validating);
            this.textBoxSocNombre.Validated += new System.EventHandler(this.textBoxSocNombre_Validated);
            // 
            // textBoxSocDNI
            // 
            this.textBoxSocDNI.Location = new System.Drawing.Point(21, 35);
            this.textBoxSocDNI.Name = "textBoxSocDNI";
            this.textBoxSocDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocDNI.TabIndex = 42;
            this.textBoxSocDNI.TextChanged += new System.EventHandler(this.textBoxSocDNI_TextChanged);
            this.textBoxSocDNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSocDNI_Validating);
            this.textBoxSocDNI.Validated += new System.EventHandler(this.textBoxSocDNI_Validated);
            // 
            // labelSocFNac
            // 
            this.labelSocFNac.AutoSize = true;
            this.labelSocFNac.Location = new System.Drawing.Point(18, 125);
            this.labelSocFNac.Name = "labelSocFNac";
            this.labelSocFNac.Size = new System.Drawing.Size(93, 13);
            this.labelSocFNac.TabIndex = 41;
            this.labelSocFNac.Text = "Fecha Nacimiento";
            // 
            // labelSocNombre
            // 
            this.labelSocNombre.AutoSize = true;
            this.labelSocNombre.Location = new System.Drawing.Point(18, 72);
            this.labelSocNombre.Name = "labelSocNombre";
            this.labelSocNombre.Size = new System.Drawing.Size(44, 13);
            this.labelSocNombre.TabIndex = 40;
            this.labelSocNombre.Text = "Nombre";
            // 
            // labelSocDNI
            // 
            this.labelSocDNI.AutoSize = true;
            this.labelSocDNI.Location = new System.Drawing.Point(18, 19);
            this.labelSocDNI.Name = "labelSocDNI";
            this.labelSocDNI.Size = new System.Drawing.Size(26, 13);
            this.labelSocDNI.TabIndex = 39;
            this.labelSocDNI.Text = "DNI";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSocCuotaSocial);
            this.Controls.Add(this.labelSocCuotaSocial);
            this.Controls.Add(this.buttonSocAceptar);
            this.Controls.Add(this.buttonSocModif);
            this.Controls.Add(this.buttonSocCancelar);
            this.Controls.Add(this.buttonSocCrear);
            this.Controls.Add(this.labelSocComisiones);
            this.Controls.Add(this.listBoxSocComisiones);
            this.Controls.Add(this.textBoxSocDireccion);
            this.Controls.Add(this.labelSocDireccion);
            this.Controls.Add(this.textBoxSocEmail);
            this.Controls.Add(this.labelSocEmail);
            this.Controls.Add(this.dateTimePickerSocFIng);
            this.Controls.Add(this.labelSocFIng);
            this.Controls.Add(this.dateTimePickerSocFNac);
            this.Controls.Add(this.textBoxSocNombre);
            this.Controls.Add(this.textBoxSocDNI);
            this.Controls.Add(this.labelSocFNac);
            this.Controls.Add(this.labelSocNombre);
            this.Controls.Add(this.labelSocDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSocCuotaSocial;
        private System.Windows.Forms.Label labelSocCuotaSocial;
        private System.Windows.Forms.Button buttonSocAceptar;
        private System.Windows.Forms.Button buttonSocModif;
        private System.Windows.Forms.Button buttonSocCancelar;
        private System.Windows.Forms.Button buttonSocCrear;
        private System.Windows.Forms.Label labelSocComisiones;
        private System.Windows.Forms.ListBox listBoxSocComisiones;
        private System.Windows.Forms.TextBox textBoxSocDireccion;
        private System.Windows.Forms.Label labelSocDireccion;
        private System.Windows.Forms.TextBox textBoxSocEmail;
        private System.Windows.Forms.Label labelSocEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerSocFIng;
        private System.Windows.Forms.Label labelSocFIng;
        private System.Windows.Forms.DateTimePicker dateTimePickerSocFNac;
        private System.Windows.Forms.TextBox textBoxSocNombre;
        private System.Windows.Forms.TextBox textBoxSocDNI;
        private System.Windows.Forms.Label labelSocFNac;
        private System.Windows.Forms.Label labelSocNombre;
        private System.Windows.Forms.Label labelSocDNI;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}