﻿namespace TodoList
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            CreateTodoButton = new Button();
            label1 = new Label();
            ShowTodosButton = new Button();
            pictureBox1 = new PictureBox();
            fontDialog1 = new FontDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CreateTodoButton
            // 
            CreateTodoButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTodoButton.Location = new Point(76, 252);
            CreateTodoButton.Name = "CreateTodoButton";
            CreateTodoButton.Size = new Size(282, 128);
            CreateTodoButton.TabIndex = 0;
            CreateTodoButton.Text = "Stwórz zadanie";
            CreateTodoButton.UseVisualStyleBackColor = true;
            CreateTodoButton.Click += CreateTodoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(314, 84);
            label1.Name = "label1";
            label1.Size = new Size(333, 72);
            label1.TabIndex = 1;
            label1.Text = "Zadaniownik";
            // 
            // ShowTodosButton
            // 
            ShowTodosButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ShowTodosButton.Location = new Point(435, 252);
            ShowTodosButton.Name = "ShowTodosButton";
            ShowTodosButton.Size = new Size(284, 128);
            ShowTodosButton.TabIndex = 2;
            ShowTodosButton.Text = "Przeglądaj zadania";
            ShowTodosButton.UseVisualStyleBackColor = true;
            ShowTodosButton.Click += ShowTodosButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(113, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(ShowTodosButton);
            Controls.Add(label1);
            Controls.Add(CreateTodoButton);
            Name = "MenuForm";
            Text = "Zadaniownik";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateTodoButton;
        private Label label1;
        private Button ShowTodosButton;
        private PictureBox pictureBox1;
        private FontDialog fontDialog1;
    }
}