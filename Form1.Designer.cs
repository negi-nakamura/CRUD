namespace CRUD
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
            layout = new TableLayoutPanel();
            actions = new FlowLayoutPanel();
            studentId = new TextBox();
            username = new TextBox();
            age = new TextBox();
            findButton = new Button();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            search = new TextBox();
            searchButton = new Button();
            showAllButton = new Button();
            students = new DataGridView();
            status = new Label();
            layout.SuspendLayout();
            actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)students).BeginInit();
            SuspendLayout();
            layout.Name = "layout";
            actions.Name = "actions";
            studentId.Name = "studentId";
            username.Name = "username";
            age.Name = "age";
            findButton.Name = "findButton";
            addButton.Name = "addButton";
            updateButton.Name = "updateButton";
            deleteButton.Name = "deleteButton";
            search.Name = "search";
            searchButton.Name = "searchButton";
            showAllButton.Name = "showAllButton";
            students.Name = "students";
            status.Name = "status";
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.Controls.Add(actions, 0, 0);
            layout.Controls.Add(students, 0, 1);
            layout.Controls.Add(status, 0, 2);
            actions.Dock = DockStyle.Fill;
            actions.AutoSize = true;
            actions.Padding = new Padding(8);
            actions.Controls.Add(studentId);
            studentId.TabIndex = 0;
            actions.Controls.Add(username);
            username.TabIndex = 1;
            actions.Controls.Add(age);
            age.TabIndex = 2;
            actions.Controls.Add(findButton);
            findButton.TabIndex = 3;
            actions.Controls.Add(addButton);
            addButton.TabIndex = 4;
            actions.Controls.Add(updateButton);
            updateButton.TabIndex = 5;
            actions.Controls.Add(deleteButton);
            deleteButton.TabIndex = 6;
            actions.Controls.Add(search);
            search.TabIndex = 7;
            actions.Controls.Add(searchButton);
            searchButton.TabIndex = 8;
            actions.Controls.Add(showAllButton);
            showAllButton.TabIndex = 9;
            studentId.Size = new Size(65, 23);
            studentId.PlaceholderText = "Student ID";
            studentId.AccessibleName = "Student ID";
            username.Size = new Size(155, 23);
            username.PlaceholderText = "Username";
            username.AccessibleName = "Username";
            age.Size = new Size(55, 23);
            age.PlaceholderText = "Age";
            age.AccessibleName = "Age";
            search.Size = new Size(155, 23);
            search.PlaceholderText = "Search username";
            search.AccessibleName = "Search username";
            findButton.Text = "Find by ID";
            findButton.AutoSize = true;
            findButton.Click += findButton_Click;
            addButton.Text = "Add";
            addButton.AutoSize = true;
            addButton.Click += addButton_Click;
            updateButton.Text = "Update";
            updateButton.AutoSize = true;
            updateButton.Click += updateButton_Click;
            deleteButton.Text = "Delete";
            deleteButton.AutoSize = true;
            deleteButton.Click += deleteButton_Click;
            searchButton.Text = "Search";
            searchButton.AutoSize = true;
            searchButton.Click += searchButton_Click;
            showAllButton.Text = "Show all";
            showAllButton.AutoSize = true;
            showAllButton.Click += showAllButton_Click;
            students.Dock = DockStyle.Fill;
            students.ReadOnly = true;
            students.AllowUserToAddRows = false;
            students.MultiSelect = false;
            students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            students.CellClick += students_CellClick;
            status.Dock = DockStyle.Fill;
            status.AutoSize = true;
            status.Padding = new Padding(8);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(layout);
            Name = "Form1";
            Text = "Student Records";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)students).EndInit();
            actions.ResumeLayout(false);
            actions.PerformLayout();
            layout.ResumeLayout(false);
            layout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layout;
        private FlowLayoutPanel actions;
        private TextBox studentId;
        private TextBox username;
        private TextBox age;
        private Button findButton;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private TextBox search;
        private Button searchButton;
        private Button showAllButton;
        private DataGridView students;
        private Label status;
    }
}
