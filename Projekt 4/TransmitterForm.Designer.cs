namespace Projekt_4
{
    partial class TransmitterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Converter converter = new Converter();
        ReceiverForm receiver = new ReceiverForm();

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
            this.ASCIILabel = new System.Windows.Forms.Label();
            this.ASCIItextBox = new System.Windows.Forms.TextBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ASCIILabel
            // 
            this.ASCIILabel.AutoSize = true;
            this.ASCIILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ASCIILabel.Location = new System.Drawing.Point(43, 41);
            this.ASCIILabel.Name = "ASCIILabel";
            this.ASCIILabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ASCIILabel.Size = new System.Drawing.Size(101, 45);
            this.ASCIILabel.TabIndex = 0;
            this.ASCIILabel.Text = "ASCII";
            // 
            // ASCIItextBox
            // 
            this.ASCIItextBox.Location = new System.Drawing.Point(51, 94);
            this.ASCIItextBox.Multiline = true;
            this.ASCIItextBox.Name = "ASCIItextBox";
            this.ASCIItextBox.Size = new System.Drawing.Size(419, 131);
            this.ASCIItextBox.TabIndex = 1;
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(51, 347);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.Size = new System.Drawing.Size(419, 131);
            this.binaryTextBox.TabIndex = 3;
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.binaryLabel.Location = new System.Drawing.Point(42, 294);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.binaryLabel.Size = new System.Drawing.Size(202, 45);
            this.binaryLabel.TabIndex = 2;
            this.binaryLabel.Text = "Kod binarny";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(308, 250);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(163, 41);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Konwertuj";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertToBinaryButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(308, 502);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(163, 41);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // TransmitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 581);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.ASCIItextBox);
            this.Controls.Add(this.ASCIILabel);
            this.Name = "TransmitterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransmitterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ASCIILabel;
        private TextBox ASCIItextBox;
        private TextBox binaryTextBox;
        private Label binaryLabel;
        private Button convertButton;
        private Button sendButton;
    }
}