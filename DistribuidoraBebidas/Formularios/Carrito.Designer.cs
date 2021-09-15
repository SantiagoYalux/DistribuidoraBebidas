
namespace DistribuidoraBebidas.Formularios
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.dgvCarritoCliente = new System.Windows.Forms.DataGridView();
            this.NombreBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimirBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Hora = new System.Windows.Forms.Label();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarritoCliente
            // 
            this.dgvCarritoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBebida,
            this.PrecioBebida});
            this.dgvCarritoCliente.Location = new System.Drawing.Point(47, 52);
            this.dgvCarritoCliente.Name = "dgvCarritoCliente";
            this.dgvCarritoCliente.RowTemplate.Height = 25;
            this.dgvCarritoCliente.Size = new System.Drawing.Size(244, 279);
            this.dgvCarritoCliente.TabIndex = 0;
            this.dgvCarritoCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarritoCliente_CellClick);
            // 
            // NombreBebida
            // 
            this.NombreBebida.HeaderText = "Bebida";
            this.NombreBebida.Name = "NombreBebida";
            // 
            // PrecioBebida
            // 
            this.PrecioBebida.HeaderText = "Precio";
            this.PrecioBebida.Name = "PrecioBebida";
            // 
            // imprimirBtn
            // 
            this.imprimirBtn.AutoSize = true;
            this.imprimirBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.imprimirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imprimirBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imprimirBtn.ForeColor = System.Drawing.Color.White;
            this.imprimirBtn.Location = new System.Drawing.Point(121, 383);
            this.imprimirBtn.Name = "imprimirBtn";
            this.imprimirBtn.Size = new System.Drawing.Size(104, 38);
            this.imprimirBtn.TabIndex = 1;
            this.imprimirBtn.Text = "Imprimir";
            this.imprimirBtn.UseVisualStyleBackColor = false;
            this.imprimirBtn.Click += new System.EventHandler(this.imprimirBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hora.Location = new System.Drawing.Point(12, 9);
            this.Hora.Name = "Hora";
            this.Hora.Padding = new System.Windows.Forms.Padding(5);
            this.Hora.Size = new System.Drawing.Size(51, 32);
            this.Hora.TabIndex = 2;
            this.Hora.Text = "hora";
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(216, 337);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 23);
            this.borrarBtn.TabIndex = 3;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(291, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 42);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.imprimirBtn);
            this.Controls.Add(this.dgvCarritoCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarritoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarritoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBebida;
        private System.Windows.Forms.Button imprimirBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button backButton;
    }
}