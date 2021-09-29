
namespace DistribuidoraBebidas.Formularios
{
    partial class AgregarBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarBebida));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.TbxNameBebida = new System.Windows.Forms.TextBox();
            this.tbxMililitros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RestarStockBebida = new System.Windows.Forms.Button();
            this.AgregarStockDGV = new System.Windows.Forms.DataGridView();
            this.NombreBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarStockBebida = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarStockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 29);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 47);
            this.panel2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(305, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agregar o Modificar Bebidas";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Location = new System.Drawing.Point(789, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 37);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(101, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Agregar Bebida";
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCantidad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCantidad.Location = new System.Drawing.Point(26, 160);
            this.tbxCantidad.Multiline = true;
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(298, 39);
            this.tbxCantidad.TabIndex = 3;
            // 
            // TbxNameBebida
            // 
            this.TbxNameBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNameBebida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxNameBebida.Location = new System.Drawing.Point(21, 78);
            this.TbxNameBebida.Multiline = true;
            this.TbxNameBebida.Name = "TbxNameBebida";
            this.TbxNameBebida.Size = new System.Drawing.Size(303, 41);
            this.TbxNameBebida.TabIndex = 3;
            // 
            // tbxMililitros
            // 
            this.tbxMililitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMililitros.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMililitros.Location = new System.Drawing.Point(26, 243);
            this.tbxMililitros.Multiline = true;
            this.tbxMililitros.Name = "tbxMililitros";
            this.tbxMililitros.Size = new System.Drawing.Size(298, 40);
            this.tbxMililitros.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(21, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Precio";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrecio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrecio.Location = new System.Drawing.Point(26, 326);
            this.tbxPrecio.Multiline = true;
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(298, 41);
            this.tbxPrecio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mililitros";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbxPrecio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbxMililitros);
            this.panel3.Controls.Add(this.TbxNameBebida);
            this.panel3.Controls.Add(this.tbxCantidad);
            this.panel3.Location = new System.Drawing.Point(49, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 444);
            this.panel3.TabIndex = 8;
            // 
            // RestarStockBebida
            // 
            this.RestarStockBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestarStockBebida.BackColor = System.Drawing.Color.Transparent;
            this.RestarStockBebida.Image = ((System.Drawing.Image)(resources.GetObject("RestarStockBebida.Image")));
            this.RestarStockBebida.Location = new System.Drawing.Point(789, 167);
            this.RestarStockBebida.Name = "RestarStockBebida";
            this.RestarStockBebida.Size = new System.Drawing.Size(55, 53);
            this.RestarStockBebida.TabIndex = 1;
            this.RestarStockBebida.UseVisualStyleBackColor = false;
            this.RestarStockBebida.Click += new System.EventHandler(this.RestarStockBebida_Click);
            // 
            // AgregarStockDGV
            // 
            this.AgregarStockDGV.AllowUserToResizeColumns = false;
            this.AgregarStockDGV.AllowUserToResizeRows = false;
            this.AgregarStockDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarStockDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgregarStockDGV.BackgroundColor = System.Drawing.Color.White;
            this.AgregarStockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgregarStockDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBebida,
            this.Cantidad});
            this.AgregarStockDGV.Location = new System.Drawing.Point(474, 91);
            this.AgregarStockDGV.Name = "AgregarStockDGV";
            this.AgregarStockDGV.RowTemplate.Height = 25;
            this.AgregarStockDGV.Size = new System.Drawing.Size(310, 367);
            this.AgregarStockDGV.TabIndex = 0;
            this.AgregarStockDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgregarStockDGV_CellClick);
            // 
            // NombreBebida
            // 
            this.NombreBebida.HeaderText = "Bebidas";
            this.NombreBebida.Name = "NombreBebida";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // AgregarStockBebida
            // 
            this.AgregarStockBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarStockBebida.BackColor = System.Drawing.Color.Transparent;
            this.AgregarStockBebida.Image = ((System.Drawing.Image)(resources.GetObject("AgregarStockBebida.Image")));
            this.AgregarStockBebida.Location = new System.Drawing.Point(789, 91);
            this.AgregarStockBebida.Name = "AgregarStockBebida";
            this.AgregarStockBebida.Size = new System.Drawing.Size(55, 49);
            this.AgregarStockBebida.TabIndex = 1;
            this.AgregarStockBebida.UseVisualStyleBackColor = false;
            this.AgregarStockBebida.Click += new System.EventHandler(this.AgregarStockBebida_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Enabled = true;
            // 
            // AgregarBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(857, 532);
            this.Controls.Add(this.AgregarStockDGV);
            this.Controls.Add(this.AgregarStockBebida);
            this.Controls.Add(this.RestarStockBebida);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarBebida";
            this.Text = "AgregarBebida";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarStockDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.TextBox TbxNameBebida;
        private System.Windows.Forms.TextBox tbxMililitros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RestarStockBebida;
        private System.Windows.Forms.DataGridView AgregarStockDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button AgregarStockBebida;
        private System.Windows.Forms.Timer Actualizar;
    }
}