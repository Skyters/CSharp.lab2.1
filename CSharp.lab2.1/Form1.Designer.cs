namespace CSharp.lab2._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enteringNumber = new TextBox();
            label1 = new Label();
            buttonStart = new Button();
            pictureBox1 = new PictureBox();
            buttonTask = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // enteringNumber
            // 
            enteringNumber.Location = new Point(87, 32);
            enteringNumber.Name = "enteringNumber";
            enteringNumber.Size = new Size(125, 27);
            enteringNumber.TabIndex = 0;
            enteringNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите число от 1 до 9999";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(104, 65);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Запуск";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(4, 65);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(94, 29);
            buttonTask.TabIndex = 5;
            buttonTask.Text = "Задание";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 195);
            Controls.Add(buttonTask);
            Controls.Add(pictureBox1);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Controls.Add(enteringNumber);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox enteringNumber;
        private Label label1;
        private Button buttonStart;
        private PictureBox pictureBox1;
        private Button buttonTask;
    }
}
