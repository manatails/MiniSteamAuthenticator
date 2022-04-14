
namespace MiniSteamAuthenticator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lCurrentCode = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.pbRemainingTime = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lCurrentCode
            // 
            this.lCurrentCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentCode.Location = new System.Drawing.Point(22, 19);
            this.lCurrentCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCurrentCode.Name = "lCurrentCode";
            this.lCurrentCode.Size = new System.Drawing.Size(300, 80);
            this.lCurrentCode.TabIndex = 0;
            this.lCurrentCode.Text = "-----";
            this.lCurrentCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(132, 140);
            this.bClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(80, 26);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pbRemainingTime
            // 
            this.pbRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRemainingTime.Location = new System.Drawing.Point(22, 110);
            this.pbRemainingTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRemainingTime.Maximum = 29;
            this.pbRemainingTime.Name = "pbRemainingTime";
            this.pbRemainingTime.Size = new System.Drawing.Size(300, 18);
            this.pbRemainingTime.Step = 1;
            this.pbRemainingTime.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.pbRemainingTime);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lCurrentCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MiniSteamAuthenticator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lCurrentCode;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ProgressBar pbRemainingTime;
    }
}

