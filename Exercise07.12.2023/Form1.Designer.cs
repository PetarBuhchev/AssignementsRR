namespace Exercise07._12._2023
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
            textBoxInput = new TextBox();
            labelOutput = new Label();
            buttonTypeNumberAsText = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.Location = new Point(62, 24);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.RightToLeft = RightToLeft.Yes;
            textBoxInput.Size = new Size(109, 29);
            textBoxInput.TabIndex = 0;
            // 
            // labelOutput
            // 
            labelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(220, 24);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(105, 29);
            labelOutput.TabIndex = 1;
            // 
            // buttonTypeNumberAsText
            // 
            buttonTypeNumberAsText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTypeNumberAsText.Location = new Point(62, 109);
            buttonTypeNumberAsText.Name = "buttonTypeNumberAsText";
            buttonTypeNumberAsText.Size = new Size(109, 59);
            buttonTypeNumberAsText.TabIndex = 2;
            buttonTypeNumberAsText.Text = "Изпиши";
            buttonTypeNumberAsText.UseVisualStyleBackColor = true;
            buttonTypeNumberAsText.Click += buttonTypeNumberAsText_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(220, 109);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(105, 59);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Изчисти";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonTypeNumberAsText;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClear;
            ClientSize = new Size(378, 194);
            Controls.Add(buttonClear);
            Controls.Add(buttonTypeNumberAsText);
            Controls.Add(labelOutput);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Число като дума";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Label labelOutput;
        private Button buttonTypeNumberAsText;
        private Button buttonClear;
    }
}