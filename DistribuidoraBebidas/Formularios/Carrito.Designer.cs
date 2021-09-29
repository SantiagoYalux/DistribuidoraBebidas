
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
            this.Hora = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarritoCliente
            // 
            this.dgvCarritoCliente.AllowUserToAddRows = false;
            this.dgvCarritoCliente.AllowUserToResizeColumns = false;
            this.dgvCarritoCliente.AllowUserToResizeRows = false;
            this.dgvCarritoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarritoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarritoCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarritoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBebida,
            this.PrecioBebida});
            this.dgvCarritoCliente.Location = new System.Drawing.Point(21, 81);
            this.dgvCarritoCliente.Name = "dgvCarritoCliente";
            this.dgvCarritoCliente.RowTemplate.Height = 25;
            this.dgvCarritoCliente.Size = new System.Drawing.Size(545, 226);
            this.dgvCarritoCliente.TabIndex = 0;
            this.dgvCarritoCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarritoCliente_CellClick);
            this.dgvCarritoCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarritoCliente_CellContentClick);
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
            this.imprimirBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.imprimirBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imprimirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imprimirBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imprimirBtn.ForeColor = System.Drawing.Color.White;
            this.imprimirBtn.Location = new System.Drawing.Point(0, 359);
            this.imprimirBtn.Name = "imprimirBtn";
            this.imprimirBtn.Size = new System.Drawing.Size(582, 38);
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
            this.Hora.BackColor = System.Drawing.Color.DodgerBlue;
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hora.ForeColor = System.Drawing.Color.White;
            this.Hora.Location = new System.Drawing.Point(11, 8);
            this.Hora.Name = "Hora";
            this.Hora.Padding = new System.Windows.Forms.Padding(5);
            this.Hora.Size = new System.Drawing.Size(54, 33);
            this.Hora.TabIndex = 2;
            this.Hora.Text = "hora";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(457, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 37);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.Hora);
            this.panel2.Location = new System.Drawing.Point(21, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 46);
            this.panel2.TabIndex = 5;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.borrarBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.borrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.borrarBtn.FlatAppearance.BorderSize = 2;
            this.borrarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.borrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrarBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrarBtn.ForeColor = System.Drawing.Color.White;
            this.borrarBtn.Location = new System.Drawing.Point(474, 314);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(92, 39);
            this.borrarBtn.TabIndex = 3;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = false;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(582, 397);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.imprimirBtn);
            this.Controls.Add(this.dgvCarritoCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarritoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarritoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBebida;
        private System.Windows.Forms.Button imprimirBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button borrarBtn;
    }
}