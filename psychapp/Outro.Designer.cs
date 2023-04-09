
namespace psychapp
{
    partial class Outro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outro));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.box = new System.Windows.Forms.RichTextBox();
            this.box2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(134, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(519, 431);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.LightBlue;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box.Location = new System.Drawing.Point(286, 83);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(343, 184);
            this.box.TabIndex = 1;
            this.box.Text = "";
            this.box.TextChanged += new System.EventHandler(this.box_TextChanged);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.LightBlue;
            this.box2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box2.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box2.Location = new System.Drawing.Point(150, 83);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(130, 184);
            this.box2.TabIndex = 2;
            this.box2.Text = "";
            this.box2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(150, 266);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(479, 193);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Outro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.Name = "Outro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Outro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox box;
        private System.Windows.Forms.RichTextBox box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}