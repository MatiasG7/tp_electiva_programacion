﻿namespace UI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCrearActividad = new System.Windows.Forms.Button();
            this.buttonModificarActividad = new System.Windows.Forms.Button();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.buttonInsSocAct = new System.Windows.Forms.Button();
            this.buttonElimSocAct = new System.Windows.Forms.Button();
            this.buttonRegPagoSoc = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxAct = new System.Windows.Forms.ListBox();
            this.listBoxSocios = new System.Windows.Forms.ListBox();
            this.buttonMostrarActividad = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrearActividad
            // 
            this.buttonCrearActividad.Location = new System.Drawing.Point(15, 15);
            this.buttonCrearActividad.Name = "buttonCrearActividad";
            this.buttonCrearActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonCrearActividad.TabIndex = 0;
            this.buttonCrearActividad.Text = "Crear Actividad";
            this.buttonCrearActividad.UseVisualStyleBackColor = true;
            this.buttonCrearActividad.Click += new System.EventHandler(this.buttonCrearActividad_Click);
            // 
            // buttonModificarActividad
            // 
            this.buttonModificarActividad.Location = new System.Drawing.Point(15, 44);
            this.buttonModificarActividad.Name = "buttonModificarActividad";
            this.buttonModificarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonModificarActividad.TabIndex = 1;
            this.buttonModificarActividad.Text = "Modificar Actividad";
            this.buttonModificarActividad.UseVisualStyleBackColor = true;
            this.buttonModificarActividad.Click += new System.EventHandler(this.buttonModificarActividad_Click);
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.Location = new System.Drawing.Point(15, 73);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonEliminarActividad.TabIndex = 2;
            this.buttonEliminarActividad.Text = "Eliminar Actividad";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            this.buttonEliminarActividad.Click += new System.EventHandler(this.buttonEliminarActividad_Click);
            // 
            // buttonInsSocAct
            // 
            this.buttonInsSocAct.Location = new System.Drawing.Point(16, 20);
            this.buttonInsSocAct.Name = "buttonInsSocAct";
            this.buttonInsSocAct.Size = new System.Drawing.Size(248, 23);
            this.buttonInsSocAct.TabIndex = 3;
            this.buttonInsSocAct.Text = "Inscribir socio a actividad deportiva";
            this.buttonInsSocAct.UseVisualStyleBackColor = true;
            // 
            // buttonElimSocAct
            // 
            this.buttonElimSocAct.Location = new System.Drawing.Point(16, 63);
            this.buttonElimSocAct.Name = "buttonElimSocAct";
            this.buttonElimSocAct.Size = new System.Drawing.Size(248, 23);
            this.buttonElimSocAct.TabIndex = 4;
            this.buttonElimSocAct.Text = "Eliminar socio de una actividad deportiva";
            this.buttonElimSocAct.UseVisualStyleBackColor = true;
            // 
            // buttonRegPagoSoc
            // 
            this.buttonRegPagoSoc.Location = new System.Drawing.Point(16, 208);
            this.buttonRegPagoSoc.Name = "buttonRegPagoSoc";
            this.buttonRegPagoSoc.Size = new System.Drawing.Size(189, 23);
            this.buttonRegPagoSoc.TabIndex = 5;
            this.buttonRegPagoSoc.Text = "Registrar el pago de un socio";
            this.buttonRegPagoSoc.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(-2, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 453);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMostrarActividad);
            this.tabPage1.Controls.Add(this.listBoxAct);
            this.tabPage1.Controls.Add(this.buttonCrearActividad);
            this.tabPage1.Controls.Add(this.buttonModificarActividad);
            this.tabPage1.Controls.Add(this.buttonEliminarActividad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actividades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxSocios);
            this.tabPage2.Controls.Add(this.buttonInsSocAct);
            this.tabPage2.Controls.Add(this.buttonRegPagoSoc);
            this.tabPage2.Controls.Add(this.buttonElimSocAct);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Socios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(449, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(449, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxAct
            // 
            this.listBoxAct.FormattingEnabled = true;
            this.listBoxAct.Location = new System.Drawing.Point(554, 3);
            this.listBoxAct.Name = "listBoxAct";
            this.listBoxAct.Size = new System.Drawing.Size(238, 420);
            this.listBoxAct.TabIndex = 3;
            // 
            // listBoxSocios
            // 
            this.listBoxSocios.FormattingEnabled = true;
            this.listBoxSocios.Location = new System.Drawing.Point(557, 3);
            this.listBoxSocios.Name = "listBoxSocios";
            this.listBoxSocios.Size = new System.Drawing.Size(235, 420);
            this.listBoxSocios.TabIndex = 6;
            // 
            // buttonMostrarActividad
            // 
            this.buttonMostrarActividad.Location = new System.Drawing.Point(15, 102);
            this.buttonMostrarActividad.Name = "buttonMostrarActividad";
            this.buttonMostrarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonMostrarActividad.TabIndex = 4;
            this.buttonMostrarActividad.Text = "Mostrar Actividad";
            this.buttonMostrarActividad.UseVisualStyleBackColor = true;
            this.buttonMostrarActividad.Click += new System.EventHandler(this.buttonMostrarActividad_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearActividad;
        private System.Windows.Forms.Button buttonModificarActividad;
        private System.Windows.Forms.Button buttonEliminarActividad;
        private System.Windows.Forms.Button buttonInsSocAct;
        private System.Windows.Forms.Button buttonElimSocAct;
        private System.Windows.Forms.Button buttonRegPagoSoc;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxAct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxSocios;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonMostrarActividad;
    }
}
