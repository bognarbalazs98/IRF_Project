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
            this.eredmenyekdgw = new System.Windows.Forms.DataGridView();
            this.startbtn = new System.Windows.Forms.Button();
            this.kerdesekbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyekdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // eredmenyekdgw
            // 
            this.eredmenyekdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eredmenyekdgw.Location = new System.Drawing.Point(226, 21);
            this.eredmenyekdgw.Name = "eredmenyekdgw";
            this.eredmenyekdgw.Size = new System.Drawing.Size(433, 251);
            this.eredmenyekdgw.TabIndex = 0;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(13, 35);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Játék indítása";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // kerdesekbtn
            // 
            this.kerdesekbtn.Location = new System.Drawing.Point(13, 78);
            this.kerdesekbtn.Name = "kerdesekbtn";
            this.kerdesekbtn.Size = new System.Drawing.Size(75, 23);
            this.kerdesekbtn.TabIndex = 2;
            this.kerdesekbtn.Text = "Kérdések";
            this.kerdesekbtn.UseVisualStyleBackColor = true;
            this.kerdesekbtn.Click += new System.EventHandler(this.kerdesekbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kerdesekbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.eredmenyekdgw);
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyekdgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eredmenyekdgw;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button kerdesekbtn;
        private System.Windows.Forms.Button button3;
    }
}

