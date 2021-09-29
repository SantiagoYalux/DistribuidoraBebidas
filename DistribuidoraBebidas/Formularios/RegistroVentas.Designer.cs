
namespace DistribuidoraBebidas.Formularios
{
    partial class RegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVentas));
            this.historialCompraDGV = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historialCompraDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // historialCompraDGV
            // 
            this.historialCompraDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historialCompraDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historialCompraDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialCompraDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.MontoCompra,
            this.FormaPago});
            this.historialCompraDGV.Location = new System.Drawing.Point(12, 12);
            this.historialCompraDGV.Name = "historialCompraDGV";
            this.historialCompraDGV.RowTemplate.Height = 25;
            this.historialCompraDGV.Size = new System.Drawing.Size(519, 266);
            this.historialCompraDGV.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // MontoCompra
            // 
            this.MontoCompra.HeaderText = "Monto Compra";
            this.MontoCompra.Name = "MontoCompra";
            // 
            // FormaPago
            // 
            this.FormaPago.HeaderText = "Forma Pago";
            this.FormaPago.Name = "FormaPago";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(446, 284);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 37);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 326);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.historialCompraDGV);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.historialCompraDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historialCompraDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.Button backButton;
    }
}