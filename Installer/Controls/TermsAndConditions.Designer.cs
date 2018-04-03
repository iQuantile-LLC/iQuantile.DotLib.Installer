namespace Installer.Controls
{
    partial class TermsAndConditions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgreeCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AgreeCheckbox
            // 
            this.AgreeCheckbox.AutoSize = true;
            this.AgreeCheckbox.Depth = 0;
            this.AgreeCheckbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AgreeCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AgreeCheckbox.Location = new System.Drawing.Point(0, 504);
            this.AgreeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.AgreeCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AgreeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgreeCheckbox.Name = "AgreeCheckbox";
            this.AgreeCheckbox.Ripple = true;
            this.AgreeCheckbox.Size = new System.Drawing.Size(750, 30);
            this.AgreeCheckbox.TabIndex = 0;
            this.AgreeCheckbox.Text = "I Agree ";
            this.AgreeCheckbox.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(750, 504);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TermsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AgreeCheckbox);
            this.Name = "TermsAndConditions";
            this.Size = new System.Drawing.Size(750, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox AgreeCheckbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
