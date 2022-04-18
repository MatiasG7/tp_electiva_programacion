namespace UI
{
    partial class FormInscripcionComision
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
            this.listBoxInsSocAct = new System.Windows.Forms.ListBox();
            this.listBoxInsSocCom = new System.Windows.Forms.ListBox();
            this.labelActividades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsConfirmar = new System.Windows.Forms.Button();
            this.buttonInsCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxInsSocAct
            // 
            this.listBoxInsSocAct.FormattingEnabled = true;
            this.listBoxInsSocAct.Location = new System.Drawing.Point(12, 46);
            this.listBoxInsSocAct.Name = "listBoxInsSocAct";
            this.listBoxInsSocAct.Size = new System.Drawing.Size(304, 277);
            this.listBoxInsSocAct.TabIndex = 0;
            this.listBoxInsSocAct.SelectedIndexChanged += new System.EventHandler(this.listBoxInsSocAct_SelectedIndexChanged);
            // 
            // listBoxInsSocCom
            // 
            this.listBoxInsSocCom.FormattingEnabled = true;
            this.listBoxInsSocCom.Location = new System.Drawing.Point(484, 46);
            this.listBoxInsSocCom.Name = "listBoxInsSocCom";
            this.listBoxInsSocCom.Size = new System.Drawing.Size(304, 277);
            this.listBoxInsSocCom.TabIndex = 1;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Location = new System.Drawing.Point(9, 30);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(132, 13);
            this.labelActividades.TabIndex = 2;
            this.labelActividades.Text = "Selecciones una actividad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "----->";
            // 
            // buttonInsConfirmar
            // 
            this.buttonInsConfirmar.Location = new System.Drawing.Point(681, 381);
            this.buttonInsConfirmar.Name = "buttonInsConfirmar";
            this.buttonInsConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsConfirmar.TabIndex = 5;
            this.buttonInsConfirmar.Text = "Confirmar";
            this.buttonInsConfirmar.UseVisualStyleBackColor = true;
            this.buttonInsConfirmar.Click += new System.EventHandler(this.buttonInsConfirmar_Click);
            // 
            // buttonInsCancelar
            // 
            this.buttonInsCancelar.Location = new System.Drawing.Point(600, 381);
            this.buttonInsCancelar.Name = "buttonInsCancelar";
            this.buttonInsCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsCancelar.TabIndex = 6;
            this.buttonInsCancelar.Text = "Cancelar";
            this.buttonInsCancelar.UseVisualStyleBackColor = true;
            this.buttonInsCancelar.Click += new System.EventHandler(this.buttonInsCancelar_Click);
            // 
            // FormInscripcionComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsCancelar);
            this.Controls.Add(this.buttonInsConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.listBoxInsSocCom);
            this.Controls.Add(this.listBoxInsSocAct);
            this.Name = "FormInscripcionComision";
            this.Text = "Inscripcion a comision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInsSocAct;
        private System.Windows.Forms.ListBox listBoxInsSocCom;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsConfirmar;
        private System.Windows.Forms.Button buttonInsCancelar;
    }
}