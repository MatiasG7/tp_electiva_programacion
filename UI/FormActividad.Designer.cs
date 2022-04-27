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
            this.listBoxActComisiones = new System.Windows.Forms.ListBox();
            this.labelActCom = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActID
            // 
            this.labelActID.AutoSize = true;
            this.labelActID.Location = new System.Drawing.Point(18, 19);
            this.labelActID.Name = "labelActID";
            this.labelActID.Size = new System.Drawing.Size(18, 13);
            this.labelActID.TabIndex = 0;
            this.labelActID.Text = "ID";
            // 
            // labelActDescripcion
            // 
            this.labelActDescripcion.AutoSize = true;
            this.labelActDescripcion.Location = new System.Drawing.Point(18, 72);
            this.labelActDescripcion.Name = "labelActDescripcion";
            this.labelActDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelActDescripcion.TabIndex = 1;
            this.labelActDescripcion.Text = "Descripcion";
            // 
            // labelActCosto
            // 
            this.labelActCosto.AutoSize = true;
            this.labelActCosto.Location = new System.Drawing.Point(18, 125);
            this.labelActCosto.Name = "labelActCosto";
            this.labelActCosto.Size = new System.Drawing.Size(34, 13);
            this.labelActCosto.TabIndex = 2;
            this.labelActCosto.Text = "Costo";
            // 
            // textBoxActID
            // 
            this.textBoxActID.Location = new System.Drawing.Point(21, 35);
            this.textBoxActID.Name = "textBoxActID";
            this.textBoxActID.Size = new System.Drawing.Size(100, 20);
            this.textBoxActID.TabIndex = 3;
            this.textBoxActID.TextChanged += new System.EventHandler(this.textBoxActID_TextChanged);
            this.textBoxActID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActID_Validating);
            this.textBoxActID.Validated += new System.EventHandler(this.textBoxActID_Validated);
            // 
            // textBoxActDesc
            // 
            this.textBoxActDesc.Location = new System.Drawing.Point(21, 88);
            this.textBoxActDesc.Name = "textBoxActDesc";
            this.textBoxActDesc.Size = new System.Drawing.Size(210, 20);
            this.textBoxActDesc.TabIndex = 4;
            this.textBoxActDesc.TextChanged += new System.EventHandler(this.textBoxActDesc_TextChanged);
            this.textBoxActDesc.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActDesc_Validating);
            this.textBoxActDesc.Validated += new System.EventHandler(this.textBoxActDesc_Validated);
            // 
            // textBoxActCosto
            // 
            this.textBoxActCosto.Location = new System.Drawing.Point(21, 141);
            this.textBoxActCosto.Name = "textBoxActCosto";
            this.textBoxActCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxActCosto.TabIndex = 5;
            this.textBoxActCosto.TextChanged += new System.EventHandler(this.textBoxActCosto_TextChanged);
            this.textBoxActCosto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActCosto_Validating);
            this.textBoxActCosto.Validated += new System.EventHandler(this.textBoxActCosto_Validated);
            // 
            // buttonActCrear
            // 
            this.buttonActCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActCrear.Location = new System.Drawing.Point(315, 401);
            this.buttonActCrear.Name = "buttonActCrear";
            this.buttonActCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonActCrear.TabIndex = 6;
            this.buttonActCrear.Text = "Crear";
            this.buttonActCrear.UseVisualStyleBackColor = true;
            this.buttonActCrear.Click += new System.EventHandler(this.buttonActCrear_Click);
            // 
            // buttonActCancelar
            // 
            this.buttonActCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActCancelar.Location = new System.Drawing.Point(422, 400);
            this.buttonActCancelar.Name = "buttonActCancelar";
            this.buttonActCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonActCancelar.TabIndex = 7;
            this.buttonActCancelar.Text = "Cancelar";
            this.buttonActCancelar.UseVisualStyleBackColor = true;
            this.buttonActCancelar.Click += new System.EventHandler(this.buttonActCancelar_Click);
            // 
            // buttonActModif
            // 
            this.buttonActModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActModif.Location = new System.Drawing.Point(315, 400);
            this.buttonActModif.Name = "buttonActModif";
            this.buttonActModif.Size = new System.Drawing.Size(75, 23);
            this.buttonActModif.TabIndex = 8;
            this.buttonActModif.Text = "Modificar";
            this.buttonActModif.UseVisualStyleBackColor = true;
            this.buttonActModif.Click += new System.EventHandler(this.buttonActModif_Click);
            // 
            // buttonActAceptar
            // 
            this.buttonActAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActAceptar.Location = new System.Drawing.Point(315, 400);
            this.buttonActAceptar.Name = "buttonActAceptar";
            this.buttonActAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonActAceptar.TabIndex = 9;
            this.buttonActAceptar.Text = "Aceptar";
            this.buttonActAceptar.UseVisualStyleBackColor = true;
            this.buttonActAceptar.Click += new System.EventHandler(this.buttonActAceptar_Click);
            // 
            // listBoxActComisiones
            // 
            this.listBoxActComisiones.FormattingEnabled = true;
            this.listBoxActComisiones.Location = new System.Drawing.Point(495, 35);
            this.listBoxActComisiones.Name = "listBoxActComisiones";
            this.listBoxActComisiones.Size = new System.Drawing.Size(300, 290);
            this.listBoxActComisiones.TabIndex = 13;
            this.listBoxActComisiones.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxActComisiones_Format);
            // 
            // labelActCom
            // 
            this.labelActCom.AutoSize = true;
            this.labelActCom.Location = new System.Drawing.Point(495, 19);
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
        private System.Windows.Forms.ListBox listBoxActComisiones;
        private System.Windows.Forms.Label labelActCom;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}