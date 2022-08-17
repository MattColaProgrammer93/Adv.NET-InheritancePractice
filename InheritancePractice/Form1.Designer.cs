namespace InheritancePractice
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
            this.btnDisplayCandy = new System.Windows.Forms.Button();
            this.lstCandies = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayCandy
            // 
            this.btnDisplayCandy.Location = new System.Drawing.Point(74, 34);
            this.btnDisplayCandy.Name = "btnDisplayCandy";
            this.btnDisplayCandy.Size = new System.Drawing.Size(127, 69);
            this.btnDisplayCandy.TabIndex = 0;
            this.btnDisplayCandy.Text = "Display Candy";
            this.btnDisplayCandy.UseVisualStyleBackColor = true;
            this.btnDisplayCandy.Click += new System.EventHandler(this.btnDisplayCandy_Click);
            // 
            // lstCandies
            // 
            this.lstCandies.FormattingEnabled = true;
            this.lstCandies.ItemHeight = 20;
            this.lstCandies.Location = new System.Drawing.Point(259, 34);
            this.lstCandies.Name = "lstCandies";
            this.lstCandies.Size = new System.Drawing.Size(214, 144);
            this.lstCandies.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(76, 234);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 2;
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.Location = new System.Drawing.Point(283, 234);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(155, 49);
            this.btnClearBoxes.TabIndex = 3;
            this.btnClearBoxes.Text = "Clear TextBoxes";
            this.btnClearBoxes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstCandies);
            this.Controls.Add(this.btnDisplayCandy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplayCandy;
        private ListBox lstCandies;
        private TextBox txtInput;
        private Button btnClearBoxes;
    }
}