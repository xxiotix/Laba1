namespace MyAppforArrays
{
    partial class Form4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonClear1 = new Button();
            labelResult1 = new Label();
            buttonCalc = new Button();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            labelResult2 = new Label();
            buttonClear2 = new Button();
            buttonCheck = new Button();
            textBoxB2 = new TextBox();
            textBoxA2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            buttonClose = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(436, 249);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonClear1);
            tabPage1.Controls.Add(labelResult1);
            tabPage1.Controls.Add(buttonCalc);
            tabPage1.Controls.Add(textBoxC);
            tabPage1.Controls.Add(textBoxB);
            tabPage1.Controls.Add(textBoxA);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(428, 216);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClear1
            // 
            buttonClear1.Location = new Point(243, 18);
            buttonClear1.Name = "buttonClear1";
            buttonClear1.Size = new Size(115, 29);
            buttonClear1.TabIndex = 8;
            buttonClear1.Text = "Очистити";
            buttonClear1.UseVisualStyleBackColor = true;
            buttonClear1.Click += buttonClear1_Click;
            // 
            // labelResult1
            // 
            labelResult1.AutoSize = true;
            labelResult1.Location = new Point(122, 64);
            labelResult1.Name = "labelResult1";
            labelResult1.Size = new Size(13, 20);
            labelResult1.TabIndex = 7;
            labelResult1.Text = " ";
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(122, 18);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(115, 29);
            buttonCalc.TabIndex = 6;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(47, 92);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(42, 27);
            textBoxC.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(47, 57);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(42, 27);
            textBoxB.TabIndex = 4;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(47, 19);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(42, 27);
            textBoxA.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 95);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 2;
            label3.Text = "c:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 1;
            label2.Text = "b:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 0;
            label1.Text = "a:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelResult2);
            tabPage2.Controls.Add(buttonClear2);
            tabPage2.Controls.Add(buttonCheck);
            tabPage2.Controls.Add(textBoxB2);
            tabPage2.Controls.Add(textBoxA2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(428, 216);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelResult2
            // 
            labelResult2.AutoSize = true;
            labelResult2.Location = new Point(114, 55);
            labelResult2.Name = "labelResult2";
            labelResult2.Size = new Size(13, 20);
            labelResult2.TabIndex = 6;
            labelResult2.Text = " ";
            // 
            // buttonClear2
            // 
            buttonClear2.Location = new Point(236, 14);
            buttonClear2.Name = "buttonClear2";
            buttonClear2.Size = new Size(118, 29);
            buttonClear2.TabIndex = 5;
            buttonClear2.Text = "Очистити";
            buttonClear2.UseVisualStyleBackColor = true;
            buttonClear2.Click += buttonClear2_Click;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(112, 13);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(118, 29);
            buttonCheck.TabIndex = 4;
            buttonCheck.Text = "Розрахувати";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // textBoxB2
            // 
            textBoxB2.Location = new Point(43, 54);
            textBoxB2.Name = "textBoxB2";
            textBoxB2.Size = new Size(44, 27);
            textBoxB2.TabIndex = 3;
            // 
            // textBoxA2
            // 
            textBoxA2.Location = new Point(43, 14);
            textBoxA2.Name = "textBoxA2";
            textBoxA2.Size = new Size(44, 27);
            textBoxA2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 54);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 1;
            label6.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 17);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 0;
            label5.Text = "a:";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(16, 267);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(428, 29);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 305);
            Controls.Add(buttonClose);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "Form4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCalc;
        private Label labelResult1;
        private Label label6;
        private Label label5;
        private Button buttonClear1;
        private Label labelResult2;
        private Button buttonClear2;
        private Button buttonCheck;
        private TextBox textBoxB2;
        private TextBox textBoxA2;
        private Button buttonClose;
    }
}