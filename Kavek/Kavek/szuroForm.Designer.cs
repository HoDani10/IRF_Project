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
            this.fooldalButton = new System.Windows.Forms.Button();
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
            this.kavekdataGridView.Size = new System.Drawing.Size(975, 643);
            this.kavekdataGridView.TabIndex = 0;
            // 
            // visszaallitButton
            // 
            this.visszaallitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visszaallitButton.BackColor = System.Drawing.Color.Tan;
            this.visszaallitButton.Location = new System.Drawing.Point(1023, 14);
            this.visszaallitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visszaallitButton.Name = "visszaallitButton";
            this.visszaallitButton.Size = new System.Drawing.Size(140, 154);
            this.visszaallitButton.TabIndex = 1;
            this.visszaallitButton.Text = "Alaphelyzetbe állít";
            this.visszaallitButton.UseVisualStyleBackColor = false;
            // 
            // dragakButton
            // 
            this.dragakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dragakButton.BackColor = System.Drawing.Color.Tan;
            this.dragakButton.Location = new System.Drawing.Point(1023, 177);
            this.dragakButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dragakButton.Name = "dragakButton";
            this.dragakButton.Size = new System.Drawing.Size(140, 154);
            this.dragakButton.TabIndex = 2;
            this.dragakButton.Text = "Drágák törlése";
            this.dragakButton.UseVisualStyleBackColor = false;
            // 
            // olcsokButton
            // 
            this.olcsokButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.olcsokButton.BackColor = System.Drawing.Color.Tan;
            this.olcsokButton.Location = new System.Drawing.Point(1023, 340);
            this.olcsokButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.olcsokButton.Name = "olcsokButton";
            this.olcsokButton.Size = new System.Drawing.Size(140, 154);
            this.olcsokButton.TabIndex = 3;
            this.olcsokButton.Text = "Olcsók törlése";
            this.olcsokButton.UseVisualStyleBackColor = false;
            // 
            // fooldalButton
            // 
            this.fooldalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fooldalButton.BackColor = System.Drawing.Color.Tan;
            this.fooldalButton.Location = new System.Drawing.Point(1023, 503);
            this.fooldalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fooldalButton.Name = "fooldalButton";
            this.fooldalButton.Size = new System.Drawing.Size(140, 154);
            this.fooldalButton.TabIndex = 4;
            this.fooldalButton.Text = "Vissza a főoldalra";
            this.fooldalButton.UseVisualStyleBackColor = false;
            // 
            // szuroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kavek.Properties.Resources.kavebab;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.fooldalButton);
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
        private System.Windows.Forms.Button fooldalButton;
    }
}