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
            this.components = new System.ComponentModel.Container();
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
            this.labelProfCom = new System.Windows.Forms.Label();
            this.listBoxProfCom = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProfNombre
            // 
            this.textBoxProfNombre.Location = new System.Drawing.Point(21, 88);
            this.textBoxProfNombre.Name = "textBoxProfNombre";
            this.textBoxProfNombre.Size = new System.Drawing.Size(210, 20);
            this.textBoxProfNombre.TabIndex = 10;
            this.textBoxProfNombre.TextChanged += new System.EventHandler(this.textBoxProfNombre_TextChanged);
            this.textBoxProfNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProfNombre_Validating);
            this.textBoxProfNombre.Validated += new System.EventHandler(this.textBoxProfNombre_Validated);
            // 
            // textBoxProfDNI
            // 
            this.textBoxProfDNI.Location = new System.Drawing.Point(21, 35);
            this.textBoxProfDNI.Name = "textBoxProfDNI";
            this.textBoxProfDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfDNI.TabIndex = 9;
            this.textBoxProfDNI.TextChanged += new System.EventHandler(this.textBoxProfDNI_TextChanged);
            this.textBoxProfDNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProfDNI_Validating);
            this.textBoxProfDNI.Validated += new System.EventHandler(this.textBoxProfDNI_Validated);
            // 
            // labelProfFNac
            // 
            this.labelProfFNac.AutoSize = true;
            this.labelProfFNac.Location = new System.Drawing.Point(18, 125);
            this.labelProfFNac.Name = "labelProfFNac";
            this.labelProfFNac.Size = new System.Drawing.Size(93, 13);
            this.labelProfFNac.TabIndex = 8;
            this.labelProfFNac.Text = "Fecha Nacimiento";
            // 
            // labelProfNombre
            // 
            this.labelProfNombre.AutoSize = true;
            this.labelProfNombre.Location = new System.Drawing.Point(18, 72);
            this.labelProfNombre.Name = "labelProfNombre";
            this.labelProfNombre.Size = new System.Drawing.Size(44, 13);
            this.labelProfNombre.TabIndex = 7;
            this.labelProfNombre.Text = "Nombre";
            // 
            // labelProfDNI
            // 
            this.labelProfDNI.AutoSize = true;
            this.labelProfDNI.Location = new System.Drawing.Point(18, 19);
            this.labelProfDNI.Name = "labelProfDNI";
            this.labelProfDNI.Size = new System.Drawing.Size(26, 13);
            this.labelProfDNI.TabIndex = 6;
            this.labelProfDNI.Text = "DNI";
            // 
            // buttonProfAceptar
            // 
            this.buttonProfAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfAceptar.Location = new System.Drawing.Point(315, 371);
            this.buttonProfAceptar.Name = "buttonProfAceptar";
            this.buttonProfAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonProfAceptar.TabIndex = 15;
            this.buttonProfAceptar.Text = "Aceptar";
            this.buttonProfAceptar.UseVisualStyleBackColor = true;
            this.buttonProfAceptar.Click += new System.EventHandler(this.buttonProfAceptar_Click);
            // 
            // buttonProfModif
            // 
            this.buttonProfModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfModif.Location = new System.Drawing.Point(315, 400);
            this.buttonProfModif.Name = "buttonProfModif";
            this.buttonProfModif.Size = new System.Drawing.Size(75, 23);
            this.buttonProfModif.TabIndex = 14;
            this.buttonProfModif.Text = "Modificar";
            this.buttonProfModif.UseVisualStyleBackColor = true;
            this.buttonProfModif.Click += new System.EventHandler(this.buttonProfModif_Click);
            // 
            // buttonProfCancelar
            // 
            this.buttonProfCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfCancelar.Location = new System.Drawing.Point(422, 400);
            this.buttonProfCancelar.Name = "buttonProfCancelar";
            this.buttonProfCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonProfCancelar.TabIndex = 13;
            this.buttonProfCancelar.Text = "Cancelar";
            this.buttonProfCancelar.UseVisualStyleBackColor = true;
            this.buttonProfCancelar.Click += new System.EventHandler(this.buttonProfCancelar_Click);
            // 
            // buttonProfCrear
            // 
            this.buttonProfCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfCrear.Location = new System.Drawing.Point(315, 400);
            this.buttonProfCrear.Name = "buttonProfCrear";
            this.buttonProfCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonProfCrear.TabIndex = 12;
            this.buttonProfCrear.Text = "Crear";
            this.buttonProfCrear.UseVisualStyleBackColor = true;
            this.buttonProfCrear.Click += new System.EventHandler(this.buttonProfCrear_Click);
            // 
            // dateTimePickerProfFNac
            // 
            this.dateTimePickerProfFNac.Location = new System.Drawing.Point(21, 141);
            this.dateTimePickerProfFNac.Name = "dateTimePickerProfFNac";
            this.dateTimePickerProfFNac.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerProfFNac.TabIndex = 16;
            // 
            // dateTimePickerProfFIng
            // 
            this.dateTimePickerProfFIng.Location = new System.Drawing.Point(21, 194);
            this.dateTimePickerProfFIng.Name = "dateTimePickerProfFIng";
            this.dateTimePickerProfFIng.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerProfFIng.TabIndex = 18;
            // 
            // labelProfFIng
            // 
            this.labelProfFIng.AutoSize = true;
            this.labelProfFIng.Location = new System.Drawing.Point(18, 178);
            this.labelProfFIng.Name = "labelProfFIng";
            this.labelProfFIng.Size = new System.Drawing.Size(75, 13);
            this.labelProfFIng.TabIndex = 17;
            this.labelProfFIng.Text = "Fecha Ingreso";
            // 
            // labelProfCom
            // 
            this.labelProfCom.AutoSize = true;
            this.labelProfCom.Location = new System.Drawing.Point(492, 19);
            this.labelProfCom.Name = "labelProfCom";
            this.labelProfCom.Size = new System.Drawing.Size(60, 13);
            this.labelProfCom.TabIndex = 19;
            this.labelProfCom.Text = "Comisiones";
            // 
            // listBoxProfCom
            // 
            this.listBoxProfCom.FormattingEnabled = true;
            this.listBoxProfCom.Location = new System.Drawing.Point(495, 35);
            this.listBoxProfCom.Name = "listBoxProfCom";
            this.listBoxProfCom.Size = new System.Drawing.Size(300, 290);
            this.listBoxProfCom.TabIndex = 20;
            this.listBoxProfCom.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxProfCom_Format);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProfCom);
            this.Controls.Add(this.labelProfCom);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Label labelProfCom;
        private System.Windows.Forms.ListBox listBoxProfCom;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}