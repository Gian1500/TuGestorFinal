namespace TuGestor
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.dataGridViewInv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CerrarInv = new System.Windows.Forms.Button();
            this.btn_EliminarInv = new System.Windows.Forms.Button();
            this.btn_AgregarInv = new System.Windows.Forms.Button();
            this.txt_PrecioV = new System.Windows.Forms.TextBox();
            this.txt_PrecioC = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_CodigoProd = new System.Windows.Forms.TextBox();
            this.txt_NombreProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInv
            // 
            this.dataGridViewInv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInv.Location = new System.Drawing.Point(213, 1);
            this.dataGridViewInv.Name = "dataGridViewInv";
            this.dataGridViewInv.Size = new System.Drawing.Size(612, 484);
            this.dataGridViewInv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btn_CerrarInv);
            this.panel1.Controls.Add(this.btn_EliminarInv);
            this.panel1.Controls.Add(this.btn_AgregarInv);
            this.panel1.Controls.Add(this.txt_PrecioV);
            this.panel1.Controls.Add(this.txt_PrecioC);
            this.panel1.Controls.Add(this.txt_Stock);
            this.panel1.Controls.Add(this.txt_CodigoProd);
            this.panel1.Controls.Add(this.txt_NombreProd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 484);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_CerrarInv
            // 
            this.btn_CerrarInv.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_CerrarInv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarInv.Location = new System.Drawing.Point(4, 446);
            this.btn_CerrarInv.Name = "btn_CerrarInv";
            this.btn_CerrarInv.Size = new System.Drawing.Size(197, 31);
            this.btn_CerrarInv.TabIndex = 20;
            this.btn_CerrarInv.Text = "Cerrar";
            this.btn_CerrarInv.UseVisualStyleBackColor = false;
            this.btn_CerrarInv.Click += new System.EventHandler(this.btn_CerrarInv_Click);
            // 
            // btn_EliminarInv
            // 
            this.btn_EliminarInv.BackColor = System.Drawing.Color.IndianRed;
            this.btn_EliminarInv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarInv.Location = new System.Drawing.Point(4, 414);
            this.btn_EliminarInv.Name = "btn_EliminarInv";
            this.btn_EliminarInv.Size = new System.Drawing.Size(197, 31);
            this.btn_EliminarInv.TabIndex = 20;
            this.btn_EliminarInv.Text = "ELIMINAR ◄";
            this.btn_EliminarInv.UseVisualStyleBackColor = false;
            this.btn_EliminarInv.Click += new System.EventHandler(this.btn_EliminarInv_Click);
            // 
            // btn_AgregarInv
            // 
            this.btn_AgregarInv.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_AgregarInv.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AgregarInv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarInv.Location = new System.Drawing.Point(3, 383);
            this.btn_AgregarInv.Name = "btn_AgregarInv";
            this.btn_AgregarInv.Size = new System.Drawing.Size(198, 31);
            this.btn_AgregarInv.TabIndex = 19;
            this.btn_AgregarInv.Text = "AGREGAR ►";
            this.btn_AgregarInv.UseVisualStyleBackColor = false;
            this.btn_AgregarInv.Click += new System.EventHandler(this.btn_AgregarInv_Click);
            // 
            // txt_PrecioV
            // 
            this.txt_PrecioV.Location = new System.Drawing.Point(3, 300);
            this.txt_PrecioV.Name = "txt_PrecioV";
            this.txt_PrecioV.Size = new System.Drawing.Size(203, 20);
            this.txt_PrecioV.TabIndex = 18;
            this.txt_PrecioV.Text = "0";
            this.txt_PrecioV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // txt_PrecioC
            // 
            this.txt_PrecioC.BackColor = System.Drawing.Color.White;
            this.txt_PrecioC.Location = new System.Drawing.Point(4, 240);
            this.txt_PrecioC.Name = "txt_PrecioC";
            this.txt_PrecioC.Size = new System.Drawing.Size(203, 20);
            this.txt_PrecioC.TabIndex = 18;
            this.txt_PrecioC.Text = "0";
            this.txt_PrecioC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PrecioC.TextChanged += new System.EventHandler(this.txt_PrecioU_TextChanged);
            this.txt_PrecioC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(4, 184);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(203, 20);
            this.txt_Stock.TabIndex = 17;
            this.txt_Stock.Text = "0";
            this.txt_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Stock.TextChanged += new System.EventHandler(this.txt_Stock_TextChanged);
            this.txt_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // txt_CodigoProd
            // 
            this.txt_CodigoProd.BackColor = System.Drawing.Color.IndianRed;
            this.txt_CodigoProd.Location = new System.Drawing.Point(4, 126);
            this.txt_CodigoProd.Name = "txt_CodigoProd";
            this.txt_CodigoProd.Size = new System.Drawing.Size(203, 20);
            this.txt_CodigoProd.TabIndex = 16;
            this.txt_CodigoProd.Text = "0";
            this.txt_CodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // txt_NombreProd
            // 
            this.txt_NombreProd.Location = new System.Drawing.Point(4, 71);
            this.txt_NombreProd.Name = "txt_NombreProd";
            this.txt_NombreProd.Size = new System.Drawing.Size(203, 20);
            this.txt_NombreProd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "PANEL DE INVENTARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio de costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stock";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(826, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 524);
            this.MinimumSize = new System.Drawing.Size(842, 524);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CodigoProd;
        private System.Windows.Forms.TextBox txt_NombreProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PrecioV;
        private System.Windows.Forms.TextBox txt_PrecioC;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Button btn_EliminarInv;
        private System.Windows.Forms.Button btn_AgregarInv;
        private System.Windows.Forms.Button btn_CerrarInv;
    }
}