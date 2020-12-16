namespace IrfProject_ko64zx
{
    partial class Jatek
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
            this.valasz1 = new System.Windows.Forms.Button();
            this.valasz2 = new System.Windows.Forms.Button();
            this.valasz3 = new System.Windows.Forms.Button();
            this.valasz4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.eredmenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valasz1
            // 
            this.valasz1.Location = new System.Drawing.Point(30, 118);
            this.valasz1.Name = "valasz1";
            this.valasz1.Size = new System.Drawing.Size(208, 55);
            this.valasz1.TabIndex = 0;
            this.valasz1.Tag = "1";
            this.valasz1.Text = "A";
            this.valasz1.UseVisualStyleBackColor = true;
            this.valasz1.Visible = false;
            this.valasz1.Click += new System.EventHandler(this.valaszellenorzes);
            // 
            // valasz2
            // 
            this.valasz2.Location = new System.Drawing.Point(262, 118);
            this.valasz2.Name = "valasz2";
            this.valasz2.Size = new System.Drawing.Size(208, 55);
            this.valasz2.TabIndex = 1;
            this.valasz2.Tag = "2";
            this.valasz2.Text = "B";
            this.valasz2.UseVisualStyleBackColor = true;
            this.valasz2.Visible = false;
            this.valasz2.Click += new System.EventHandler(this.valaszellenorzes);
            // 
            // valasz3
            // 
            this.valasz3.Location = new System.Drawing.Point(30, 179);
            this.valasz3.Name = "valasz3";
            this.valasz3.Size = new System.Drawing.Size(208, 55);
            this.valasz3.TabIndex = 3;
            this.valasz3.Tag = "3";
            this.valasz3.Text = "C";
            this.valasz3.UseVisualStyleBackColor = true;
            this.valasz3.Visible = false;
            this.valasz3.Click += new System.EventHandler(this.valaszellenorzes);
            // 
            // valasz4
            // 
            this.valasz4.Location = new System.Drawing.Point(262, 179);
            this.valasz4.Name = "valasz4";
            this.valasz4.Size = new System.Drawing.Size(208, 55);
            this.valasz4.TabIndex = 2;
            this.valasz4.Tag = "4";
            this.valasz4.Text = "D";
            this.valasz4.UseVisualStyleBackColor = true;
            this.valasz4.Visible = false;
            this.valasz4.Click += new System.EventHandler(this.valaszellenorzes);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kérdés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add meg a játékos nevét és kattints a START gombra";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 6;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(117, 126);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(259, 43);
            this.startbtn.TabIndex = 7;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eredmenyBindingSource
            // 
            this.eredmenyBindingSource.DataSource = typeof(IrfProject_ko64zx.Eredmeny);
            // 
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 251);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valasz3);
            this.Controls.Add(this.valasz4);
            this.Controls.Add(this.valasz2);
            this.Controls.Add(this.valasz1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Jatek";
            this.Text = "Jatek";
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valasz1;
        private System.Windows.Forms.Button valasz2;
        private System.Windows.Forms.Button valasz3;
        private System.Windows.Forms.Button valasz4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource eredmenyBindingSource;
    }
}