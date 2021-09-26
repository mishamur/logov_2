
namespace lab8dop
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonGreenHorse = new System.Windows.Forms.RadioButton();
            this.radioButtonBlueHorse = new System.Windows.Forms.RadioButton();
            this.radioButtonRedHorse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonGreenHorse);
            this.groupBox1.Controls.Add(this.radioButtonBlueHorse);
            this.groupBox1.Controls.Add(this.radioButtonRedHorse);
            this.groupBox1.Location = new System.Drawing.Point(148, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "На какую лошадь поставите?";
            // 
            // radioButtonGreenHorse
            // 
            this.radioButtonGreenHorse.AutoSize = true;
            this.radioButtonGreenHorse.Location = new System.Drawing.Point(387, 13);
            this.radioButtonGreenHorse.Name = "radioButtonGreenHorse";
            this.radioButtonGreenHorse.Size = new System.Drawing.Size(87, 19);
            this.radioButtonGreenHorse.TabIndex = 2;
            this.radioButtonGreenHorse.TabStop = true;
            this.radioButtonGreenHorse.Text = "GreenHorse";
            this.radioButtonGreenHorse.UseVisualStyleBackColor = true;
            this.radioButtonGreenHorse.CheckedChanged += new System.EventHandler(this.radioButtonGreenHorse_CheckedChanged);
            // 
            // radioButtonBlueHorse
            // 
            this.radioButtonBlueHorse.AutoSize = true;
            this.radioButtonBlueHorse.Location = new System.Drawing.Point(202, 13);
            this.radioButtonBlueHorse.Name = "radioButtonBlueHorse";
            this.radioButtonBlueHorse.Size = new System.Drawing.Size(79, 19);
            this.radioButtonBlueHorse.TabIndex = 1;
            this.radioButtonBlueHorse.TabStop = true;
            this.radioButtonBlueHorse.Text = "BlueHorse";
            this.radioButtonBlueHorse.UseVisualStyleBackColor = true;
            this.radioButtonBlueHorse.CheckedChanged += new System.EventHandler(this.radioButtonBlueHorse_CheckedChanged);
            // 
            // radioButtonRedHorse
            // 
            this.radioButtonRedHorse.AutoSize = true;
            this.radioButtonRedHorse.Checked = true;
            this.radioButtonRedHorse.Location = new System.Drawing.Point(7, 13);
            this.radioButtonRedHorse.Name = "radioButtonRedHorse";
            this.radioButtonRedHorse.Size = new System.Drawing.Size(76, 19);
            this.radioButtonRedHorse.TabIndex = 0;
            this.radioButtonRedHorse.TabStop = true;
            this.radioButtonRedHorse.Text = "RedHorse";
            this.radioButtonRedHorse.UseVisualStyleBackColor = true;
            this.radioButtonRedHorse.CheckedChanged += new System.EventHandler(this.radioButtonRedHorse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonGreenHorse;
        private System.Windows.Forms.RadioButton radioButtonBlueHorse;
        private System.Windows.Forms.RadioButton radioButtonRedHorse;
    }
}

