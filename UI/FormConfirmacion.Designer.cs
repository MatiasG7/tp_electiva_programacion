namespace UI
{
    partial class FormConfirmacion
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
            this.buttonConfirmacion1 = new System.Windows.Forms.Button();
            this.buttonConfirmacion2 = new System.Windows.Forms.Button();
            this.buttonConfirmacion3 = new System.Windows.Forms.Button();
            this.labelConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirmacion1
            // 
            this.buttonConfirmacion1.Location = new System.Drawing.Point(20, 73);
            this.buttonConfirmacion1.Name = "buttonConfirmacion1";
            this.buttonConfirmacion1.Size = new System.Drawing.Size(84, 25);
            this.buttonConfirmacion1.TabIndex = 0;
            this.buttonConfirmacion1.Text = "button1";
            this.buttonConfirmacion1.UseVisualStyleBackColor = true;
            this.buttonConfirmacion1.Click += new System.EventHandler(this.buttonConfirmacion1_Click);
            // 
            // buttonConfirmacion2
            // 
            this.buttonConfirmacion2.Location = new System.Drawing.Point(110, 73);
            this.buttonConfirmacion2.Name = "buttonConfirmacion2";
            this.buttonConfirmacion2.Size = new System.Drawing.Size(84, 25);
            this.buttonConfirmacion2.TabIndex = 1;
            this.buttonConfirmacion2.Text = "button2";
            this.buttonConfirmacion2.UseVisualStyleBackColor = true;
            this.buttonConfirmacion2.Click += new System.EventHandler(this.buttonConfirmacion2_Click);
            // 
            // buttonConfirmacion3
            // 
            this.buttonConfirmacion3.Location = new System.Drawing.Point(200, 73);
            this.buttonConfirmacion3.Name = "buttonConfirmacion3";
            this.buttonConfirmacion3.Size = new System.Drawing.Size(84, 25);
            this.buttonConfirmacion3.TabIndex = 2;
            this.buttonConfirmacion3.Text = "button3";
            this.buttonConfirmacion3.UseVisualStyleBackColor = true;
            this.buttonConfirmacion3.Click += new System.EventHandler(this.buttonConfirmacion3_Click);
            // 
            // labelConfirmacion
            // 
            this.labelConfirmacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelConfirmacion.Location = new System.Drawing.Point(0, 0);
            this.labelConfirmacion.Name = "labelConfirmacion";
            this.labelConfirmacion.Size = new System.Drawing.Size(306, 70);
            this.labelConfirmacion.TabIndex = 3;
            this.labelConfirmacion.Text = "labelConfirmacion";
            this.labelConfirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 108);
            this.Controls.Add(this.labelConfirmacion);
            this.Controls.Add(this.buttonConfirmacion3);
            this.Controls.Add(this.buttonConfirmacion2);
            this.Controls.Add(this.buttonConfirmacion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfirmacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmacion1;
        private System.Windows.Forms.Button buttonConfirmacion2;
        private System.Windows.Forms.Button buttonConfirmacion3;
        private System.Windows.Forms.Label labelConfirmacion;
    }
}