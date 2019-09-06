namespace Random_WindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMinNumber = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMinNumber = new System.Windows.Forms.TextBox();
            this.lblMaxNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.lblFollowme = new System.Windows.Forms.Label();
            this.btnLinkYoutube = new System.Windows.Forms.Button();
            this.btnLinkGitHub = new System.Windows.Forms.Button();
            this.btnLinkFacebook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinNumber
            // 
            this.lblMinNumber.AutoSize = true;
            this.lblMinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinNumber.Location = new System.Drawing.Point(38, 25);
            this.lblMinNumber.Name = "lblMinNumber";
            this.lblMinNumber.Size = new System.Drawing.Size(83, 32);
            this.lblMinNumber.TabIndex = 0;
            this.lblMinNumber.Text = "Min  :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(92, 193);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(161, 42);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMinNumber
            // 
            this.txtMinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinNumber.Location = new System.Drawing.Point(155, 25);
            this.txtMinNumber.Multiline = true;
            this.txtMinNumber.Name = "txtMinNumber";
            this.txtMinNumber.Size = new System.Drawing.Size(137, 32);
            this.txtMinNumber.TabIndex = 2;
            this.txtMinNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinNumber_KeyPress);
            // 
            // lblMaxNumber
            // 
            this.lblMaxNumber.AutoSize = true;
            this.lblMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNumber.Location = new System.Drawing.Point(38, 81);
            this.lblMaxNumber.Name = "lblMaxNumber";
            this.lblMaxNumber.Size = new System.Drawing.Size(83, 32);
            this.lblMaxNumber.TabIndex = 3;
            this.lblMaxNumber.Text = "Max :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(38, 135);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(111, 32);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result :";
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxNumber.Location = new System.Drawing.Point(155, 81);
            this.txtMaxNumber.Multiline = true;
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(137, 32);
            this.txtMaxNumber.TabIndex = 5;
            this.txtMaxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxNumber_KeyPress);
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDisplayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.Location = new System.Drawing.Point(156, 135);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(136, 32);
            this.lblDisplayResult.TabIndex = 11;
            // 
            // lblFollowme
            // 
            this.lblFollowme.AutoSize = true;
            this.lblFollowme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowme.Location = new System.Drawing.Point(124, 253);
            this.lblFollowme.Name = "lblFollowme";
            this.lblFollowme.Size = new System.Drawing.Size(100, 25);
            this.lblFollowme.TabIndex = 15;
            this.lblFollowme.Text = "Follow me";
            // 
            // btnLinkYoutube
            // 
            this.btnLinkYoutube.AutoSize = true;
            this.btnLinkYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkYoutube.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLinkYoutube.Image = global::Random_WindowsForms.Properties.Resources.icons8_Play_Button_48px;
            this.btnLinkYoutube.Location = new System.Drawing.Point(253, 281);
            this.btnLinkYoutube.Name = "btnLinkYoutube";
            this.btnLinkYoutube.Size = new System.Drawing.Size(58, 58);
            this.btnLinkYoutube.TabIndex = 16;
            this.btnLinkYoutube.UseVisualStyleBackColor = true;
            this.btnLinkYoutube.Click += new System.EventHandler(this.btnLinkYoutube_Click);
            // 
            // btnLinkGitHub
            // 
            this.btnLinkGitHub.AutoSize = true;
            this.btnLinkGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkGitHub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLinkGitHub.Image = global::Random_WindowsForms.Properties.Resources.icons8_github_filled_50;
            this.btnLinkGitHub.Location = new System.Drawing.Point(143, 281);
            this.btnLinkGitHub.Name = "btnLinkGitHub";
            this.btnLinkGitHub.Size = new System.Drawing.Size(58, 58);
            this.btnLinkGitHub.TabIndex = 13;
            this.btnLinkGitHub.UseVisualStyleBackColor = true;
            this.btnLinkGitHub.Click += new System.EventHandler(this.btnLinkGitHub_Click);
            // 
            // btnLinkFacebook
            // 
            this.btnLinkFacebook.AutoSize = true;
            this.btnLinkFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkFacebook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLinkFacebook.Image = global::Random_WindowsForms.Properties.Resources.icons8_Facebook_48px;
            this.btnLinkFacebook.Location = new System.Drawing.Point(27, 281);
            this.btnLinkFacebook.Name = "btnLinkFacebook";
            this.btnLinkFacebook.Size = new System.Drawing.Size(58, 58);
            this.btnLinkFacebook.TabIndex = 12;
            this.btnLinkFacebook.UseVisualStyleBackColor = true;
            this.btnLinkFacebook.Click += new System.EventHandler(this.btnLinkFacebook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.Controls.Add(this.btnLinkYoutube);
            this.Controls.Add(this.lblFollowme);
            this.Controls.Add(this.btnLinkGitHub);
            this.Controls.Add(this.btnLinkFacebook);
            this.Controls.Add(this.lblDisplayResult);
            this.Controls.Add(this.txtMaxNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMaxNumber);
            this.Controls.Add(this.txtMinNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblMinNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random v19.09";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtMinNumber;
        private System.Windows.Forms.Label lblMaxNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Label lblDisplayResult;
        private System.Windows.Forms.Button btnLinkFacebook;
        private System.Windows.Forms.Button btnLinkGitHub;
        private System.Windows.Forms.Label lblFollowme;
        private System.Windows.Forms.Button btnLinkYoutube;
    }
}

