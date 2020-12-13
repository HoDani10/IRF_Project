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
            this.kavekdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kavekdataGridView.Location = new System.Drawing.Point(12, 12);
            this.kavekdataGridView.Name = "kavekdataGridView";
            this.kavekdataGridView.Size = new System.Drawing.Size(677, 426);
            this.kavekdataGridView.TabIndex = 0;
            // 
            // visszaallitButton
            // 
            this.visszaallitButton.Location = new System.Drawing.Point(695, 16);
            this.visszaallitButton.Name = "visszaallitButton";
            this.visszaallitButton.Size = new System.Drawing.Size(93, 100);
            this.visszaallitButton.TabIndex = 1;
            this.visszaallitButton.Text = "Alaphelyzetbe állít";
            this.visszaallitButton.UseVisualStyleBackColor = true;
            // 
            // dragakButton
            // 
            this.dragakButton.Location = new System.Drawing.Point(695, 122);
            this.dragakButton.Name = "dragakButton";
            this.dragakButton.Size = new System.Drawing.Size(93, 100);
            this.dragakButton.TabIndex = 2;
            this.dragakButton.Text = "Drágák törlése";
            this.dragakButton.UseVisualStyleBackColor = true;
            // 
            // olcsokButton
            // 
            this.olcsokButton.Location = new System.Drawing.Point(695, 228);
            this.olcsokButton.Name = "olcsokButton";
            this.olcsokButton.Size = new System.Drawing.Size(93, 100);
            this.olcsokButton.TabIndex = 3;
            this.olcsokButton.Text = "Olcsók törlése";
            this.olcsokButton.UseVisualStyleBackColor = true;
            // 
            // fooldalButton
            // 
            this.fooldalButton.Location = new System.Drawing.Point(695, 334);
            this.fooldalButton.Name = "fooldalButton";
            this.fooldalButton.Size = new System.Drawing.Size(93, 100);
            this.fooldalButton.TabIndex = 4;
            this.fooldalButton.Text = "Vissza a főoldalra";
            this.fooldalButton.UseVisualStyleBackColor = true;
            // 
            // szuroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fooldalButton);
            this.Controls.Add(this.olcsokButton);
            this.Controls.Add(this.dragakButton);
            this.Controls.Add(this.visszaallitButton);
            this.Controls.Add(this.kavekdataGridView);
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