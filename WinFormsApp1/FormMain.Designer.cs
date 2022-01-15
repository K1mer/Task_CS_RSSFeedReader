
namespace Task2
{
    partial class FormMain
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
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.button_ch_close = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_ch_add = new System.Windows.Forms.Button();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.MaximumSize = new System.Drawing.Size(800, 413);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(800, 413);
            this.tabControl_main.TabIndex = 0;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.button_ch_close);
            this.pnl_bottom.Controls.Add(this.button_settings);
            this.pnl_bottom.Controls.Add(this.button_ch_add);
            this.pnl_bottom.Location = new System.Drawing.Point(4, 415);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(793, 33);
            this.pnl_bottom.TabIndex = 1;
            // 
            // button_ch_close
            // 
            this.button_ch_close.Location = new System.Drawing.Point(123, 3);
            this.button_ch_close.Name = "button_ch_close";
            this.button_ch_close.Size = new System.Drawing.Size(153, 27);
            this.button_ch_close.TabIndex = 2;
            this.button_ch_close.Text = "Удалить текущий канал";
            this.button_ch_close.UseVisualStyleBackColor = true;
            this.button_ch_close.Click += new System.EventHandler(this.Button_ch_close_Click);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(687, 3);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(103, 27);
            this.button_settings.TabIndex = 1;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.Button_settings_Click);
            // 
            // button_ch_add
            // 
            this.button_ch_add.Location = new System.Drawing.Point(3, 3);
            this.button_ch_add.Name = "button_ch_add";
            this.button_ch_add.Size = new System.Drawing.Size(114, 27);
            this.button_ch_add.TabIndex = 0;
            this.button_ch_add.Text = "Добавить канал";
            this.button_ch_add.UseVisualStyleBackColor = true;
            this.button_ch_add.Click += new System.EventHandler(this.Button_ch_add_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Task 2 - RSS Reader";
            this.pnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_ch_add;
        private System.Windows.Forms.Button button_ch_close;
    }
}

