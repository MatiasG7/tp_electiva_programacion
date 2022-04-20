namespace UI
{
    partial class FormActividad
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
            this.labelActID = new System.Windows.Forms.Label();
            this.labelActDescripcion = new System.Windows.Forms.Label();
            this.labelActCosto = new System.Windows.Forms.Label();
            this.textBoxActID = new System.Windows.Forms.TextBox();
            this.textBoxActDesc = new System.Windows.Forms.TextBox();
            this.textBoxActCosto = new System.Windows.Forms.TextBox();
            this.buttonActCrear = new System.Windows.Forms.Button();
            this.buttonActCancelar = new System.Windows.Forms.Button();
            this.buttonActModif = new System.Windows.Forms.Button();
            this.buttonActAceptar = new System.Windows.Forms.Button();
            this.maskedTextBoxActID = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxActDesc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxActCosto = new System.Windows.Forms.MaskedTextBox();
            this.listBoxActComisiones = new System.Windows.Forms.ListBox();
            this.labelActCom = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActID
            // 
            this.labelActID.AutoSize = true;
            this.labelActID.Location = new System.Drawing.Point(23, 20);
            this.labelActID.Name = "labelActID";
            this.labelActID.Size = new System.Drawing.Size(18, 13);
            this.labelActID.TabIndex = 0;
            this.labelActID.Text = "ID";
            // 
            // labelActDescripcion
            // 
            this.labelActDescripcion.AutoSize = true;
            this.labelActDescripcion.Location = new System.Drawing.Point(23, 79);
            this.labelActDescripcion.Name = "labelActDescripcion";
            this.labelActDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelActDescripcion.TabIndex = 1;
            this.labelActDescripcion.Text = "Descripcion";
            // 
            // labelActCosto
            // 
            this.labelActCosto.AutoSize = true;
            this.labelActCosto.Location = new System.Drawing.Point(23, 139);
            this.labelActCosto.Name = "labelActCosto";
            this.labelActCosto.Size = new System.Drawing.Size(34, 13);
            this.labelActCosto.TabIndex = 2;
            this.labelActCosto.Text = "Costo";
            // 
            // textBoxActID
            // 
            this.textBoxActID.Location = new System.Drawing.Point(26, 36);
            this.textBoxActID.Name = "textBoxActID";
            this.textBoxActID.Size = new System.Drawing.Size(100, 20);
            this.textBoxActID.TabIndex = 3;
            this.textBoxActID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActID_Validating);
            this.textBoxActID.Validated += new System.EventHandler(this.textBoxActID_Validated);
            // 
            // textBoxActDesc
            // 
            this.textBoxActDesc.Location = new System.Drawing.Point(26, 95);
            this.textBoxActDesc.Name = "textBoxActDesc";
            this.textBoxActDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxActDesc.TabIndex = 4;
            this.textBoxActDesc.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActDesc_Validating);
            this.textBoxActDesc.Validated += new System.EventHandler(this.textBoxActDesc_Validated);
            // 
            // textBoxActCosto
            // 
            this.textBoxActCosto.Location = new System.Drawing.Point(26, 155);
            this.textBoxActCosto.Name = "textBoxActCosto";
            this.textBoxActCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxActCosto.TabIndex = 5;
            this.textBoxActCosto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActCosto_Validating);
            this.textBoxActCosto.Validated += new System.EventHandler(this.textBoxActCosto_Validated);
            // 
            // buttonActCrear
            // 
            this.buttonActCrear.Location = new System.Drawing.Point(304, 353);
            this.buttonActCrear.Name = "buttonActCrear";
            this.buttonActCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonActCrear.TabIndex = 6;
            this.buttonActCrear.Text = "Crear";
            this.buttonActCrear.UseVisualStyleBackColor = true;
            this.buttonActCrear.Click += new System.EventHandler(this.buttonActCrear_Click);
            // 
            // buttonActCancelar
            // 
            this.buttonActCancelar.Location = new System.Drawing.Point(416, 353);
            this.buttonActCancelar.Name = "buttonActCancelar";
            this.buttonActCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonActCancelar.TabIndex = 7;
            this.buttonActCancelar.Text = "Cancelar";
            this.buttonActCancelar.UseVisualStyleBackColor = true;
            this.buttonActCancelar.Click += new System.EventHandler(this.buttonActCancelar_Click);
            // 
            // buttonActModif
            // 
            this.buttonActModif.Location = new System.Drawing.Point(304, 353);
            this.buttonActModif.Name = "buttonActModif";
            this.buttonActModif.Size = new System.Drawing.Size(75, 23);
            this.buttonActModif.TabIndex = 8;
            this.buttonActModif.Text = "Modificar";
            this.buttonActModif.UseVisualStyleBackColor = true;
            this.buttonActModif.Click += new System.EventHandler(this.buttonActModif_Click);
            // 
            // buttonActAceptar
            // 
            this.buttonActAceptar.Location = new System.Drawing.Point(304, 353);
            this.buttonActAceptar.Name = "buttonActAceptar";
            this.buttonActAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonActAceptar.TabIndex = 9;
            this.buttonActAceptar.Text = "Aceptar";
            this.buttonActAceptar.UseVisualStyleBackColor = true;
            this.buttonActAceptar.Click += new System.EventHandler(this.buttonActAceptar_Click);
            // 
            // maskedTextBoxActID
            // 
            this.maskedTextBoxActID.Location = new System.Drawing.Point(159, 35);
            this.maskedTextBoxActID.Mask = "9999999999";
            this.maskedTextBoxActID.Name = "maskedTextBoxActID";
            this.maskedTextBoxActID.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBoxActID.TabIndex = 10;
            // 
            // maskedTextBoxActDesc
            // 
            this.maskedTextBoxActDesc.Location = new System.Drawing.Point(159, 94);
            this.maskedTextBoxActDesc.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            this.maskedTextBoxActDesc.Name = "maskedTextBoxActDesc";
            this.maskedTextBoxActDesc.Size = new System.Drawing.Size(157, 20);
            this.maskedTextBoxActDesc.TabIndex = 11;
            // 
            // maskedTextBoxActCosto
            // 
            this.maskedTextBoxActCosto.Location = new System.Drawing.Point(159, 154);
            this.maskedTextBoxActCosto.Mask = "9999999.99";
            this.maskedTextBoxActCosto.Name = "maskedTextBoxActCosto";
            this.maskedTextBoxActCosto.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBoxActCosto.TabIndex = 12;
            // 
            // listBoxActComisiones
            // 
            this.listBoxActComisiones.FormattingEnabled = true;
            this.listBoxActComisiones.Location = new System.Drawing.Point(557, 36);
            this.listBoxActComisiones.Name = "listBoxActComisiones";
            this.listBoxActComisiones.Size = new System.Drawing.Size(237, 160);
            this.listBoxActComisiones.TabIndex = 13;
            // 
            // labelActCom
            // 
            this.labelActCom.AutoSize = true;
            this.labelActCom.Location = new System.Drawing.Point(557, 19);
            this.labelActCom.Name = "labelActCom";
            this.labelActCom.Size = new System.Drawing.Size(60, 13);
            this.labelActCom.TabIndex = 14;
            this.labelActCom.Text = "Comisiones";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelActCom);
            this.Controls.Add(this.listBoxActComisiones);
            this.Controls.Add(this.maskedTextBoxActCosto);
            this.Controls.Add(this.maskedTextBoxActDesc);
            this.Controls.Add(this.maskedTextBoxActID);
            this.Controls.Add(this.buttonActAceptar);
            this.Controls.Add(this.buttonActModif);
            this.Controls.Add(this.buttonActCancelar);
            this.Controls.Add(this.buttonActCrear);
            this.Controls.Add(this.textBoxActCosto);
            this.Controls.Add(this.textBoxActDesc);
            this.Controls.Add(this.textBoxActID);
            this.Controls.Add(this.labelActCosto);
            this.Controls.Add(this.labelActDescripcion);
            this.Controls.Add(this.labelActID);
            this.Name = "FormActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.FormCrearActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActID;
        private System.Windows.Forms.Label labelActDescripcion;
        private System.Windows.Forms.Label labelActCosto;
        private System.Windows.Forms.TextBox textBoxActID;
        private System.Windows.Forms.TextBox textBoxActDesc;
        private System.Windows.Forms.TextBox textBoxActCosto;
        private System.Windows.Forms.Button buttonActCrear;
        private System.Windows.Forms.Button buttonActCancelar;
        private System.Windows.Forms.Button buttonActModif;
        private System.Windows.Forms.Button buttonActAceptar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxActID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxActDesc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxActCosto;
        private System.Windows.Forms.ListBox listBoxActComisiones;
        private System.Windows.Forms.Label labelActCom;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}