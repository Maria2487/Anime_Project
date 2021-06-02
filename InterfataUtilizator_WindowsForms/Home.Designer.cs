
namespace InterfataUtilizator_WindowsForms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonIncarcareFile = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.buttonModificare = new System.Windows.Forms.Button();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(39)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1309, 94);
            this.panelTop.TabIndex = 0;
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
            this.buttonExit.TabIndex = 1;
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
            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Controls.Add(this.panelLeft);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 94);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1309, 544);
            this.panelRight.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1109, 544);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.panelLeft.Controls.Add(this.buttonInfo);
            this.panelLeft.Controls.Add(this.buttonIncarcareFile);
            this.panelLeft.Controls.Add(this.buttonStergere);
            this.panelLeft.Controls.Add(this.buttonModificare);
            this.panelLeft.Controls.Add(this.buttonCautare);
            this.panelLeft.Controls.Add(this.buttonAdaugare);
            this.panelLeft.Controls.Add(this.buttonAfisare);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 544);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(0, 462);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(200, 77);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.Text = "Informatii Autor";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonIncarcareFile
            // 
            this.buttonIncarcareFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIncarcareFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncarcareFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncarcareFile.Location = new System.Drawing.Point(0, 385);
            this.buttonIncarcareFile.Name = "buttonIncarcareFile";
            this.buttonIncarcareFile.Size = new System.Drawing.Size(200, 77);
            this.buttonIncarcareFile.TabIndex = 5;
            this.buttonIncarcareFile.Text = "Incarcare Fisier";
            this.buttonIncarcareFile.UseVisualStyleBackColor = true;
            this.buttonIncarcareFile.Click += new System.EventHandler(this.buttonIncarcareFile_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStergere.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergere.Location = new System.Drawing.Point(0, 308);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(200, 77);
            this.buttonStergere.TabIndex = 4;
            this.buttonStergere.Text = "Stergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // buttonModificare
            // 
            this.buttonModificare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificare.Location = new System.Drawing.Point(0, 231);
            this.buttonModificare.Name = "buttonModificare";
            this.buttonModificare.Size = new System.Drawing.Size(200, 77);
            this.buttonModificare.TabIndex = 3;
            this.buttonModificare.Text = "Modificare";
            this.buttonModificare.UseVisualStyleBackColor = true;
            this.buttonModificare.Click += new System.EventHandler(this.buttonModificare_Click);
            // 
            // buttonCautare
            // 
            this.buttonCautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.buttonCautare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCautare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCautare.Location = new System.Drawing.Point(0, 154);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(200, 77);
            this.buttonCautare.TabIndex = 2;
            this.buttonCautare.Text = "Cautare";
            this.buttonCautare.UseVisualStyleBackColor = false;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.buttonAdaugare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugare.Location = new System.Drawing.Point(0, 77);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(200, 77);
            this.buttonAdaugare.TabIndex = 1;
            this.buttonAdaugare.Text = "Adaugare";
            this.buttonAdaugare.UseVisualStyleBackColor = false;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(92)))), ((int)(((byte)(243)))));
            this.buttonAfisare.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfisare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.Location = new System.Drawing.Point(0, 0);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(200, 77);
            this.buttonAfisare.TabIndex = 0;
            this.buttonAfisare.Text = "Afisare";
            this.buttonAfisare.UseVisualStyleBackColor = false;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1309, 638);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonIncarcareFile;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Button buttonModificare;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}