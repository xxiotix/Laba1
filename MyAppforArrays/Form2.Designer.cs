namespace MyAppforArrays
{
    partial class Form2
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            elements = new DataGridViewTextBoxColumn();
            label2 = new Label();
            buttonCheck = new Button();
            buttonClear = new Button();
            buttonClose = new Button();
            label3 = new Label();
            buttonCreate = new Button();
            label4 = new Label();
            textBoxIndex = new TextBox();
            buttonShowElement = new Button();
            buttonShowArray = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Розмірність масиву:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { elements });
            dataGridView1.Location = new Point(373, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(176, 426);
            dataGridView1.TabIndex = 2;
            // 
            // elements
            // 
            elements.HeaderText = "Elements";
            elements.MinimumWidth = 6;
            elements.Name = "elements";
            elements.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 106);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 3;
            label2.Text = " ";
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(25, 174);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(325, 29);
            buttonCheck.TabIndex = 4;
            buttonCheck.Text = "Перевірити";
            buttonCheck.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(203, 398);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(147, 29);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.GradientActiveCaption;
            buttonClose.Location = new Point(25, 398);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(156, 29);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 74);
            label3.Name = "label3";
            label3.Size = new Size(296, 20);
            label3.TabIndex = 7;
            label3.Text = "Чи впорядкований масив за спаданням?";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(25, 139);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(325, 29);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Створити масив";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 236);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Індекс:";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(86, 233);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(45, 27);
            textBoxIndex.TabIndex = 10;
            // 
            // buttonShowElement
            // 
            buttonShowElement.Location = new Point(25, 281);
            buttonShowElement.Name = "buttonShowElement";
            buttonShowElement.Size = new Size(156, 29);
            buttonShowElement.TabIndex = 11;
            buttonShowElement.Text = "Показати елемент";
            buttonShowElement.UseVisualStyleBackColor = true;
            buttonShowElement.Click += buttonShowElement_Click;
            // 
            // buttonShowArray
            // 
            buttonShowArray.Location = new Point(203, 281);
            buttonShowArray.Name = "buttonShowArray";
            buttonShowArray.Size = new Size(147, 29);
            buttonShowArray.TabIndex = 12;
            buttonShowArray.Text = "Показати масив";
            buttonShowArray.UseVisualStyleBackColor = true;
            buttonShowArray.Click += buttonShowArray_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(579, 450);
            Controls.Add(buttonShowArray);
            Controls.Add(buttonShowElement);
            Controls.Add(textBoxIndex);
            Controls.Add(label4);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(buttonClose);
            Controls.Add(buttonClear);
            Controls.Add(buttonCheck);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button buttonCheck;
        private DataGridViewTextBoxColumn elements;
        private Button buttonClear;
        private Button buttonClose;
        private Label label3;
        private Button buttonCreate;
        private Label label4;
        private TextBox textBoxIndex;
        private Button buttonShowElement;
        private Button buttonShowArray;
    }
}