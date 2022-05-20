namespace ChuckNorrisWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.btn_joke = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // cbx_category
            // 
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(158, 124);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(151, 28);
            this.cbx_category.TabIndex = 1;
            // 
            // btn_joke
            // 
            this.btn_joke.Location = new System.Drawing.Point(83, 197);
            this.btn_joke.Name = "btn_joke";
            this.btn_joke.Size = new System.Drawing.Size(151, 134);
            this.btn_joke.TabIndex = 2;
            this.btn_joke.Text = "Generate Joke";
            this.btn_joke.UseVisualStyleBackColor = true;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(45, 127);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(73, 20);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Category:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 423);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.btn_joke);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbx_category;
        private Button btn_joke;
        private Label lbl_category;
    }
}