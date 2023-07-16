namespace HarmonogramForma
{
    partial class HarmonogramForm
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
            this.coDzień = new System.Windows.Forms.ComboBox();
            this.buZapisz = new System.Windows.Forms.Button();
            this.buAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coDzień
            // 
            this.coDzień.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coDzień.FormattingEnabled = true;
            this.coDzień.Location = new System.Drawing.Point(13, 13);
            this.coDzień.Name = "coDzień";
            this.coDzień.Size = new System.Drawing.Size(121, 21);
            this.coDzień.TabIndex = 0;
            this.coDzień.SelectedIndexChanged += new System.EventHandler(this.coDzień_SelectedIndexChanged);
            // 
            // buZapisz
            // 
            this.buZapisz.Location = new System.Drawing.Point(13, 168);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(75, 23);
            this.buZapisz.TabIndex = 1;
            this.buZapisz.Text = "Zapisz";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // buAnuluj
            // 
            this.buAnuluj.Location = new System.Drawing.Point(125, 168);
            this.buAnuluj.Name = "buAnuluj";
            this.buAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buAnuluj.TabIndex = 2;
            this.buAnuluj.Text = "Anuluj";
            this.buAnuluj.UseVisualStyleBackColor = true;
            this.buAnuluj.Click += new System.EventHandler(this.buAnuluj_Click);
            // 
            // HarmonogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 200);
            this.ControlBox = false;
            this.Controls.Add(this.buAnuluj);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.coDzień);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HarmonogramForm";
            this.Text = "HarmonogramForm";
            this.Load += new System.EventHandler(this.HarmonogramForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HarmonogramForm_Paint);
            this.Activated += new System.EventHandler(this.HarmonogramForm_Activated);
            this.Enter += new System.EventHandler(this.HarmonogramForm_Enter);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HarmonogramForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox coDzień;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Button buAnuluj;

    }
}