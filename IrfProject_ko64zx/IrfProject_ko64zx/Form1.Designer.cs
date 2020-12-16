namespace IrfProject_ko64zx
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            this.startbtn = new System.Windows.Forms.Button();
            this.kerdesekbtn = new System.Windows.Forms.Button();
            this.eredmenyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eredmenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnjatekszabaly = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRanglista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(13, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(92, 41);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Játék indítása";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // kerdesekbtn
            // 
            this.kerdesekbtn.Location = new System.Drawing.Point(13, 59);
            this.kerdesekbtn.Name = "kerdesekbtn";
            this.kerdesekbtn.Size = new System.Drawing.Size(92, 41);
            this.kerdesekbtn.TabIndex = 2;
            this.kerdesekbtn.Text = "Kérdések";
            this.kerdesekbtn.UseVisualStyleBackColor = true;
            this.kerdesekbtn.Click += new System.EventHandler(this.kerdesekbtn_Click);
            // 
            // eredmenyDataGridView
            // 
            this.eredmenyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eredmenyDataGridView.AutoGenerateColumns = false;
            this.eredmenyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eredmenyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eredmenyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.eredmenyDataGridView.DataSource = this.eredmenyBindingSource;
            this.eredmenyDataGridView.Location = new System.Drawing.Point(111, 28);
            this.eredmenyDataGridView.Name = "eredmenyDataGridView";
            this.eredmenyDataGridView.Size = new System.Drawing.Size(534, 290);
            this.eredmenyDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Jatekos_nev";
            this.dataGridViewTextBoxColumn2.HeaderText = "Játékos név";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Eredmeny1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Eredmény";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // eredmenyBindingSource
            // 
            this.eredmenyBindingSource.DataSource = typeof(IrfProject_ko64zx.Eredmeny);
            // 
            // btnjatekszabaly
            // 
            this.btnjatekszabaly.Location = new System.Drawing.Point(13, 106);
            this.btnjatekszabaly.Name = "btnjatekszabaly";
            this.btnjatekszabaly.Size = new System.Drawing.Size(92, 41);
            this.btnjatekszabaly.TabIndex = 6;
            this.btnjatekszabaly.Text = "Játékszabályok";
            this.btnjatekszabaly.UseVisualStyleBackColor = true;
            this.btnjatekszabaly.Click += new System.EventHandler(this.btnjatekszabaly_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(499, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eredmények exportálása";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(347, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eredmények frissítése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eredmények:";
            // 
            // btnRanglista
            // 
            this.btnRanglista.Location = new System.Drawing.Point(13, 153);
            this.btnRanglista.Name = "btnRanglista";
            this.btnRanglista.Size = new System.Drawing.Size(92, 41);
            this.btnRanglista.TabIndex = 8;
            this.btnRanglista.Text = "Ranglista";
            this.btnRanglista.UseVisualStyleBackColor = true;
            this.btnRanglista.Click += new System.EventHandler(this.btnRanglista_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 374);
            this.Controls.Add(this.btnRanglista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnjatekszabaly);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eredmenyDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kerdesekbtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button kerdesekbtn;
        private System.Windows.Forms.BindingSource eredmenyBindingSource;
        private System.Windows.Forms.DataGridView eredmenyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnjatekszabaly;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRanglista;
    }
}

