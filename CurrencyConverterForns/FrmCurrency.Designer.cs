namespace CurrencyConverterForms
{
    partial class FrmCurrency
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
            this.lblConvert = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fromCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toCombo = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(25, 25);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(57, 17);
            this.lblConvert.TabIndex = 0;
            this.lblConvert.Text = "Convert";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(91, 25);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 22);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fromCombo);
            this.groupBox2.Location = new System.Drawing.Point(28, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(89, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // fromCombo
            // 
            this.fromCombo.FormattingEnabled = true;
            this.fromCombo.Items.AddRange(new object[] {
            "PEN",
            "USD",
            "EUR"});
            this.fromCombo.Location = new System.Drawing.Point(0, 48);
            this.fromCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromCombo.Name = "fromCombo";
            this.fromCombo.Size = new System.Drawing.Size(88, 24);
            this.fromCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toCombo);
            this.groupBox1.Location = new System.Drawing.Point(136, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(91, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To";
            // 
            // toCombo
            // 
            this.toCombo.FormattingEnabled = true;
            this.toCombo.Items.AddRange(new object[] {
            "PEN",
            "USD",
            "EUR"});
            this.toCombo.Location = new System.Drawing.Point(0, 47);
            this.toCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toCombo.Name = "toCombo";
            this.toCombo.Size = new System.Drawing.Size(89, 24);
            this.toCombo.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(256, 73);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(256, 108);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(16, 17);
            this.Result.TabIndex = 5;
            this.Result.Text = "0";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(259, 150);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 202);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblConvert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCurrency";
            this.Text = "$ Converter";
            this.Load += new System.EventHandler(this.FrmCurrency_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ComboBox fromCombo;
        private System.Windows.Forms.ComboBox toCombo;
    }
}

