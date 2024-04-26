namespace jatekokFRM
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_link = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cb_genre);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search";
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(348, 37);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(121, 21);
            this.cb_genre.TabIndex = 2;
            this.cb_genre.SelectedIndexChanged += new System.EventHandler(this.cb_genre_SelectedIndexChanged);
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(50, 37);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(249, 20);
            this.tb_title.TabIndex = 1;
            this.tb_title.TextChanged += new System.EventHandler(this.tb_title_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "title:";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.year,
            this.genre});
            this.DGV.Location = new System.Drawing.Point(12, 113);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(510, 288);
            this.DGV.TabIndex = 1;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 54;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.l_link);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 44);
            this.panel1.TabIndex = 2;
            // 
            // l_link
            // 
            this.l_link.Location = new System.Drawing.Point(0, 0);
            this.l_link.Name = "l_link";
            this.l_link.Size = new System.Drawing.Size(510, 44);
            this.l_link.TabIndex = 0;
            this.l_link.Text = "### GOOGLE SEARCH URL ###";
            this.l_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_link.Click += new System.EventHandler(this.l_link_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(532, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Best Games of All Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_genre;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.Label l_link;
    }
}

