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
            this.valasz1 = new System.Windows.Forms.Button();
            this.valasz2 = new System.Windows.Forms.Button();
            this.valasz3 = new System.Windows.Forms.Button();
            this.valasz4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valasz1
            // 
            this.valasz1.Enabled = false;
            this.valasz1.Location = new System.Drawing.Point(32, 166);
            this.valasz1.Name = "valasz1";
            this.valasz1.Size = new System.Drawing.Size(208, 55);
            this.valasz1.TabIndex = 0;
            this.valasz1.Tag = "1";
            this.valasz1.Text = "A";
            this.valasz1.UseVisualStyleBackColor = true;
            // 
            // valasz2
            // 
            this.valasz2.Enabled = false;
            this.valasz2.Location = new System.Drawing.Point(264, 166);
            this.valasz2.Name = "valasz2";
            this.valasz2.Size = new System.Drawing.Size(208, 55);
            this.valasz2.TabIndex = 1;
            this.valasz2.Tag = "2";
            this.valasz2.Text = "B";
            this.valasz2.UseVisualStyleBackColor = true;
            // 
            // valasz3
            // 
            this.valasz3.Enabled = false;
            this.valasz3.Location = new System.Drawing.Point(32, 227);
            this.valasz3.Name = "valasz3";
            this.valasz3.Size = new System.Drawing.Size(208, 55);
            this.valasz3.TabIndex = 3;
            this.valasz3.Tag = "3";
            this.valasz3.Text = "C";
            this.valasz3.UseVisualStyleBackColor = true;
            // 
            // valasz4
            // 
            this.valasz4.Enabled = false;
            this.valasz4.Location = new System.Drawing.Point(264, 227);
            this.valasz4.Name = "valasz4";
            this.valasz4.Size = new System.Drawing.Size(208, 55);
            this.valasz4.TabIndex = 2;
            this.valasz4.Tag = "4";
            this.valasz4.Text = "D";
            this.valasz4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(192, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kérdés";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add meg a játékos nevét és kattints a START gombra";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 6;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(118, 94);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(259, 43);
            this.startbtn.TabIndex = 7;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            // 
            // Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 308);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valasz3);
            this.Controls.Add(this.valasz4);
            this.Controls.Add(this.valasz2);
            this.Controls.Add(this.valasz1);
            this.Name = "Jatek";
            this.Text = "Jatek";
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
    }
}