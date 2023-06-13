namespace Tutor
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
            this.btn_click = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.RichTextBox();
            this.tb_result2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(388, 453);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(26, 12);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(386, 426);
            this.tb_result.TabIndex = 1;
            this.tb_result.Text = "";
            // 
            // tb_result2
            // 
            this.tb_result2.Location = new System.Drawing.Point(438, 12);
            this.tb_result2.Name = "tb_result2";
            this.tb_result2.Size = new System.Drawing.Size(393, 426);
            this.tb_result2.TabIndex = 2;
            this.tb_result2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 510);
            this.Controls.Add(this.tb_result2);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.RichTextBox tb_result;
        private System.Windows.Forms.RichTextBox tb_result2;
    }
}

