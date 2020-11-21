namespace TuGestor
{
    partial class FormEnvios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnvios));
            this.btn_CerrarL = new System.Windows.Forms.Button();
            this.dataGridViewEnvio = new System.Windows.Forms.DataGridView();
            this.dataGridViewEnvioOrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BuscarDpto = new System.Windows.Forms.Button();
            this.comboBoxEnvios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvioOrd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CerrarL
            // 
            this.btn_CerrarL.Location = new System.Drawing.Point(775, 393);
            this.btn_CerrarL.Name = "btn_CerrarL";
            this.btn_CerrarL.Size = new System.Drawing.Size(85, 45);
            this.btn_CerrarL.TabIndex = 1;
            this.btn_CerrarL.Text = "Cerrar";
            this.btn_CerrarL.UseVisualStyleBackColor = true;
            this.btn_CerrarL.Click += new System.EventHandler(this.btn_CerrarL_Click);
            // 
            // dataGridViewEnvio
            // 
            this.dataGridViewEnvio.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridViewEnvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvio.Location = new System.Drawing.Point(0, 52);
            this.dataGridViewEnvio.Name = "dataGridViewEnvio";
            this.dataGridViewEnvio.Size = new System.Drawing.Size(426, 239);
            this.dataGridViewEnvio.TabIndex = 2;
            // 
            // dataGridViewEnvioOrd
            // 
            this.dataGridViewEnvioOrd.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewEnvioOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvioOrd.Location = new System.Drawing.Point(432, 52);
            this.dataGridViewEnvioOrd.Name = "dataGridViewEnvioOrd";
            this.dataGridViewEnvioOrd.Size = new System.Drawing.Size(428, 239);
            this.dataGridViewEnvioOrd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "TODOS LOS ENVIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(432, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "ORDENADOS POR DEPARTAMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(478, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtrar por:";
            // 
            // btn_BuscarDpto
            // 
            this.btn_BuscarDpto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BuscarDpto.Location = new System.Drawing.Point(482, 355);
            this.btn_BuscarDpto.Name = "btn_BuscarDpto";
            this.btn_BuscarDpto.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarDpto.TabIndex = 17;
            this.btn_BuscarDpto.Text = "Buscar";
            this.btn_BuscarDpto.UseVisualStyleBackColor = true;
            this.btn_BuscarDpto.Click += new System.EventHandler(this.btn_BuscarDpto_Click);
            // 
            // comboBoxEnvios
            // 
            this.comboBoxEnvios.FormattingEnabled = true;
            this.comboBoxEnvios.Items.AddRange(new object[] {
            "Guaymallen",
            "Las Heras",
            "San Rafael",
            "Capital",
            "Maipu",
            "Lujan",
            "No especificado",
            "Envio a domicilio",
            "Retiro en local"});
            this.comboBoxEnvios.Location = new System.Drawing.Point(446, 328);
            this.comboBoxEnvios.Name = "comboBoxEnvios";
            this.comboBoxEnvios.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEnvios.TabIndex = 26;
            this.comboBoxEnvios.Text = "Seleccione Departamento";
            // 
            // FormEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 440);
            this.Controls.Add(this.comboBoxEnvios);
            this.Controls.Add(this.btn_BuscarDpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEnvioOrd);
            this.Controls.Add(this.dataGridViewEnvio);
            this.Controls.Add(this.btn_CerrarL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnvios";
            this.Text = "Envios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvioOrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CerrarL;
        private System.Windows.Forms.DataGridView dataGridViewEnvio;
        private System.Windows.Forms.DataGridView dataGridViewEnvioOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BuscarDpto;
        private System.Windows.Forms.ComboBox comboBoxEnvios;
    }
}