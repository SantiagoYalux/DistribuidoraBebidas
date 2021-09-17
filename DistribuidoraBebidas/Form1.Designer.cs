
namespace DistribuidoraBebidas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hora = new System.Windows.Forms.Label();
            this.PanelBebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clienteBtn = new System.Windows.Forms.Button();
            this.BebidasAlcoholBtn = new System.Windows.Forms.Button();
            this.RegistrosBtn = new System.Windows.Forms.Button();
            this.bebidasBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPagar = new System.Windows.Forms.Label();
            this.AgregarBebida = new System.Windows.Forms.Button();
            this.dollar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hora.Location = new System.Drawing.Point(233, 16);
            this.Hora.Name = "Hora";
            this.Hora.Padding = new System.Windows.Forms.Padding(4);
            this.Hora.Size = new System.Drawing.Size(60, 30);
            this.Hora.TabIndex = 1;
            this.Hora.Text = "label1";
            // 
            // PanelBebidas
            // 
            this.PanelBebidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBebidas.AutoScroll = true;
            this.PanelBebidas.BackColor = System.Drawing.Color.CadetBlue;
            this.PanelBebidas.Location = new System.Drawing.Point(249, 62);
            this.PanelBebidas.Name = "PanelBebidas";
            this.PanelBebidas.Size = new System.Drawing.Size(451, 378);
            this.PanelBebidas.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.clienteBtn);
            this.panel1.Controls.Add(this.BebidasAlcoholBtn);
            this.panel1.Controls.Add(this.RegistrosBtn);
            this.panel1.Controls.Add(this.bebidasBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 530);
            this.panel1.TabIndex = 3;
            // 
            // clienteBtn
            // 
            this.clienteBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clienteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clienteBtn.ForeColor = System.Drawing.Color.White;
            this.clienteBtn.Image = ((System.Drawing.Image)(resources.GetObject("clienteBtn.Image")));
            this.clienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clienteBtn.Location = new System.Drawing.Point(12, 291);
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Size = new System.Drawing.Size(165, 78);
            this.clienteBtn.TabIndex = 4;
            this.clienteBtn.Text = " Carrito Compras";
            this.clienteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clienteBtn.UseVisualStyleBackColor = false;
            this.clienteBtn.Click += new System.EventHandler(this.clienteBtn_Click);
            // 
            // BebidasAlcoholBtn
            // 
            this.BebidasAlcoholBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.BebidasAlcoholBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BebidasAlcoholBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BebidasAlcoholBtn.ForeColor = System.Drawing.Color.White;
            this.BebidasAlcoholBtn.Image = ((System.Drawing.Image)(resources.GetObject("BebidasAlcoholBtn.Image")));
            this.BebidasAlcoholBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BebidasAlcoholBtn.Location = new System.Drawing.Point(12, 189);
            this.BebidasAlcoholBtn.Name = "BebidasAlcoholBtn";
            this.BebidasAlcoholBtn.Size = new System.Drawing.Size(165, 79);
            this.BebidasAlcoholBtn.TabIndex = 4;
            this.BebidasAlcoholBtn.Text = "Con Alcohol";
            this.BebidasAlcoholBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BebidasAlcoholBtn.UseVisualStyleBackColor = false;
            // 
            // RegistrosBtn
            // 
            this.RegistrosBtn.BackColor = System.Drawing.Color.Chocolate;
            this.RegistrosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrosBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrosBtn.ForeColor = System.Drawing.Color.White;
            this.RegistrosBtn.Location = new System.Drawing.Point(0, 444);
            this.RegistrosBtn.Name = "RegistrosBtn";
            this.RegistrosBtn.Size = new System.Drawing.Size(200, 67);
            this.RegistrosBtn.TabIndex = 4;
            this.RegistrosBtn.Text = "Registro Ventas";
            this.RegistrosBtn.UseVisualStyleBackColor = false;
            // 
            // bebidasBtn
            // 
            this.bebidasBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bebidasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bebidasBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.bebidasBtn.FlatAppearance.BorderSize = 3;
            this.bebidasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bebidasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bebidasBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bebidasBtn.ForeColor = System.Drawing.Color.White;
            this.bebidasBtn.Image = ((System.Drawing.Image)(resources.GetObject("bebidasBtn.Image")));
            this.bebidasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bebidasBtn.Location = new System.Drawing.Point(12, 74);
            this.bebidasBtn.Name = "bebidasBtn";
            this.bebidasBtn.Size = new System.Drawing.Size(165, 74);
            this.bebidasBtn.TabIndex = 4;
            this.bebidasBtn.Text = "Sin Alcohol";
            this.bebidasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bebidasBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bebida";
            // 
            // totalPagar
            // 
            this.totalPagar.AutoSize = true;
            this.totalPagar.BackColor = System.Drawing.Color.Transparent;
            this.totalPagar.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPagar.Location = new System.Drawing.Point(261, 483);
            this.totalPagar.Name = "totalPagar";
            this.totalPagar.Size = new System.Drawing.Size(0, 31);
            this.totalPagar.TabIndex = 5;
            // 
            // AgregarBebida
            // 
            this.AgregarBebida.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AgregarBebida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AgregarBebida.FlatAppearance.BorderSize = 2;
            this.AgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBebida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarBebida.Location = new System.Drawing.Point(618, 16);
            this.AgregarBebida.Name = "AgregarBebida";
            this.AgregarBebida.Size = new System.Drawing.Size(130, 30);
            this.AgregarBebida.TabIndex = 6;
            this.AgregarBebida.Text = "Agregar Bebida";
            this.AgregarBebida.UseVisualStyleBackColor = false;
            this.AgregarBebida.Click += new System.EventHandler(this.AgregarBebida_Click);
            // 
            // dollar
            // 
            this.dollar.AutoSize = true;
            this.dollar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dollar.Location = new System.Drawing.Point(233, 483);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(23, 28);
            this.dollar.TabIndex = 5;
            this.dollar.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(760, 530);
            this.Controls.Add(this.AgregarBebida);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.totalPagar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBebidas);
            this.Controls.Add(this.Hora);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.FlowLayoutPanel PanelBebidas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BebidasAlcoholBtn;
        private System.Windows.Forms.Button RegistrosBtn;
        private System.Windows.Forms.Button bebidasBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clienteBtn;
        private System.Windows.Forms.Label totalPagar;
        private System.Windows.Forms.Button AgregarBebida;
        private System.Windows.Forms.Label dollar;
    }
}

