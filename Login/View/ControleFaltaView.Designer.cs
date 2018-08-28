namespace Login
{
    partial class ControleFaltaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleFaltaView));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.tblFalta = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFalta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.textBox1.Location = new System.Drawing.Point(232, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 32);
            this.textBox1.TabIndex = 0;
            // 
            // cbxMes
            // 
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "Nome de Guerra",
            "Nome Completo",
            "RA"});
            this.cbxMes.Location = new System.Drawing.Point(63, 23);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(148, 33);
            this.cbxMes.TabIndex = 1;
            // 
            // tblFalta
            // 
            this.tblFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFalta.Location = new System.Drawing.Point(63, 91);
            this.tblFalta.Name = "tblFalta";
            this.tblFalta.RowTemplate.Height = 24;
            this.tblFalta.Size = new System.Drawing.Size(1238, 511);
            this.tblFalta.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1205, 639);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 46);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // ControleFaltaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1370, 697);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tblFalta);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ControleFaltaView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Faltas";
            this.Load += new System.EventHandler(this.ControleFalta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.DataGridView tblFalta;
        private System.Windows.Forms.Button btnSalvar;
    }
}