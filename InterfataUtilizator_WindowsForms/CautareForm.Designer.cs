
namespace InterfataUtilizator_WindowsForms
{
    partial class CautareForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ListaAnime = new System.Windows.Forms.ListBox();
            this.dataGridAnime = new System.Windows.Forms.DataGridView();
            this.txtNume2 = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(39)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.buttonReturn);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1309, 94);
            this.panelTop.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Wingdings 3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReturn.Location = new System.Drawing.Point(1159, 0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 94);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "O";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Webdings", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonExit.Location = new System.Drawing.Point(1234, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 94);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "r";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anime";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(26)))), ((int)(((byte)(150)))));
            this.panelRight.Controls.Add(this.ListaAnime);
            this.panelRight.Controls.Add(this.dataGridAnime);
            this.panelRight.Controls.Add(this.txtNume2);
            this.panelRight.Controls.Add(this.lblMesaj);
            this.panelRight.Controls.Add(this.buttonCauta);
            this.panelRight.Controls.Add(this.panelLeft);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 94);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1309, 544);
            this.panelRight.TabIndex = 2;
            // 
            // ListaAnime
            // 
            this.ListaAnime.BackColor = System.Drawing.Color.BlueViolet;
            this.ListaAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAnime.FormattingEnabled = true;
            this.ListaAnime.HorizontalScrollbar = true;
            this.ListaAnime.ItemHeight = 20;
            this.ListaAnime.Location = new System.Drawing.Point(224, 21);
            this.ListaAnime.Name = "ListaAnime";
            this.ListaAnime.Size = new System.Drawing.Size(1061, 124);
            this.ListaAnime.TabIndex = 66;
            // 
            // dataGridAnime
            // 
            this.dataGridAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnime.Location = new System.Drawing.Point(233, 321);
            this.dataGridAnime.Name = "dataGridAnime";
            this.dataGridAnime.RowHeadersWidth = 51;
            this.dataGridAnime.RowTemplate.Height = 24;
            this.dataGridAnime.Size = new System.Drawing.Size(1052, 161);
            this.dataGridAnime.TabIndex = 8;
            // 
            // txtNume2
            // 
            this.txtNume2.Location = new System.Drawing.Point(631, 223);
            this.txtNume2.Name = "txtNume2";
            this.txtNume2.Size = new System.Drawing.Size(251, 22);
            this.txtNume2.TabIndex = 7;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(525, 168);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(473, 32);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Introduceti numele animeului cautat:";
            // 
            // buttonCauta
            // 
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Location = new System.Drawing.Point(673, 268);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(182, 30);
            this.buttonCauta.TabIndex = 5;
            this.buttonCauta.Text = "Cauta animele";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 544);
            this.panelLeft.TabIndex = 0;
            // 
            // CautareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1309, 638);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CautareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAnime;
        private System.Windows.Forms.TextBox txtNume2;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.ListBox ListaAnime;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonExit;
    }
}