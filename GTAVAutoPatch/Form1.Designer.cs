
namespace GTAVAutoPatch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCSharp = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxGTAV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Path To Project";
            // 
            // txtBoxCSharp
            // 
            this.txtBoxCSharp.Location = new System.Drawing.Point(15, 25);
            this.txtBoxCSharp.Name = "txtBoxCSharp";
            this.txtBoxCSharp.Size = new System.Drawing.Size(176, 23);
            this.txtBoxCSharp.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFile.BackgroundImage")));
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFile.Location = new System.Drawing.Point(197, 22);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(29, 23);
            this.btnFile.TabIndex = 2;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(197, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxGTAV
            // 
            this.txtBoxGTAV.Location = new System.Drawing.Point(15, 66);
            this.txtBoxGTAV.Name = "txtBoxGTAV";
            this.txtBoxGTAV.Size = new System.Drawing.Size(176, 23);
            this.txtBoxGTAV.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Put Files In Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Path To GTA V";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(235, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxGTAV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtBoxCSharp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GTA V Auto Patch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCSharp;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxGTAV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

