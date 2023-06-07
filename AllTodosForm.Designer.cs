namespace TodoList
{
    partial class AllTodosForm
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
            TodosListView = new ListView();
            IdColumn = new ColumnHeader();
            TitleColumn = new ColumnHeader();
            CompletedColumn = new ColumnHeader();
            AdditionalColumn = new ColumnHeader();
            PriceColumn = new ColumnHeader();
            TodoTypeCombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TodosListView
            // 
            TodosListView.Activation = ItemActivation.OneClick;
            TodosListView.Cursor = Cursors.Hand;
            TodosListView.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TodosListView.FullRowSelect = true;
            TodosListView.GridLines = true;
            TodosListView.HoverSelection = true;
            TodosListView.Location = new Point(42, 214);
            TodosListView.Name = "TodosListView";
            TodosListView.Size = new Size(646, 231);
            TodosListView.TabIndex = 0;
            TodosListView.UseCompatibleStateImageBehavior = false;
            TodosListView.View = View.Details;
            TodosListView.Click += TodosListView_Click;
            // 
            // IdColumn
            // 
            IdColumn.Text = "Id";
            // 
            // TitleColumn
            // 
            TitleColumn.Text = "Tytuł";
            TitleColumn.Width = 170;
            // 
            // CompletedColumn
            // 
            CompletedColumn.Text = "Ukończono";
            CompletedColumn.Width = 100;
            // 
            // AdditionalColumn
            // 
            AdditionalColumn.Width = 170;
            // 
            // PriceColumn
            // 
            PriceColumn.Text = "Cena [PLN]";
            PriceColumn.TextAlign = HorizontalAlignment.Right;
            PriceColumn.Width = 120;
            // 
            // TodoTypeCombobox
            // 
            TodoTypeCombobox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TodoTypeCombobox.FormattingEnabled = true;
            TodoTypeCombobox.Items.AddRange(new object[] { "Do kupienia", "Do szkoły", "Do pracy" });
            TodoTypeCombobox.Location = new Point(42, 141);
            TodoTypeCombobox.Name = "TodoTypeCombobox";
            TodoTypeCombobox.Size = new Size(366, 36);
            TodoTypeCombobox.TabIndex = 1;
            TodoTypeCombobox.SelectedIndexChanged += TodoTypeCombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(352, 54);
            label1.TabIndex = 2;
            label1.Text = "Przeglądaj zadania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 110);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 3;
            label2.Text = "Rodzaj zadania";
            // 
            // AllTodosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 487);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TodoTypeCombobox);
            Controls.Add(TodosListView);
            Name = "AllTodosForm";
            Text = "Przeglądaj zadania";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView TodosListView;
        private ComboBox TodoTypeCombobox;
        private Label label1;
        private Label label2;
        private ColumnHeader IdColumn;
        private ColumnHeader TitleColumn;
        private ColumnHeader AdditionalColumn;
        private ColumnHeader PriceColumn;
        private ColumnHeader CompletedColumn;
    }
}