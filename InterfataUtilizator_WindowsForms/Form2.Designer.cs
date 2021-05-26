
namespace InterfataUtilizator_WindowsForms
{
    partial class Form2
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
            this.buttonCauta = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtNume2 = new System.Windows.Forms.TextBox();
            this.dataGridAnime = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(585, 47);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(130, 30);
            this.buttonCauta.TabIndex = 0;
            this.buttonCauta.Text = "Cauta animele";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(36, 55);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(235, 17);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "Introduceti numele animeului cautat:";
            // 
            // txtNume2
            // 
            this.txtNume2.Location = new System.Drawing.Point(295, 52);
            this.txtNume2.Name = "txtNume2";
            this.txtNume2.Size = new System.Drawing.Size(251, 22);
            this.txtNume2.TabIndex = 2;
            // 
            // dataGridAnime
            // 
            this.dataGridAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnime.Location = new System.Drawing.Point(39, 121);
            this.dataGridAnime.Name = "dataGridAnime";
            this.dataGridAnime.RowHeadersWidth = 51;
            this.dataGridAnime.RowTemplate.Height = 24;
            this.dataGridAnime.Size = new System.Drawing.Size(676, 150);
            this.dataGridAnime.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click pentru a te intoarce";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridAnime);
            this.Controls.Add(this.txtNume2);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.buttonCauta);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cautare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtNume2;
        private System.Windows.Forms.DataGridView dataGridAnime;
        private System.Windows.Forms.Button button1;
    }
}