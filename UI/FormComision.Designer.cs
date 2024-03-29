﻿namespace UI
{
    partial class FormComision
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
            this.textBoxComID = new System.Windows.Forms.TextBox();
            this.labelComHorario = new System.Windows.Forms.Label();
            this.labelComDescripcion = new System.Windows.Forms.Label();
            this.labelComID = new System.Windows.Forms.Label();
            this.labelComProfesor = new System.Windows.Forms.Label();
            this.listBoxComSocios = new System.Windows.Forms.ListBox();
            this.labelComSocios = new System.Windows.Forms.Label();
            this.buttonComModif = new System.Windows.Forms.Button();
            this.buttonComCancelar = new System.Windows.Forms.Button();
            this.buttonComCrear = new System.Windows.Forms.Button();
            this.buttonComAceptar = new System.Windows.Forms.Button();
            this.textBoxComMaxPar = new System.Windows.Forms.TextBox();
            this.labelComMaxPar = new System.Windows.Forms.Label();
            this.comboBoxComProfesores = new System.Windows.Forms.ComboBox();
            this.comboBoxComDia = new System.Windows.Forms.ComboBox();
            this.comboBoxComHorario = new System.Windows.Forms.ComboBox();
            this.comboBoxComAct = new System.Windows.Forms.ComboBox();
            this.labelComAct = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxComID
            // 
            this.textBoxComID.Location = new System.Drawing.Point(21, 35);
            this.textBoxComID.Name = "textBoxComID";
            this.textBoxComID.Size = new System.Drawing.Size(100, 20);
            this.textBoxComID.TabIndex = 16;
            this.textBoxComID.TextChanged += new System.EventHandler(this.textBoxComID_TextChanged);
            // 
            // labelComHorario
            // 
            this.labelComHorario.AutoSize = true;
            this.labelComHorario.Location = new System.Drawing.Point(18, 178);
            this.labelComHorario.Name = "labelComHorario";
            this.labelComHorario.Size = new System.Drawing.Size(41, 13);
            this.labelComHorario.TabIndex = 15;
            this.labelComHorario.Text = "Horario";
            // 
            // labelComDescripcion
            // 
            this.labelComDescripcion.AutoSize = true;
            this.labelComDescripcion.Location = new System.Drawing.Point(18, 125);
            this.labelComDescripcion.Name = "labelComDescripcion";
            this.labelComDescripcion.Size = new System.Drawing.Size(25, 13);
            this.labelComDescripcion.TabIndex = 14;
            this.labelComDescripcion.Text = "Día";
            // 
            // labelComID
            // 
            this.labelComID.AutoSize = true;
            this.labelComID.Location = new System.Drawing.Point(18, 19);
            this.labelComID.Name = "labelComID";
            this.labelComID.Size = new System.Drawing.Size(18, 13);
            this.labelComID.TabIndex = 13;
            this.labelComID.Text = "ID";
            // 
            // labelComProfesor
            // 
            this.labelComProfesor.AutoSize = true;
            this.labelComProfesor.Location = new System.Drawing.Point(18, 231);
            this.labelComProfesor.Name = "labelComProfesor";
            this.labelComProfesor.Size = new System.Drawing.Size(46, 13);
            this.labelComProfesor.TabIndex = 25;
            this.labelComProfesor.Text = "Profesor";
            // 
            // listBoxComSocios
            // 
            this.listBoxComSocios.FormattingEnabled = true;
            this.listBoxComSocios.Location = new System.Drawing.Point(495, 35);
            this.listBoxComSocios.Name = "listBoxComSocios";
            this.listBoxComSocios.Size = new System.Drawing.Size(300, 290);
            this.listBoxComSocios.TabIndex = 27;
            this.listBoxComSocios.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxComSocios_Format);
            // 
            // labelComSocios
            // 
            this.labelComSocios.AutoSize = true;
            this.labelComSocios.Location = new System.Drawing.Point(492, 19);
            this.labelComSocios.Name = "labelComSocios";
            this.labelComSocios.Size = new System.Drawing.Size(39, 13);
            this.labelComSocios.TabIndex = 28;
            this.labelComSocios.Text = "Socios";
            // 
            // buttonComModif
            // 
            this.buttonComModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComModif.Location = new System.Drawing.Point(315, 400);
            this.buttonComModif.Name = "buttonComModif";
            this.buttonComModif.Size = new System.Drawing.Size(75, 23);
            this.buttonComModif.TabIndex = 31;
            this.buttonComModif.Text = "Modificar";
            this.buttonComModif.UseVisualStyleBackColor = true;
            this.buttonComModif.Click += new System.EventHandler(this.buttonComModif_Click);
            // 
            // buttonComCancelar
            // 
            this.buttonComCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComCancelar.Location = new System.Drawing.Point(422, 400);
            this.buttonComCancelar.Name = "buttonComCancelar";
            this.buttonComCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonComCancelar.TabIndex = 30;
            this.buttonComCancelar.Text = "Cancelar";
            this.buttonComCancelar.UseVisualStyleBackColor = true;
            this.buttonComCancelar.Click += new System.EventHandler(this.buttonComCancelar_Click);
            // 
            // buttonComCrear
            // 
            this.buttonComCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComCrear.Location = new System.Drawing.Point(315, 400);
            this.buttonComCrear.Name = "buttonComCrear";
            this.buttonComCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonComCrear.TabIndex = 29;
            this.buttonComCrear.Text = "Crear";
            this.buttonComCrear.UseVisualStyleBackColor = true;
            this.buttonComCrear.Click += new System.EventHandler(this.buttonComCrear_Click);
            // 
            // buttonComAceptar
            // 
            this.buttonComAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComAceptar.Location = new System.Drawing.Point(315, 371);
            this.buttonComAceptar.Name = "buttonComAceptar";
            this.buttonComAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonComAceptar.TabIndex = 32;
            this.buttonComAceptar.Text = "Aceptar";
            this.buttonComAceptar.UseVisualStyleBackColor = true;
            this.buttonComAceptar.Click += new System.EventHandler(this.buttonComAceptar_Click);
            // 
            // textBoxComMaxPar
            // 
            this.textBoxComMaxPar.Location = new System.Drawing.Point(21, 300);
            this.textBoxComMaxPar.Name = "textBoxComMaxPar";
            this.textBoxComMaxPar.Size = new System.Drawing.Size(100, 20);
            this.textBoxComMaxPar.TabIndex = 34;
            this.textBoxComMaxPar.TextChanged += new System.EventHandler(this.textBoxComMaxPar_TextChanged);
            this.textBoxComMaxPar.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxComMaxPar_Validating);
            this.textBoxComMaxPar.Validated += new System.EventHandler(this.textBoxComMaxPar_Validated);
            // 
            // labelComMaxPar
            // 
            this.labelComMaxPar.AutoSize = true;
            this.labelComMaxPar.Location = new System.Drawing.Point(18, 284);
            this.labelComMaxPar.Name = "labelComMaxPar";
            this.labelComMaxPar.Size = new System.Drawing.Size(150, 13);
            this.labelComMaxPar.TabIndex = 33;
            this.labelComMaxPar.Text = "Cantidad máxima participantes";
            // 
            // comboBoxComProfesores
            // 
            this.comboBoxComProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComProfesores.FormattingEnabled = true;
            this.comboBoxComProfesores.Location = new System.Drawing.Point(21, 247);
            this.comboBoxComProfesores.Name = "comboBoxComProfesores";
            this.comboBoxComProfesores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComProfesores.TabIndex = 35;
            this.comboBoxComProfesores.SelectedIndexChanged += new System.EventHandler(this.comboBoxComProfesores_SelectedIndexChanged);
            // 
            // comboBoxComDia
            // 
            this.comboBoxComDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComDia.FormattingEnabled = true;
            this.comboBoxComDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboBoxComDia.Location = new System.Drawing.Point(21, 141);
            this.comboBoxComDia.Name = "comboBoxComDia";
            this.comboBoxComDia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComDia.TabIndex = 36;
            this.comboBoxComDia.SelectedIndexChanged += new System.EventHandler(this.comboBoxComDia_SelectedIndexChanged);
            // 
            // comboBoxComHorario
            // 
            this.comboBoxComHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComHorario.FormattingEnabled = true;
            this.comboBoxComHorario.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18"});
            this.comboBoxComHorario.Location = new System.Drawing.Point(21, 194);
            this.comboBoxComHorario.Name = "comboBoxComHorario";
            this.comboBoxComHorario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComHorario.TabIndex = 38;
            this.comboBoxComHorario.SelectedIndexChanged += new System.EventHandler(this.comboBoxComHorario_SelectedIndexChanged);
            // 
            // comboBoxComAct
            // 
            this.comboBoxComAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComAct.FormattingEnabled = true;
            this.comboBoxComAct.Location = new System.Drawing.Point(21, 88);
            this.comboBoxComAct.Name = "comboBoxComAct";
            this.comboBoxComAct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComAct.TabIndex = 40;
            this.comboBoxComAct.SelectedIndexChanged += new System.EventHandler(this.comboBoxComAct_SelectedIndexChanged);
            // 
            // labelComAct
            // 
            this.labelComAct.AutoSize = true;
            this.labelComAct.Location = new System.Drawing.Point(18, 72);
            this.labelComAct.Name = "labelComAct";
            this.labelComAct.Size = new System.Drawing.Size(51, 13);
            this.labelComAct.TabIndex = 39;
            this.labelComAct.Text = "Actividad";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxComAct);
            this.Controls.Add(this.labelComAct);
            this.Controls.Add(this.comboBoxComHorario);
            this.Controls.Add(this.comboBoxComDia);
            this.Controls.Add(this.comboBoxComProfesores);
            this.Controls.Add(this.textBoxComMaxPar);
            this.Controls.Add(this.labelComMaxPar);
            this.Controls.Add(this.buttonComAceptar);
            this.Controls.Add(this.buttonComModif);
            this.Controls.Add(this.buttonComCancelar);
            this.Controls.Add(this.buttonComCrear);
            this.Controls.Add(this.labelComSocios);
            this.Controls.Add(this.listBoxComSocios);
            this.Controls.Add(this.labelComProfesor);
            this.Controls.Add(this.textBoxComID);
            this.Controls.Add(this.labelComHorario);
            this.Controls.Add(this.labelComDescripcion);
            this.Controls.Add(this.labelComID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comision";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxComID;
        private System.Windows.Forms.Label labelComHorario;
        private System.Windows.Forms.Label labelComDescripcion;
        private System.Windows.Forms.Label labelComID;
        private System.Windows.Forms.Label labelComProfesor;
        private System.Windows.Forms.ListBox listBoxComSocios;
        private System.Windows.Forms.Label labelComSocios;
        private System.Windows.Forms.Button buttonComModif;
        private System.Windows.Forms.Button buttonComCancelar;
        private System.Windows.Forms.Button buttonComCrear;
        private System.Windows.Forms.Button buttonComAceptar;
        private System.Windows.Forms.TextBox textBoxComMaxPar;
        private System.Windows.Forms.Label labelComMaxPar;
        private System.Windows.Forms.ComboBox comboBoxComProfesores;
        private System.Windows.Forms.ComboBox comboBoxComDia;
        private System.Windows.Forms.ComboBox comboBoxComHorario;
        private System.Windows.Forms.ComboBox comboBoxComAct;
        private System.Windows.Forms.Label labelComAct;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}