namespace taller1v2
{
    partial class Form3
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
            this.txtFibo = new System.Windows.Forms.TextBox();
            this.serie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // txtFibo
            // 
            this.txtFibo.Location = new System.Drawing.Point(329, 112);
            this.txtFibo.Name = "txtFibo";
            this.txtFibo.Size = new System.Drawing.Size(100, 22);
            this.txtFibo.TabIndex = 1;
            // 
            // serie
            // 
            this.serie.Location = new System.Drawing.Point(254, 168);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(75, 23);
            this.serie.TabIndex = 2;
            this.serie.Text = "button1";
            this.serie.UseVisualStyleBackColor = true;
            this.serie.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.txtFibo);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFibo;
        private System.Windows.Forms.Button serie;
    }
}