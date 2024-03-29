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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCrearActividad = new System.Windows.Forms.Button();
            this.buttonModificarActividad = new System.Windows.Forms.Button();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.buttonInsSocAct = new System.Windows.Forms.Button();
            this.buttonElimSocAct = new System.Windows.Forms.Button();
            this.buttonRegPagoSoc = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMostrarActividad = new System.Windows.Forms.Button();
            this.listBoxAct = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonMostrarComision = new System.Windows.Forms.Button();
            this.buttonModifComision = new System.Windows.Forms.Button();
            this.buttonElimCom = new System.Windows.Forms.Button();
            this.buttonCrearComision = new System.Windows.Forms.Button();
            this.listBoxCom = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxProf = new System.Windows.Forms.ListBox();
            this.buttonMostrarProf = new System.Windows.Forms.Button();
            this.buttonCrearProf = new System.Windows.Forms.Button();
            this.buttonModifProf = new System.Windows.Forms.Button();
            this.buttonElimProf = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMostrarSocio = new System.Windows.Forms.Button();
            this.buttonCrearSocio = new System.Windows.Forms.Button();
            this.buttonModifSocio = new System.Windows.Forms.Button();
            this.buttonElimSocio = new System.Windows.Forms.Button();
            this.listBoxSocios = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearActividad
            // 
            this.buttonCrearActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearActividad.Location = new System.Drawing.Point(31, 43);
            this.buttonCrearActividad.Name = "buttonCrearActividad";
            this.buttonCrearActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonCrearActividad.TabIndex = 0;
            this.buttonCrearActividad.Text = "Crear";
            this.buttonCrearActividad.UseVisualStyleBackColor = true;
            this.buttonCrearActividad.Click += new System.EventHandler(this.buttonCrearActividad_Click);
            // 
            // buttonModificarActividad
            // 
            this.buttonModificarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificarActividad.Location = new System.Drawing.Point(31, 72);
            this.buttonModificarActividad.Name = "buttonModificarActividad";
            this.buttonModificarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonModificarActividad.TabIndex = 1;
            this.buttonModificarActividad.Text = "Modificar";
            this.buttonModificarActividad.UseVisualStyleBackColor = true;
            this.buttonModificarActividad.Click += new System.EventHandler(this.buttonModificarActividad_Click);
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarActividad.Location = new System.Drawing.Point(31, 101);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonEliminarActividad.TabIndex = 2;
            this.buttonEliminarActividad.Text = "Eliminar";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            this.buttonEliminarActividad.Click += new System.EventHandler(this.buttonEliminarActividad_Click);
            // 
            // buttonInsSocAct
            // 
            this.buttonInsSocAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsSocAct.Location = new System.Drawing.Point(31, 300);
            this.buttonInsSocAct.Name = "buttonInsSocAct";
            this.buttonInsSocAct.Size = new System.Drawing.Size(248, 23);
            this.buttonInsSocAct.TabIndex = 3;
            this.buttonInsSocAct.Text = "Inscribir socio a actividad deportiva";
            this.buttonInsSocAct.UseVisualStyleBackColor = true;
            this.buttonInsSocAct.Click += new System.EventHandler(this.buttonInsSocAct_Click);
            // 
            // buttonElimSocAct
            // 
            this.buttonElimSocAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimSocAct.Location = new System.Drawing.Point(31, 329);
            this.buttonElimSocAct.Name = "buttonElimSocAct";
            this.buttonElimSocAct.Size = new System.Drawing.Size(248, 23);
            this.buttonElimSocAct.TabIndex = 4;
            this.buttonElimSocAct.Text = "Eliminar socio de una actividad deportiva";
            this.buttonElimSocAct.UseVisualStyleBackColor = true;
            this.buttonElimSocAct.Click += new System.EventHandler(this.buttonElimSocAct_Click);
            // 
            // buttonRegPagoSoc
            // 
            this.buttonRegPagoSoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegPagoSoc.Location = new System.Drawing.Point(31, 358);
            this.buttonRegPagoSoc.Name = "buttonRegPagoSoc";
            this.buttonRegPagoSoc.Size = new System.Drawing.Size(248, 23);
            this.buttonRegPagoSoc.TabIndex = 5;
            this.buttonRegPagoSoc.Text = "Registrar el pago de un socio";
            this.buttonRegPagoSoc.UseVisualStyleBackColor = true;
            this.buttonRegPagoSoc.Click += new System.EventHandler(this.buttonRegPagoSoc_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(-2, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 453);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            // buttonMostrarActividad
            // 
            this.buttonMostrarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarActividad.Location = new System.Drawing.Point(31, 130);
            this.buttonMostrarActividad.Name = "buttonMostrarActividad";
            this.buttonMostrarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonMostrarActividad.TabIndex = 4;
            this.buttonMostrarActividad.Text = "Mostrar";
            this.buttonMostrarActividad.UseVisualStyleBackColor = true;
            this.buttonMostrarActividad.Click += new System.EventHandler(this.buttonMostrarActividad_Click);
            // 
            // listBoxAct
            // 
            this.listBoxAct.FormattingEnabled = true;
            this.listBoxAct.Location = new System.Drawing.Point(484, 3);
            this.listBoxAct.Name = "listBoxAct";
            this.listBoxAct.Size = new System.Drawing.Size(308, 420);
            this.listBoxAct.TabIndex = 3;
            this.listBoxAct.SelectedIndexChanged += new System.EventHandler(this.listBoxAct_SelectedIndexChanged);
            this.listBoxAct.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxAct_Format);
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage4.Controls.Add(this.buttonMostrarComision);
            this.tabPage4.Controls.Add(this.buttonModifComision);
            this.tabPage4.Controls.Add(this.buttonElimCom);
            this.tabPage4.Controls.Add(this.buttonCrearComision);
            this.tabPage4.Controls.Add(this.listBoxCom);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(795, 427);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Comisiones";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarComision
            // 
            this.buttonMostrarComision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarComision.Location = new System.Drawing.Point(31, 130);
            this.buttonMostrarComision.Name = "buttonMostrarComision";
            this.buttonMostrarComision.Size = new System.Drawing.Size(140, 23);
            this.buttonMostrarComision.TabIndex = 24;
            this.buttonMostrarComision.Text = "Mostrar";
            this.buttonMostrarComision.UseVisualStyleBackColor = true;
            this.buttonMostrarComision.Click += new System.EventHandler(this.buttonMostrarComision_Click);
            // 
            // buttonModifComision
            // 
            this.buttonModifComision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifComision.Location = new System.Drawing.Point(31, 72);
            this.buttonModifComision.Name = "buttonModifComision";
            this.buttonModifComision.Size = new System.Drawing.Size(140, 23);
            this.buttonModifComision.TabIndex = 23;
            this.buttonModifComision.Text = "Modificar";
            this.buttonModifComision.UseVisualStyleBackColor = true;
            this.buttonModifComision.Click += new System.EventHandler(this.buttonModifComision_Click);
            // 
            // buttonElimCom
            // 
            this.buttonElimCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimCom.Location = new System.Drawing.Point(31, 101);
            this.buttonElimCom.Name = "buttonElimCom";
            this.buttonElimCom.Size = new System.Drawing.Size(140, 23);
            this.buttonElimCom.TabIndex = 22;
            this.buttonElimCom.Text = "Eliminar";
            this.buttonElimCom.UseVisualStyleBackColor = true;
            this.buttonElimCom.Click += new System.EventHandler(this.buttonElimCom_Click);
            // 
            // buttonCrearComision
            // 
            this.buttonCrearComision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearComision.Location = new System.Drawing.Point(31, 43);
            this.buttonCrearComision.Name = "buttonCrearComision";
            this.buttonCrearComision.Size = new System.Drawing.Size(140, 23);
            this.buttonCrearComision.TabIndex = 21;
            this.buttonCrearComision.Text = "Crear";
            this.buttonCrearComision.UseVisualStyleBackColor = true;
            this.buttonCrearComision.Click += new System.EventHandler(this.buttonCrearComision_Click);
            // 
            // listBoxCom
            // 
            this.listBoxCom.FormattingEnabled = true;
            this.listBoxCom.Location = new System.Drawing.Point(484, 3);
            this.listBoxCom.Name = "listBoxCom";
            this.listBoxCom.Size = new System.Drawing.Size(308, 420);
            this.listBoxCom.TabIndex = 19;
            this.listBoxCom.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxCom_Format);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxProf);
            this.tabPage3.Controls.Add(this.buttonMostrarProf);
            this.tabPage3.Controls.Add(this.buttonCrearProf);
            this.tabPage3.Controls.Add(this.buttonModifProf);
            this.tabPage3.Controls.Add(this.buttonElimProf);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profesores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxProf
            // 
            this.listBoxProf.FormattingEnabled = true;
            this.listBoxProf.Location = new System.Drawing.Point(484, 3);
            this.listBoxProf.Name = "listBoxProf";
            this.listBoxProf.Size = new System.Drawing.Size(308, 420);
            this.listBoxProf.TabIndex = 9;
            this.listBoxProf.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxProf_Format);
            // 
            // buttonMostrarProf
            // 
            this.buttonMostrarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarProf.Location = new System.Drawing.Point(31, 130);
            this.buttonMostrarProf.Name = "buttonMostrarProf";
            this.buttonMostrarProf.Size = new System.Drawing.Size(140, 23);
            this.buttonMostrarProf.TabIndex = 8;
            this.buttonMostrarProf.Text = "Mostrar";
            this.buttonMostrarProf.UseVisualStyleBackColor = true;
            this.buttonMostrarProf.Click += new System.EventHandler(this.buttonMostrarProf_Click);
            // 
            // buttonCrearProf
            // 
            this.buttonCrearProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearProf.Location = new System.Drawing.Point(31, 43);
            this.buttonCrearProf.Name = "buttonCrearProf";
            this.buttonCrearProf.Size = new System.Drawing.Size(140, 23);
            this.buttonCrearProf.TabIndex = 5;
            this.buttonCrearProf.Text = "Crear";
            this.buttonCrearProf.UseVisualStyleBackColor = true;
            this.buttonCrearProf.Click += new System.EventHandler(this.buttonCrearProf_Click);
            // 
            // buttonModifProf
            // 
            this.buttonModifProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifProf.Location = new System.Drawing.Point(31, 72);
            this.buttonModifProf.Name = "buttonModifProf";
            this.buttonModifProf.Size = new System.Drawing.Size(140, 23);
            this.buttonModifProf.TabIndex = 6;
            this.buttonModifProf.Text = "Modificar";
            this.buttonModifProf.UseVisualStyleBackColor = true;
            this.buttonModifProf.Click += new System.EventHandler(this.buttonModifProf_Click);
            // 
            // buttonElimProf
            // 
            this.buttonElimProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimProf.Location = new System.Drawing.Point(31, 101);
            this.buttonElimProf.Name = "buttonElimProf";
            this.buttonElimProf.Size = new System.Drawing.Size(140, 23);
            this.buttonElimProf.TabIndex = 7;
            this.buttonElimProf.Text = "Eliminar";
            this.buttonElimProf.UseVisualStyleBackColor = true;
            this.buttonElimProf.Click += new System.EventHandler(this.buttonElimProf_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonMostrarSocio);
            this.tabPage2.Controls.Add(this.buttonCrearSocio);
            this.tabPage2.Controls.Add(this.buttonModifSocio);
            this.tabPage2.Controls.Add(this.buttonElimSocio);
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
            // buttonMostrarSocio
            // 
            this.buttonMostrarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostrarSocio.Location = new System.Drawing.Point(31, 130);
            this.buttonMostrarSocio.Name = "buttonMostrarSocio";
            this.buttonMostrarSocio.Size = new System.Drawing.Size(140, 23);
            this.buttonMostrarSocio.TabIndex = 10;
            this.buttonMostrarSocio.Text = "Mostrar";
            this.buttonMostrarSocio.UseVisualStyleBackColor = true;
            this.buttonMostrarSocio.Click += new System.EventHandler(this.buttonMostrarSocio_Click);
            // 
            // buttonCrearSocio
            // 
            this.buttonCrearSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearSocio.Location = new System.Drawing.Point(31, 43);
            this.buttonCrearSocio.Name = "buttonCrearSocio";
            this.buttonCrearSocio.Size = new System.Drawing.Size(140, 23);
            this.buttonCrearSocio.TabIndex = 7;
            this.buttonCrearSocio.Text = "Crear";
            this.buttonCrearSocio.UseVisualStyleBackColor = true;
            this.buttonCrearSocio.Click += new System.EventHandler(this.buttonCrearSocio_Click);
            // 
            // buttonModifSocio
            // 
            this.buttonModifSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifSocio.Location = new System.Drawing.Point(31, 72);
            this.buttonModifSocio.Name = "buttonModifSocio";
            this.buttonModifSocio.Size = new System.Drawing.Size(140, 23);
            this.buttonModifSocio.TabIndex = 8;
            this.buttonModifSocio.Text = "Modificar";
            this.buttonModifSocio.UseVisualStyleBackColor = true;
            this.buttonModifSocio.Click += new System.EventHandler(this.buttonModifSocio_Click);
            // 
            // buttonElimSocio
            // 
            this.buttonElimSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElimSocio.Location = new System.Drawing.Point(31, 101);
            this.buttonElimSocio.Name = "buttonElimSocio";
            this.buttonElimSocio.Size = new System.Drawing.Size(140, 23);
            this.buttonElimSocio.TabIndex = 9;
            this.buttonElimSocio.Text = "Eliminar";
            this.buttonElimSocio.UseVisualStyleBackColor = true;
            this.buttonElimSocio.Click += new System.EventHandler(this.buttonElimSocio_Click);
            // 
            // listBoxSocios
            // 
            this.listBoxSocios.FormattingEnabled = true;
            this.listBoxSocios.Location = new System.Drawing.Point(484, 3);
            this.listBoxSocios.Name = "listBoxSocios";
            this.listBoxSocios.Size = new System.Drawing.Size(308, 420);
            this.listBoxSocios.TabIndex = 6;
            this.listBoxSocios.SelectedIndexChanged += new System.EventHandler(this.listBoxSocios_SelectedIndexChanged);
            this.listBoxSocios.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxSocios_Format);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewPagos);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(795, 427);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pagos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.AllowUserToAddRows = false;
            this.dataGridViewPagos.AllowUserToDeleteRows = false;
            this.dataGridViewPagos.AllowUserToResizeColumns = false;
            this.dataGridViewPagos.AllowUserToResizeRows = false;
            this.dataGridViewPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPagos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPagos.Enabled = false;
            this.dataGridViewPagos.Location = new System.Drawing.Point(10, 13);
            this.dataGridViewPagos.MinimumSize = new System.Drawing.Size(10, 10);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.ReadOnly = true;
            this.dataGridViewPagos.RowHeadersVisible = false;
            this.dataGridViewPagos.Size = new System.Drawing.Size(776, 394);
            this.dataGridViewPagos.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
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
        private System.Windows.Forms.Button buttonMostrarActividad;
        private System.Windows.Forms.Button buttonMostrarProf;
        private System.Windows.Forms.Button buttonCrearProf;
        private System.Windows.Forms.Button buttonModifProf;
        private System.Windows.Forms.Button buttonElimProf;
        private System.Windows.Forms.ListBox listBoxProf;
        private System.Windows.Forms.Button buttonMostrarSocio;
        private System.Windows.Forms.Button buttonCrearSocio;
        private System.Windows.Forms.Button buttonModifSocio;
        private System.Windows.Forms.Button buttonElimSocio;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonMostrarComision;
        private System.Windows.Forms.Button buttonModifComision;
        private System.Windows.Forms.Button buttonElimCom;
        private System.Windows.Forms.Button buttonCrearComision;
        private System.Windows.Forms.ListBox listBoxCom;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewPagos;
    }
}

