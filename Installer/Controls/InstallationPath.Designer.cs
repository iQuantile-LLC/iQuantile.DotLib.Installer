namespace Installer.Controls
{
    partial class InstallationPath
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
            this.FilePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DesktopCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.StarttMenuCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.BrowseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePath.Depth = 0;
            this.FilePath.Hint = "";
            this.FilePath.Location = new System.Drawing.Point(144, 242);
            this.FilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilePath.Name = "FilePath";
            this.FilePath.PasswordChar = '\0';
            this.FilePath.SelectedText = "";
            this.FilePath.SelectionLength = 0;
            this.FilePath.SelectionStart = 0;
            this.FilePath.Size = new System.Drawing.Size(386, 23);
            this.FilePath.TabIndex = 0;
            this.FilePath.Text = "C:\\Program Files";
            this.FilePath.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(140, 201);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Install Directory";
            // 
            // DesktopCheck
            // 
            this.DesktopCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DesktopCheck.AutoSize = true;
            this.DesktopCheck.Depth = 0;
            this.DesktopCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.DesktopCheck.Location = new System.Drawing.Point(144, 282);
            this.DesktopCheck.Margin = new System.Windows.Forms.Padding(0);
            this.DesktopCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DesktopCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.DesktopCheck.Name = "DesktopCheck";
            this.DesktopCheck.Ripple = true;
            this.DesktopCheck.Size = new System.Drawing.Size(155, 30);
            this.DesktopCheck.TabIndex = 2;
            this.DesktopCheck.Text = "Create Desktop Icon";
            this.DesktopCheck.UseVisualStyleBackColor = true;
            this.DesktopCheck.CheckedChanged += new System.EventHandler(this.DesktopCheck_CheckedChanged);
            // 
            // StarttMenuCheck
            // 
            this.StarttMenuCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarttMenuCheck.AutoSize = true;
            this.StarttMenuCheck.Depth = 0;
            this.StarttMenuCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.StarttMenuCheck.Location = new System.Drawing.Point(325, 282);
            this.StarttMenuCheck.Margin = new System.Windows.Forms.Padding(0);
            this.StarttMenuCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StarttMenuCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.StarttMenuCheck.Name = "StarttMenuCheck";
            this.StarttMenuCheck.Ripple = true;
            this.StarttMenuCheck.Size = new System.Drawing.Size(171, 30);
            this.StarttMenuCheck.TabIndex = 3;
            this.StarttMenuCheck.Text = "Create Start menu icon";
            this.StarttMenuCheck.UseVisualStyleBackColor = true;
            this.StarttMenuCheck.CheckedChanged += new System.EventHandler(this.StarttMenuCheck_CheckedChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrowseButton.Depth = 0;
            this.BrowseButton.Location = new System.Drawing.Point(545, 231);
            this.BrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Primary = true;
            this.BrowseButton.Size = new System.Drawing.Size(165, 34);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // InstallationPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.StarttMenuCheck);
            this.Controls.Add(this.DesktopCheck);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.FilePath);
            this.Name = "InstallationPath";
            this.Size = new System.Drawing.Size(827, 546);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField FilePath;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox DesktopCheck;
        private MaterialSkin.Controls.MaterialCheckBox StarttMenuCheck;
        private MaterialSkin.Controls.MaterialRaisedButton BrowseButton;
    }
}
