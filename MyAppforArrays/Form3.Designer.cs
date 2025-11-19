namespace MyAppforArrays
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            textBoxa1 = new TextBox();
            textBoxa2 = new TextBox();
            buttonCalc = new Button();
            label5 = new Label();
            textBoxa3 = new TextBox();
            richTextBoxMatrix = new RichTextBox();
            buttonClear = new Button();
            buttonClose = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxRow = new TextBox();
            textBoxCol = new TextBox();
            buttonShowElement = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "a1 = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "a2 = ";
            label2.Click += label2_Click;
            // 
            // textBoxa1
            // 
            textBoxa1.Location = new Point(61, 19);
            textBoxa1.Name = "textBoxa1";
            textBoxa1.Size = new Size(125, 27);
            textBoxa1.TabIndex = 3;
            // 
            // textBoxa2
            // 
            textBoxa2.Location = new Point(61, 60);
            textBoxa2.Name = "textBoxa2";
            textBoxa2.Size = new Size(125, 27);
            textBoxa2.TabIndex = 4;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(201, 19);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(225, 29);
            buttonCalc.TabIndex = 5;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 8;
            label5.Text = "a3 = ";
            // 
            // textBoxa3
            // 
            textBoxa3.Location = new Point(61, 102);
            textBoxa3.Name = "textBoxa3";
            textBoxa3.Size = new Size(125, 27);
            textBoxa3.TabIndex = 9;
            // 
            // richTextBoxMatrix
            // 
            richTextBoxMatrix.Font = new Font("Consolas", 10F);
            richTextBoxMatrix.Location = new Point(445, 19);
            richTextBoxMatrix.Name = "richTextBoxMatrix";
            richTextBoxMatrix.ReadOnly = true;
            richTextBoxMatrix.Size = new Size(183, 111);
            richTextBoxMatrix.TabIndex = 10;
            richTextBoxMatrix.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(201, 60);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(225, 29);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ActiveCaption;
            buttonClose.Location = new Point(201, 101);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(225, 29);
            buttonClose.TabIndex = 12;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 163);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 13;
            label3.Text = "Індекс i:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 196);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 14;
            label4.Text = "Індекс j:";
            // 
            // textBoxRow
            // 
            textBoxRow.Location = new Point(84, 160);
            textBoxRow.Name = "textBoxRow";
            textBoxRow.Size = new Size(51, 27);
            textBoxRow.TabIndex = 15;
            // 
            // textBoxCol
            // 
            textBoxCol.Location = new Point(84, 193);
            textBoxCol.Name = "textBoxCol";
            textBoxCol.Size = new Size(51, 27);
            textBoxCol.TabIndex = 16;
            // 
            // buttonShowElement
            // 
            buttonShowElement.Location = new Point(15, 241);
            buttonShowElement.Name = "buttonShowElement";
            buttonShowElement.Size = new Size(190, 29);
            buttonShowElement.TabIndex = 17;
            buttonShowElement.Text = "Показати елемент";
            buttonShowElement.UseVisualStyleBackColor = true;
            buttonShowElement.Click += buttonShowElement_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 309);
            Controls.Add(buttonShowElement);
            Controls.Add(textBoxCol);
            Controls.Add(textBoxRow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonClose);
            Controls.Add(buttonClear);
            Controls.Add(richTextBoxMatrix);
            Controls.Add(textBoxa3);
            Controls.Add(label5);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxa2);
            Controls.Add(textBoxa1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBoxa1;
        private TextBox textBoxa2;
        private Button buttonCalc;
        private Label label5;
        private TextBox textBoxa3;
        private RichTextBox richTextBoxMatrix;
        private Button buttonClear;
        private Button buttonClose;
        private Label label3;
        private Label label4;
        private TextBox textBoxRow;
        private TextBox textBoxCol;
        private Button buttonShowElement;
    }
}