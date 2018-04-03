namespace Installer
{
    partial class MainForm
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
            this.BotPanel = new System.Windows.Forms.Panel();
            this.CancleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NextButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BackButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.HeaderLable = new System.Windows.Forms.Label();
            this.FinishButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotPanel
            // 
            this.BotPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotPanel.Controls.Add(this.FinishButton);
            this.BotPanel.Controls.Add(this.BackButton);
            this.BotPanel.Controls.Add(this.NextButton);
            this.BotPanel.Controls.Add(this.CancleButton);
            this.BotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotPanel.Location = new System.Drawing.Point(0, 497);
            this.BotPanel.Name = "BotPanel";
            this.BotPanel.Size = new System.Drawing.Size(900, 44);
            this.BotPanel.TabIndex = 0;
            // 
            // CancleButton
            // 
            this.CancleButton.Depth = 0;
            this.CancleButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancleButton.Location = new System.Drawing.Point(778, 0);
            this.CancleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Primary = true;
            this.CancleButton.Size = new System.Drawing.Size(122, 44);
            this.CancleButton.TabIndex = 0;
            this.CancleButton.Text = "Cancel";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Depth = 0;
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NextButton.Location = new System.Drawing.Point(656, 0);
            this.NextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NextButton.Name = "NextButton";
            this.NextButton.Primary = true;
            this.NextButton.Size = new System.Drawing.Size(122, 44);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Depth = 0;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.Location = new System.Drawing.Point(534, 0);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.Primary = true;
            this.BackButton.Size = new System.Drawing.Size(122, 44);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPanel.BackColor = System.Drawing.Color.White;
            this.ViewPanel.Location = new System.Drawing.Point(0, 65);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(900, 433);
            this.ViewPanel.TabIndex = 1;
            // 
            // HeaderLable
            // 
            this.HeaderLable.AutoSize = true;
            this.HeaderLable.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLable.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLable.Location = new System.Drawing.Point(12, 31);
            this.HeaderLable.Name = "HeaderLable";
            this.HeaderLable.Size = new System.Drawing.Size(0, 20);
            this.HeaderLable.TabIndex = 2;
            // 
            // FinishButton
            // 
            this.FinishButton.Depth = 0;
            this.FinishButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FinishButton.Location = new System.Drawing.Point(412, 0);
            this.FinishButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Primary = true;
            this.FinishButton.Size = new System.Drawing.Size(122, 44);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 541);
            this.Controls.Add(this.HeaderLable);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.BotPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.BotPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BotPanel;
        private MaterialSkin.Controls.MaterialRaisedButton BackButton;
        private MaterialSkin.Controls.MaterialRaisedButton NextButton;
        private MaterialSkin.Controls.MaterialRaisedButton CancleButton;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Label HeaderLable;
        private MaterialSkin.Controls.MaterialRaisedButton FinishButton;
    }
}

