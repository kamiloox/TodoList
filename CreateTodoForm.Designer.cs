namespace TodoList;

partial class CreateTodoForm
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
        TodoTypeCombobox = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        TodoTitleTextbox = new TextBox();
        label4 = new Label();
        TodoCompletedRadio = new RadioButton();
        TodoNotCompletedRadio = new RadioButton();
        panel1 = new Panel();
        AdditionalTextbox = new TextBox();
        AdditionalLabel = new Label();
        CreateTodoButton = new Button();
        PricePanel = new Panel();
        PriceNumeric = new NumericUpDown();
        label6 = new Label();
        label8 = new Label();
        AdditionalPanel = new Panel();
        panel1.SuspendLayout();
        PricePanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PriceNumeric).BeginInit();
        AdditionalPanel.SuspendLayout();
        SuspendLayout();
        // 
        // TodoTypeCombobox
        // 
        TodoTypeCombobox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        TodoTypeCombobox.FormattingEnabled = true;
        TodoTypeCombobox.Items.AddRange(new object[] { "Do kupienia", "Do szkoły", "Do pracy" });
        TodoTypeCombobox.Location = new Point(36, 113);
        TodoTypeCombobox.Name = "TodoTypeCombobox";
        TodoTypeCombobox.Size = new Size(327, 36);
        TodoTypeCombobox.TabIndex = 0;
        TodoTypeCombobox.SelectedIndexChanged += TodoTypeCombobox_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(36, 18);
        label1.Name = "label1";
        label1.Size = new Size(288, 54);
        label1.TabIndex = 1;
        label1.Text = "Stwórz zadanie";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(36, 82);
        label2.Name = "label2";
        label2.Size = new Size(143, 28);
        label2.TabIndex = 2;
        label2.Text = "Rodzaj zadania";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(36, 188);
        label3.Name = "label3";
        label3.Size = new Size(54, 28);
        label3.TabIndex = 3;
        label3.Text = "Tytuł";
        // 
        // TodoTitleTextbox
        // 
        TodoTitleTextbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        TodoTitleTextbox.Location = new Point(36, 196);
        TodoTitleTextbox.Name = "TodoTitleTextbox";
        TodoTitleTextbox.Size = new Size(327, 34);
        TodoTitleTextbox.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(36, 240);
        label4.Name = "label4";
        label4.Size = new Size(110, 28);
        label4.TabIndex = 5;
        label4.Text = "Ukończone";
        // 
        // TodoCompletedRadio
        // 
        TodoCompletedRadio.AutoSize = true;
        TodoCompletedRadio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        TodoCompletedRadio.Location = new Point(5, 8);
        TodoCompletedRadio.Name = "TodoCompletedRadio";
        TodoCompletedRadio.Size = new Size(58, 32);
        TodoCompletedRadio.TabIndex = 3;
        TodoCompletedRadio.Text = "Tak";
        TodoCompletedRadio.UseVisualStyleBackColor = true;
        // 
        // TodoNotCompletedRadio
        // 
        TodoNotCompletedRadio.AutoSize = true;
        TodoNotCompletedRadio.Checked = true;
        TodoNotCompletedRadio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        TodoNotCompletedRadio.Location = new Point(67, 8);
        TodoNotCompletedRadio.Name = "TodoNotCompletedRadio";
        TodoNotCompletedRadio.Size = new Size(60, 32);
        TodoNotCompletedRadio.TabIndex = 3;
        TodoNotCompletedRadio.TabStop = true;
        TodoNotCompletedRadio.Text = "Nie";
        TodoNotCompletedRadio.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(TodoCompletedRadio);
        panel1.Controls.Add(TodoNotCompletedRadio);
        panel1.Location = new Point(40, 269);
        panel1.Name = "panel1";
        panel1.Size = new Size(185, 43);
        panel1.TabIndex = 2;
        // 
        // AdditionalTextbox
        // 
        AdditionalTextbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        AdditionalTextbox.Location = new Point(29, 40);
        AdditionalTextbox.Name = "AdditionalTextbox";
        AdditionalTextbox.Size = new Size(322, 34);
        AdditionalTextbox.TabIndex = 4;
        // 
        // AdditionalLabel
        // 
        AdditionalLabel.AutoSize = true;
        AdditionalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        AdditionalLabel.Location = new Point(29, 9);
        AdditionalLabel.Name = "AdditionalLabel";
        AdditionalLabel.Size = new Size(120, 28);
        AdditionalLabel.TabIndex = 10;
        AdditionalLabel.Text = "Nazwa firmy";
        // 
        // CreateTodoButton
        // 
        CreateTodoButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        CreateTodoButton.Location = new Point(36, 477);
        CreateTodoButton.Name = "CreateTodoButton";
        CreateTodoButton.Size = new Size(327, 43);
        CreateTodoButton.TabIndex = 6;
        CreateTodoButton.Text = "Stwórz";
        CreateTodoButton.UseVisualStyleBackColor = true;
        CreateTodoButton.Click += CreateTodoButton_Click;
        // 
        // PricePanel
        // 
        PricePanel.Controls.Add(PriceNumeric);
        PricePanel.Controls.Add(label6);
        PricePanel.Location = new Point(12, 387);
        PricePanel.Name = "PricePanel";
        PricePanel.Size = new Size(382, 73);
        PricePanel.TabIndex = 12;
        PricePanel.Visible = false;
        // 
        // PriceNumeric
        // 
        PriceNumeric.DecimalPlaces = 2;
        PriceNumeric.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        PriceNumeric.Increment = new decimal(new int[] { 10, 0, 0, 0 });
        PriceNumeric.Location = new Point(29, 37);
        PriceNumeric.Name = "PriceNumeric";
        PriceNumeric.Size = new Size(322, 34);
        PriceNumeric.TabIndex = 5;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(24, 6);
        label6.Name = "label6";
        label6.Size = new Size(107, 28);
        label6.TabIndex = 1;
        label6.Text = "Cena [PLN]";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(40, 167);
        label8.Name = "label8";
        label8.Size = new Size(54, 28);
        label8.TabIndex = 13;
        label8.Text = "Tytuł";
        // 
        // AdditionalPanel
        // 
        AdditionalPanel.Controls.Add(AdditionalTextbox);
        AdditionalPanel.Controls.Add(AdditionalLabel);
        AdditionalPanel.Location = new Point(12, 307);
        AdditionalPanel.Name = "AdditionalPanel";
        AdditionalPanel.Size = new Size(382, 83);
        AdditionalPanel.TabIndex = 14;
        AdditionalPanel.Visible = false;
        // 
        // CreateTodoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(412, 541);
        Controls.Add(panel1);
        Controls.Add(AdditionalPanel);
        Controls.Add(label8);
        Controls.Add(PricePanel);
        Controls.Add(CreateTodoButton);
        Controls.Add(label4);
        Controls.Add(TodoTitleTextbox);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(TodoTypeCombobox);
        Name = "CreateTodoForm";
        Text = "CreateTodoForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        PricePanel.ResumeLayout(false);
        PricePanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PriceNumeric).EndInit();
        AdditionalPanel.ResumeLayout(false);
        AdditionalPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox TodoTypeCombobox;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox TodoTitleTextbox;
    private Label label4;
    private RadioButton TodoCompletedRadio;
    private RadioButton TodoNotCompletedRadio;
    private Panel panel1;
    private TextBox AdditionalTextbox;
    private Label AdditionalLabel;
    private Button CreateTodoButton;
    private Panel PricePanel;
    private NumericUpDown PriceNumeric;
    private Label label6;
    private Label label8;
    private Panel AdditionalPanel;
}