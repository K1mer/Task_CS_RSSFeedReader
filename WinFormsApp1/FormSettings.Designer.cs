
namespace Task2
{
    partial class FormSettings
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
            this.button_settings_confirm = new System.Windows.Forms.Button();
            this.label_updateRate = new System.Windows.Forms.Label();
            this.checkBox_formatTags = new System.Windows.Forms.CheckBox();
            this.textBox_updateRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_settings_confirm
            // 
            this.button_settings_confirm.Location = new System.Drawing.Point(91, 107);
            this.button_settings_confirm.Name = "button_settings_confirm";
            this.button_settings_confirm.Size = new System.Drawing.Size(83, 28);
            this.button_settings_confirm.TabIndex = 0;
            this.button_settings_confirm.Text = "Сохранить";
            this.button_settings_confirm.UseVisualStyleBackColor = true;
            this.button_settings_confirm.Click += new System.EventHandler(this.Button_settings_confirm_Click);
            // 
            // label_updateRate
            // 
            this.label_updateRate.AutoSize = true;
            this.label_updateRate.Location = new System.Drawing.Point(12, 15);
            this.label_updateRate.Name = "label_updateRate";
            this.label_updateRate.Size = new System.Drawing.Size(120, 15);
            this.label_updateRate.TabIndex = 1;
            this.label_updateRate.Text = "Частота обновления";
            // 
            // checkBox_formatTags
            // 
            this.checkBox_formatTags.AutoSize = true;
            this.checkBox_formatTags.Location = new System.Drawing.Point(30, 52);
            this.checkBox_formatTags.Name = "checkBox_formatTags";
            this.checkBox_formatTags.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_formatTags.Size = new System.Drawing.Size(208, 19);
            this.checkBox_formatTags.TabIndex = 2;
            this.checkBox_formatTags.Text = "Очистка тегов в описании статей";
            this.checkBox_formatTags.UseVisualStyleBackColor = true;
            // 
            // textBox_updateRate
            // 
            this.textBox_updateRate.Location = new System.Drawing.Point(139, 12);
            this.textBox_updateRate.Name = "textBox_updateRate";
            this.textBox_updateRate.Size = new System.Drawing.Size(113, 23);
            this.textBox_updateRate.TabIndex = 3;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 147);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_updateRate);
            this.Controls.Add(this.checkBox_formatTags);
            this.Controls.Add(this.label_updateRate);
            this.Controls.Add(this.button_settings_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_settings_confirm;
        private System.Windows.Forms.Label label_updateRate;
        private System.Windows.Forms.CheckBox checkBox_formatTags;
        private System.Windows.Forms.TextBox textBox_updateRate;
    }
}