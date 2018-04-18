namespace SKLEPCRUD
{
    partial class LaptopyLista
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
            this.GridLaptopy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridLaptopy)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLaptopy
            // 
            this.GridLaptopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLaptopy.Location = new System.Drawing.Point(12, 12);
            this.GridLaptopy.Name = "GridLaptopy";
            this.GridLaptopy.Size = new System.Drawing.Size(755, 364);
            this.GridLaptopy.TabIndex = 0;
            this.GridLaptopy.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridLaptopy_RowHeaderMouseDoubleClick);
            // 
            // LaptopyLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 388);
            this.Controls.Add(this.GridLaptopy);
            this.Name = "LaptopyLista";
            this.Text = "Lista Laptopów";
            this.Load += new System.EventHandler(this.LaptopyLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLaptopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLaptopy;
    }
}