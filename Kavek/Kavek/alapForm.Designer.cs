namespace Kavek
{
    partial class alapForm
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
            this.szuroformbtn = new System.Windows.Forms.Button();
            this.fooldallabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // szuroformbtn
            // 
            this.szuroformbtn.BackColor = System.Drawing.Color.Tan;
            this.szuroformbtn.Location = new System.Drawing.Point(450, 283);
            this.szuroformbtn.Margin = new System.Windows.Forms.Padding(0);
            this.szuroformbtn.Name = "szuroformbtn";
            this.szuroformbtn.Size = new System.Drawing.Size(279, 137);
            this.szuroformbtn.TabIndex = 0;
            this.szuroformbtn.Text = "Irány szűrni";
            this.szuroformbtn.UseVisualStyleBackColor = false;
            this.szuroformbtn.Click += new System.EventHandler(this.szuroformbtn_Click);
            // 
            // fooldallabel
            // 
            this.fooldallabel.AutoSize = true;
            this.fooldallabel.BackColor = System.Drawing.Color.Tan;
            this.fooldallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fooldallabel.Location = new System.Drawing.Point(34, 48);
            this.fooldallabel.Name = "fooldallabel";
            this.fooldallabel.Size = new System.Drawing.Size(915, 33);
            this.fooldallabel.TabIndex = 1;
            this.fooldallabel.Text = "Egy létező kávézó kávéból adódó forgalma egy adott időszakban";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Image = global::Kavek.Properties.Resources.kaveikon;
            this.pictureBox1.Location = new System.Drawing.Point(521, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // alapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavek.Properties.Resources.kavebab;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fooldallabel);
            this.Controls.Add(this.szuroformbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "alapForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szuroformbtn;
        private System.Windows.Forms.Label fooldallabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

