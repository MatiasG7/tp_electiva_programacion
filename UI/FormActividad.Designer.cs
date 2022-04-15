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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComCrear = new System.Windows.Forms.Button();
            this.buttonComElim = new System.Windows.Forms.Button();
            this.buttonComModif = new System.Windows.Forms.Button();
            this.buttonComMostrar = new System.Windows.Forms.Button();
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
            // 
            // textBoxActDesc
            // 
            this.textBoxActDesc.Location = new System.Drawing.Point(26, 95);
            this.textBoxActDesc.Name = "textBoxActDesc";
            this.textBoxActDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxActDesc.TabIndex = 4;
            // 
            // textBoxActCosto
            // 
            this.textBoxActCosto.Location = new System.Drawing.Point(26, 155);
            this.textBoxActCosto.Name = "textBoxActCosto";
            this.textBoxActCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxActCosto.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Comisiones";
            // 
            // buttonComCrear
            // 
            this.buttonComCrear.Location = new System.Drawing.Point(557, 202);
            this.buttonComCrear.Name = "buttonComCrear";
            this.buttonComCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonComCrear.TabIndex = 15;
            this.buttonComCrear.Text = "Agregar";
            this.buttonComCrear.UseVisualStyleBackColor = true;
            this.buttonComCrear.Click += new System.EventHandler(this.buttonComCrear_Click);
            // 
            // buttonComElim
            // 
            this.buttonComElim.Location = new System.Drawing.Point(719, 202);
            this.buttonComElim.Name = "buttonComElim";
            this.buttonComElim.Size = new System.Drawing.Size(75, 23);
            this.buttonComElim.TabIndex = 16;
            this.buttonComElim.Text = "Eliminar";
            this.buttonComElim.UseVisualStyleBackColor = true;
            this.buttonComElim.Click += new System.EventHandler(this.buttonComElim_Click);
            // 
            // buttonComModif
            // 
            this.buttonComModif.Location = new System.Drawing.Point(638, 202);
            this.buttonComModif.Name = "buttonComModif";
            this.buttonComModif.Size = new System.Drawing.Size(75, 23);
            this.buttonComModif.TabIndex = 17;
            this.buttonComModif.Text = "Modificar";
            this.buttonComModif.UseVisualStyleBackColor = true;
            this.buttonComModif.Click += new System.EventHandler(this.buttonComModif_Click);
            // 
            // buttonComMostrar
            // 
            this.buttonComMostrar.Location = new System.Drawing.Point(638, 231);
            this.buttonComMostrar.Name = "buttonComMostrar";
            this.buttonComMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonComMostrar.TabIndex = 18;
            this.buttonComMostrar.Text = "Mostrar";
            this.buttonComMostrar.UseVisualStyleBackColor = true;
            this.buttonComMostrar.Click += new System.EventHandler(this.buttonComMostrar_Click);
            // 
            // FormActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonComMostrar);
            this.Controls.Add(this.buttonComModif);
            this.Controls.Add(this.buttonComElim);
            this.Controls.Add(this.buttonComCrear);
            this.Controls.Add(this.label1);
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
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.FormCrearActividad_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComCrear;
        private System.Windows.Forms.Button buttonComElim;
        private System.Windows.Forms.Button buttonComModif;
        private System.Windows.Forms.Button buttonComMostrar;
    }
}