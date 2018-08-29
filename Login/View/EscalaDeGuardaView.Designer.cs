namespace Login.View
{
    partial class EscalaDeGuardaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscalaDeGuardaView));
            this.tblEscala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEscala
            // 
            this.tblEscala.AllowUserToDeleteRows = false;
            this.tblEscala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEscala.Location = new System.Drawing.Point(12, 12);
            this.tblEscala.Name = "tblEscala";
            this.tblEscala.ReadOnly = true;
            this.tblEscala.Size = new System.Drawing.Size(1346, 673);
            this.tblEscala.TabIndex = 0;
            // 
            // EscalaDeGuardaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 697);
            this.Controls.Add(this.tblEscala);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EscalaDeGuardaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Escala De Guarda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tblEscala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblEscala;
    }
}