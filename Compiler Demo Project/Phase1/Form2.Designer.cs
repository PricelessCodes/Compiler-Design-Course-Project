namespace Phase1
{
    partial class Form2
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
            this.RunBox = new System.Windows.Forms.TextBox();
            this.VariableBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunBox
            // 
            this.RunBox.AccessibleName = "RunBox";
            this.RunBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RunBox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBox.ForeColor = System.Drawing.SystemColors.Info;
            this.RunBox.Location = new System.Drawing.Point(12, 12);
            this.RunBox.Multiline = true;
            this.RunBox.Name = "RunBox";
            this.RunBox.ReadOnly = true;
            this.RunBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RunBox.Size = new System.Drawing.Size(735, 321);
            this.RunBox.TabIndex = 0;
            this.RunBox.TextChanged += new System.EventHandler(this.RunBox_TextChanged);
            // 
            // VariableBox
            // 
            this.VariableBox.Location = new System.Drawing.Point(12, 339);
            this.VariableBox.Multiline = true;
            this.VariableBox.Name = "VariableBox";
            this.VariableBox.ReadOnly = true;
            this.VariableBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VariableBox.Size = new System.Drawing.Size(735, 206);
            this.VariableBox.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(759, 557);
            this.Controls.Add(this.VariableBox);
            this.Controls.Add(this.RunBox);
            this.Name = "Form2";
            this.Text = "Compiler";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox RunBox;
        public System.Windows.Forms.TextBox VariableBox;

    }
}