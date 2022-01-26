namespace Projekt_4
{
    partial class ReceiverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Converter converter = new Converter();
        ObscenitiesHandler obscenitiesHandler = new ObscenitiesHandler();

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
            this.convertButton = new System.Windows.Forms.Button();
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.ASCIILabel = new System.Windows.Forms.Label();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(308, 248);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(163, 41);
            this.convertButton.TabIndex = 10;
            this.convertButton.Text = "Konwertuj";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(51, 345);
            this.ASCIITextBox.Multiline = true;
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.ReadOnly = true;
            this.ASCIITextBox.Size = new System.Drawing.Size(419, 131);
            this.ASCIITextBox.TabIndex = 9;
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ASCIILabel.Location = new System.Drawing.Point(42, 292);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ASCIILabel.Size = new System.Drawing.Size(101, 45);
            this.ASCIILabel.TabIndex = 8;
            this.ASCIILabel.Text = "ASCII";
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(51, 92);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.Size = new System.Drawing.Size(419, 131);
            this.binaryTextBox.TabIndex = 7;
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.binaryLabel.Location = new System.Drawing.Point(43, 39);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.binaryLabel.Size = new System.Drawing.Size(202, 45);
            this.binaryLabel.TabIndex = 6;
            this.binaryLabel.Text = "Kod binarny";
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 581);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.ASCIITextBox);
            this.Controls.Add(this.ASCIILabel);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.binaryLabel);
            this.Name = "ReceiverForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odbiornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button convertButton;
        private TextBox ASCIITextBox;
        private Label ASCIILabel;
        private Label binaryLabel;
        public TextBox binaryTextBox;
    }
}