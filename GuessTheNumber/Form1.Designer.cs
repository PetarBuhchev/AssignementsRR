namespace GuessTheNumber
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
            button1 = new Button();
            textBoxInput = new TextBox();
            labelUpDown = new Label();
            labelCount = new Label();
            buttonGuess = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(72, 42);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(132, 55);
            button1.TabIndex = 0;
            button1.Text = "Генерирай";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Enabled = false;
            textBoxInput.Location = new Point(257, 90);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(111, 29);
            textBoxInput.TabIndex = 1;
            // 
            // labelUpDown
            // 
            labelUpDown.AutoSize = true;
            labelUpDown.Location = new Point(440, 76);
            labelUpDown.Name = "labelUpDown";
            labelUpDown.Size = new Size(0, 21);
            labelUpDown.TabIndex = 2;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(440, 126);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(0, 21);
            labelCount.TabIndex = 3;
            // 
            // buttonGuess
            // 
            buttonGuess.Location = new Point(72, 109);
            buttonGuess.Margin = new Padding(4);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(132, 55);
            buttonGuess.TabIndex = 4;
            buttonGuess.Text = "Познай";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 236);
            Controls.Add(buttonGuess);
            Controls.Add(labelCount);
            Controls.Add(labelUpDown);
            Controls.Add(textBoxInput);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxInput;
        private Label labelUpDown;
        private Label labelCount;
        private Button buttonGuess;
    }
}