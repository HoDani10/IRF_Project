namespace Kavek
{
    partial class szuroForm
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
            this.kavekdataGridView = new System.Windows.Forms.DataGridView();
            this.visszaallitButton = new System.Windows.Forms.Button();
            this.dragakButton = new System.Windows.Forms.Button();
            this.olcsokButton = new System.Windows.Forms.Button();
            this.decafButton = new System.Windows.Forms.Button();
            this.fogyhelybtn = new System.Windows.Forms.Button();
            this.kiirbtn = new System.Windows.Forms.Button();
            this.topkvbtn = new System.Windows.Forms.Button();
            this.homeButton1 = new Kavek.Entities.homeButton();
            ((System.ComponentModel.ISupportInitialize)(this.kavekdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kavekdataGridView
            // 
            this.kavekdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kavekdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kavekdataGridView.Location = new System.Drawing.Point(13, 19);
            this.kavekdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kavekdataGridView.Name = "kavekdataGridView";
            this.kavekdataGridView.RowHeadersWidth = 62;
            this.kavekdataGridView.Size = new System.Drawing.Size(975, 514);
            this.kavekdataGridView.TabIndex = 0;
            // 
            // visszaallitButton
            // 
            this.visszaallitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visszaallitButton.BackColor = System.Drawing.Color.Tan;
            this.visszaallitButton.Location = new System.Drawing.Point(1023, 29);
            this.visszaallitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visszaallitButton.Name = "visszaallitButton";
            this.visszaallitButton.Size = new System.Drawing.Size(140, 83);
            this.visszaallitButton.TabIndex = 1;
            this.visszaallitButton.Text = "Alaphelyzetbe állít";
            this.visszaallitButton.UseVisualStyleBackColor = false;
            this.visszaallitButton.Click += new System.EventHandler(this.visszaallitButton_Click);
            // 
            // dragakButton
            // 
            this.dragakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dragakButton.BackColor = System.Drawing.Color.Tan;
            this.dragakButton.Location = new System.Drawing.Point(1023, 122);
            this.dragakButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dragakButton.Name = "dragakButton";
            this.dragakButton.Size = new System.Drawing.Size(140, 79);
            this.dragakButton.TabIndex = 2;
            this.dragakButton.Text = "Drágák törlése";
            this.dragakButton.UseVisualStyleBackColor = false;
            this.dragakButton.Click += new System.EventHandler(this.dragakButton_Click);
            // 
            // olcsokButton
            // 
            this.olcsokButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.olcsokButton.BackColor = System.Drawing.Color.Tan;
            this.olcsokButton.Location = new System.Drawing.Point(1023, 211);
            this.olcsokButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.olcsokButton.Name = "olcsokButton";
            this.olcsokButton.Size = new System.Drawing.Size(140, 73);
            this.olcsokButton.TabIndex = 3;
            this.olcsokButton.Text = "Olcsók törlése";
            this.olcsokButton.UseVisualStyleBackColor = false;
            this.olcsokButton.Click += new System.EventHandler(this.olcsokButton_Click);
            // 
            // decafButton
            // 
            this.decafButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decafButton.BackColor = System.Drawing.Color.Tan;
            this.decafButton.Location = new System.Drawing.Point(1023, 294);
            this.decafButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decafButton.Name = "decafButton";
            this.decafButton.Size = new System.Drawing.Size(140, 73);
            this.decafButton.TabIndex = 5;
            this.decafButton.Text = "Koffeinmenteseket mutasd!";
            this.decafButton.UseVisualStyleBackColor = false;
            this.decafButton.Click += new System.EventHandler(this.decafButton_Click);
            // 
            // fogyhelybtn
            // 
            this.fogyhelybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fogyhelybtn.BackColor = System.Drawing.Color.Tan;
            this.fogyhelybtn.Location = new System.Drawing.Point(1023, 377);
            this.fogyhelybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fogyhelybtn.Name = "fogyhelybtn";
            this.fogyhelybtn.Size = new System.Drawing.Size(140, 73);
            this.fogyhelybtn.TabIndex = 6;
            this.fogyhelybtn.Text = "Csak a helyben fogyasztottakat mutasd!";
            this.fogyhelybtn.UseVisualStyleBackColor = false;
            this.fogyhelybtn.Click += new System.EventHandler(this.fogyhelybtn_Click);
            // 
            // kiirbtn
            // 
            this.kiirbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kiirbtn.BackColor = System.Drawing.Color.Sienna;
            this.kiirbtn.Location = new System.Drawing.Point(183, 569);
            this.kiirbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kiirbtn.Name = "kiirbtn";
            this.kiirbtn.Size = new System.Drawing.Size(140, 73);
            this.kiirbtn.TabIndex = 7;
            this.kiirbtn.Text = "Fájlbaírás";
            this.kiirbtn.UseVisualStyleBackColor = false;
            this.kiirbtn.Click += new System.EventHandler(this.kiirbtn_Click);
            // 
            // topkvbtn
            // 
            this.topkvbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topkvbtn.BackColor = System.Drawing.Color.Tan;
            this.topkvbtn.Location = new System.Drawing.Point(362, 569);
            this.topkvbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topkvbtn.Name = "topkvbtn";
            this.topkvbtn.Size = new System.Drawing.Size(140, 73);
            this.topkvbtn.TabIndex = 8;
            this.topkvbtn.Text = "Legtöbbet fogyasztott kávé";
            this.topkvbtn.UseVisualStyleBackColor = false;
            this.topkvbtn.Click += new System.EventHandler(this.topkvbtn_Click);
            // 
            // homeButton1
            // 
            this.homeButton1.BackColor = System.Drawing.Color.Brown;
            this.homeButton1.Location = new System.Drawing.Point(13, 569);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(140, 73);
            this.homeButton1.TabIndex = 9;
            this.homeButton1.Text = "Home";
            this.homeButton1.UseVisualStyleBackColor = false;
            this.homeButton1.Click += new System.EventHandler(this.homeButton1_Click);
            // 
            // szuroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavek.Properties.Resources.kavebab;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.topkvbtn);
            this.Controls.Add(this.kiirbtn);
            this.Controls.Add(this.fogyhelybtn);
            this.Controls.Add(this.decafButton);
            this.Controls.Add(this.olcsokButton);
            this.Controls.Add(this.dragakButton);
            this.Controls.Add(this.visszaallitButton);
            this.Controls.Add(this.kavekdataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "szuroForm";
            this.Text = "szuroForm";
            ((System.ComponentModel.ISupportInitialize)(this.kavekdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kavekdataGridView;
        private System.Windows.Forms.Button visszaallitButton;
        private System.Windows.Forms.Button dragakButton;
        private System.Windows.Forms.Button olcsokButton;
        private System.Windows.Forms.Button decafButton;
        private System.Windows.Forms.Button fogyhelybtn;
        private System.Windows.Forms.Button kiirbtn;
        private System.Windows.Forms.Button topkvbtn;
        private Entities.homeButton homeButton1;
    }
}