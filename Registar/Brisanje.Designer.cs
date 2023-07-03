namespace Registar
{
    partial class Brisanje
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
            this.Brisi = new System.Windows.Forms.Button();
            this.Brisanje_txt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(229, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BRISANJE ZIVOTINJE IZ REGISTRA";
            // 
            // Brisi
            // 
            this.Brisi.Location = new System.Drawing.Point(303, 237);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(134, 41);
            this.Brisi.TabIndex = 1;
            this.Brisi.Text = "POTVRDI BRISANJE";
            this.Brisi.UseVisualStyleBackColor = true;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // Brisanje_txt
            // 
            this.Brisanje_txt.Location = new System.Drawing.Point(303, 152);
            this.Brisanje_txt.Name = "Brisanje_txt";
            this.Brisanje_txt.Size = new System.Drawing.Size(142, 23);
            this.Brisanje_txt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "NAZAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Brisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Brisanje_txt);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.label1);
            this.Name = "Brisanje";
            this.Text = "Brisanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Brisi;
        private TextBox Brisanje_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
    }
}