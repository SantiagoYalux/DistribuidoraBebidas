
namespace DistribuidoraBebidas.Formularios
{
    partial class CompletarPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMontoPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formaPagoCbx = new System.Windows.Forms.ComboBox();
            this.CompletarPagoBtn = new System.Windows.Forms.Button();
            this.imprimirDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreCliente.Location = new System.Drawing.Point(12, 98);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 29);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Finalizar Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(219, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto";
            // 
            // tbxMontoPagar
            // 
            this.tbxMontoPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMontoPagar.Location = new System.Drawing.Point(198, 98);
            this.tbxMontoPagar.Name = "tbxMontoPagar";
            this.tbxMontoPagar.ReadOnly = true;
            this.tbxMontoPagar.Size = new System.Drawing.Size(100, 29);
            this.tbxMontoPagar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(391, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Forma Pago";
            // 
            // formaPagoCbx
            // 
            this.formaPagoCbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formaPagoCbx.FormattingEnabled = true;
            this.formaPagoCbx.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.formaPagoCbx.Location = new System.Drawing.Point(376, 98);
            this.formaPagoCbx.Name = "formaPagoCbx";
            this.formaPagoCbx.Size = new System.Drawing.Size(121, 29);
            this.formaPagoCbx.TabIndex = 4;
            // 
            // CompletarPagoBtn
            // 
            this.CompletarPagoBtn.Location = new System.Drawing.Point(186, 158);
            this.CompletarPagoBtn.Name = "CompletarPagoBtn";
            this.CompletarPagoBtn.Size = new System.Drawing.Size(131, 35);
            this.CompletarPagoBtn.TabIndex = 5;
            this.CompletarPagoBtn.Text = "Pagar";
            this.CompletarPagoBtn.UseVisualStyleBackColor = true;
            this.CompletarPagoBtn.Click += new System.EventHandler(this.CompletarPagoBtn_Click);
            // 
            // CompletarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(509, 196);
            this.Controls.Add(this.CompletarPagoBtn);
            this.Controls.Add(this.formaPagoCbx);
            this.Controls.Add(this.tbxMontoPagar);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CompletarPago";
            this.Text = "CompletarPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMontoPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox formaPagoCbx;
        private System.Windows.Forms.Button CompletarPagoBtn;
        private System.Drawing.Printing.PrintDocument imprimirDocument1;
    }
}