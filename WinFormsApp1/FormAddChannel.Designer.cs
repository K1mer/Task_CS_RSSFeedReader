
namespace Task2
{
    partial class FormAddChannel
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
            this.label_url = new System.Windows.Forms.Label();
            this.button_ch_add_confirm = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(155, 9);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(28, 15);
            this.label_url.TabIndex = 0;
            this.label_url.Text = "URL";
            // 
            // button_ch_add_confirm
            // 
            this.button_ch_add_confirm.Location = new System.Drawing.Point(131, 56);
            this.button_ch_add_confirm.Name = "button_ch_add_confirm";
            this.button_ch_add_confirm.Size = new System.Drawing.Size(77, 25);
            this.button_ch_add_confirm.TabIndex = 1;
            this.button_ch_add_confirm.Text = "Добавить";
            this.button_ch_add_confirm.UseVisualStyleBackColor = true;
            this.button_ch_add_confirm.Click += new System.EventHandler(this.button_ch_add_confirm_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 27);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(320, 23);
            this.textBox_url.TabIndex = 3;
            // 
            // FormAddChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 87);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button_ch_add_confirm);
            this.Controls.Add(this.label_url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddChannel";
            this.Text = "Добавить канал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button button_ch_add_confirm;
        private System.Windows.Forms.TextBox textBox_url;
    }
}