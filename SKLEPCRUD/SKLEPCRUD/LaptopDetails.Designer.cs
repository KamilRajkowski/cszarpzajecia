namespace SKLEPCRUD
{
    partial class LaptopDetails
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
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelHdd = new System.Windows.Forms.Label();
            this.LabelProcesor = new System.Windows.Forms.Label();
            this.LabelEkran = new System.Windows.Forms.Label();
            this.LabelRam = new System.Windows.Forms.Label();
            this.LabelCena = new System.Windows.Forms.Label();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.TextBoxProcesor = new System.Windows.Forms.TextBox();
            this.TextBoxRam = new System.Windows.Forms.TextBox();
            this.TextBoxEkran = new System.Windows.Forms.TextBox();
            this.TextBoxCena = new System.Windows.Forms.TextBox();
            this.TextBoxHdd = new System.Windows.Forms.TextBox();
            this.SaveLaptopDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(12, 32);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(35, 13);
            this.LabelModel.TabIndex = 0;
            this.LabelModel.Text = "model";
            // 
            // LabelHdd
            // 
            this.LabelHdd.AutoSize = true;
            this.LabelHdd.Location = new System.Drawing.Point(11, 232);
            this.LabelHdd.Name = "LabelHdd";
            this.LabelHdd.Size = new System.Drawing.Size(25, 13);
            this.LabelHdd.TabIndex = 0;
            this.LabelHdd.Text = "hdd";
            // 
            // LabelProcesor
            // 
            this.LabelProcesor.AutoSize = true;
            this.LabelProcesor.Location = new System.Drawing.Point(12, 72);
            this.LabelProcesor.Name = "LabelProcesor";
            this.LabelProcesor.Size = new System.Drawing.Size(48, 13);
            this.LabelProcesor.TabIndex = 0;
            this.LabelProcesor.Text = "procesor";
            // 
            // LabelEkran
            // 
            this.LabelEkran.AutoSize = true;
            this.LabelEkran.Location = new System.Drawing.Point(12, 152);
            this.LabelEkran.Name = "LabelEkran";
            this.LabelEkran.Size = new System.Drawing.Size(34, 13);
            this.LabelEkran.TabIndex = 0;
            this.LabelEkran.Text = "ekran";
            // 
            // LabelRam
            // 
            this.LabelRam.AutoSize = true;
            this.LabelRam.Location = new System.Drawing.Point(12, 112);
            this.LabelRam.Name = "LabelRam";
            this.LabelRam.Size = new System.Drawing.Size(24, 13);
            this.LabelRam.TabIndex = 0;
            this.LabelRam.Text = "ram";
            // 
            // LabelCena
            // 
            this.LabelCena.AutoSize = true;
            this.LabelCena.Location = new System.Drawing.Point(11, 192);
            this.LabelCena.Name = "LabelCena";
            this.LabelCena.Size = new System.Drawing.Size(31, 13);
            this.LabelCena.TabIndex = 0;
            this.LabelCena.Text = "cena";
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Location = new System.Drawing.Point(65, 28);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(100, 20);
            this.TextBoxModel.TabIndex = 1;
            // 
            // TextBoxProcesor
            // 
            this.TextBoxProcesor.Location = new System.Drawing.Point(65, 68);
            this.TextBoxProcesor.Name = "TextBoxProcesor";
            this.TextBoxProcesor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxProcesor.TabIndex = 2;
            // 
            // TextBoxRam
            // 
            this.TextBoxRam.Location = new System.Drawing.Point(65, 108);
            this.TextBoxRam.Name = "TextBoxRam";
            this.TextBoxRam.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRam.TabIndex = 2;
            // 
            // TextBoxEkran
            // 
            this.TextBoxEkran.Location = new System.Drawing.Point(65, 148);
            this.TextBoxEkran.Name = "TextBoxEkran";
            this.TextBoxEkran.Size = new System.Drawing.Size(100, 20);
            this.TextBoxEkran.TabIndex = 2;
            // 
            // TextBoxCena
            // 
            this.TextBoxCena.Location = new System.Drawing.Point(65, 188);
            this.TextBoxCena.Name = "TextBoxCena";
            this.TextBoxCena.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCena.TabIndex = 2;
            // 
            // TextBoxHdd
            // 
            this.TextBoxHdd.Location = new System.Drawing.Point(65, 228);
            this.TextBoxHdd.Name = "TextBoxHdd";
            this.TextBoxHdd.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHdd.TabIndex = 2;
            // 
            // SaveLaptopDetails
            // 
            this.SaveLaptopDetails.Location = new System.Drawing.Point(197, 148);
            this.SaveLaptopDetails.Name = "SaveLaptopDetails";
            this.SaveLaptopDetails.Size = new System.Drawing.Size(75, 23);
            this.SaveLaptopDetails.TabIndex = 3;
            this.SaveLaptopDetails.Text = "Save";
            this.SaveLaptopDetails.UseVisualStyleBackColor = true;
            this.SaveLaptopDetails.Click += new System.EventHandler(this.SaveLaptopDetails_Click);
            // 
            // LaptopDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveLaptopDetails);
            this.Controls.Add(this.TextBoxHdd);
            this.Controls.Add(this.TextBoxCena);
            this.Controls.Add(this.TextBoxEkran);
            this.Controls.Add(this.TextBoxRam);
            this.Controls.Add(this.TextBoxProcesor);
            this.Controls.Add(this.TextBoxModel);
            this.Controls.Add(this.LabelCena);
            this.Controls.Add(this.LabelRam);
            this.Controls.Add(this.LabelEkran);
            this.Controls.Add(this.LabelProcesor);
            this.Controls.Add(this.LabelHdd);
            this.Controls.Add(this.LabelModel);
            this.Name = "LaptopDetails";
            this.Text = "LaptopDetails";
            this.Load += new System.EventHandler(this.LaptopDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelHdd;
        private System.Windows.Forms.Label LabelProcesor;
        private System.Windows.Forms.Label LabelEkran;
        private System.Windows.Forms.Label LabelRam;
        private System.Windows.Forms.Label LabelCena;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.TextBox TextBoxProcesor;
        private System.Windows.Forms.TextBox TextBoxRam;
        private System.Windows.Forms.TextBox TextBoxEkran;
        private System.Windows.Forms.TextBox TextBoxCena;
        private System.Windows.Forms.TextBox TextBoxHdd;
        private System.Windows.Forms.Button SaveLaptopDetails;
    }
}