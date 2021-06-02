
namespace InterfataUtilizator_WindowsForms
{
    partial class StergereForm
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
            this.txtNume1 = new System.Windows.Forms.TextBox();
            this.lblNume1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(39)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.label2);
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
            this.buttonReturn.TabIndex = 6;
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
            this.buttonExit.TabIndex = 5;
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
            this.panelRight.Controls.Add(this.txtNume1);
            this.panelRight.Controls.Add(this.lblNume1);
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
            this.ListaAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAnime.FormattingEnabled = true;
            this.ListaAnime.HorizontalScrollbar = true;
            this.ListaAnime.ItemHeight = 29;
            this.ListaAnime.Location = new System.Drawing.Point(222, 103);
            this.ListaAnime.Name = "ListaAnime";
            this.ListaAnime.Size = new System.Drawing.Size(1070, 381);
            this.ListaAnime.TabIndex = 65;
            // 
            // txtNume1
            // 
            this.txtNume1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume1.Location = new System.Drawing.Point(761, 46);
            this.txtNume1.Name = "txtNume1";
            this.txtNume1.Size = new System.Drawing.Size(100, 27);
            this.txtNume1.TabIndex = 63;
            // 
            // lblNume1
            // 
            this.lblNume1.AutoSize = true;
            this.lblNume1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume1.Location = new System.Drawing.Point(660, 53);
            this.lblNume1.Name = "lblNume1";
            this.lblNume1.Size = new System.Drawing.Size(57, 20);
            this.lblNume1.TabIndex = 53;
            this.lblNume1.Text = "NAME";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.panelLeft.Controls.Add(this.buttonAfisare);
            this.panelLeft.Controls.Add(this.buttonCauta);
            this.panelLeft.Controls.Add(this.buttonStergere);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 544);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonCauta
            // 
            this.buttonCauta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Location = new System.Drawing.Point(0, 77);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(200, 77);
            this.buttonCauta.TabIndex = 6;
            this.buttonCauta.Text = "Cauta animeul (caseta NAME)";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStergere.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergere.Location = new System.Drawing.Point(0, 0);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(200, 77);
            this.buttonStergere.TabIndex = 4;
            this.buttonStergere.Text = "Sterge elementul selectat";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.buttonAfisare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfisare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.Location = new System.Drawing.Point(0, 154);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(200, 77);
            this.buttonAfisare.TabIndex = 7;
            this.buttonAfisare.Text = "Vizualizare lista";
            this.buttonAfisare.UseVisualStyleBackColor = false;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 8;
            this.label2.Visible = false;
            // 
            // StergereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1309, 638);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StergereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaAnime;
        private System.Windows.Forms.TextBox txtNume1;
        private System.Windows.Forms.Label lblNume1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Label label2;
    }
}