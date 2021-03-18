namespace FastCaracterGenerator
{
    partial class Generator
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
            this.Randomize = new System.Windows.Forms.Button();
            this.FastRender = new System.Windows.Forms.Label();
            this.QuickAccess_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Randomize
            // 
            this.Randomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomize.Location = new System.Drawing.Point(1052, 12);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(120, 50);
            this.Randomize.TabIndex = 0;
            this.Randomize.Text = "Generate";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // FastRender
            // 
            this.FastRender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastRender.AutoSize = true;
            this.FastRender.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastRender.Location = new System.Drawing.Point(12, 65);
            this.FastRender.Name = "FastRender";
            this.FastRender.Size = new System.Drawing.Size(250, 27);
            this.FastRender.TabIndex = 2;
            this.FastRender.Text = "Empty, for now...";
            this.FastRender.Click += new System.EventHandler(this.label2_Click);
            // 
            // QuickAccess_Button
            // 
            this.QuickAccess_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickAccess_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickAccess_Button.Location = new System.Drawing.Point(1052, 499);
            this.QuickAccess_Button.Name = "QuickAccess_Button";
            this.QuickAccess_Button.Size = new System.Drawing.Size(120, 50);
            this.QuickAccess_Button.TabIndex = 3;
            this.QuickAccess_Button.Text = "Save Profile";
            this.QuickAccess_Button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(926, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit Ressources";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuickAccess_Button);
            this.Controls.Add(this.FastRender);
            this.Controls.Add(this.Randomize);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Generator";
            this.Text = "QuickGenerator";
            this.Load += new System.EventHandler(this.Generator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.Label FastRender;
        private System.Windows.Forms.Button QuickAccess_Button;
        private System.Windows.Forms.Button button1;
    }
}

