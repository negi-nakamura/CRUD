using CRUD.Repository;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private readonly StudentRepository repository = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            LoadStudents();
        }

        private void students_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && students.Rows[e.RowIndex].DataBoundItem is StudentRepository.Student student)
                ShowStudent(student);
        }

        private void findButton_Click(object? sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(studentId.Text);

                var student = repository.GetStudent(id);

                if (student == null)
                {
                    status.Text = "Student not found.";
                    return;
                }

                ShowStudent(student);
                status.Text = $"Found {student.Username}.";
            }
            catch (Exception ex) when (ex is FormatException or OverflowException)
            {
                status.Text = ex.Message;
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object? sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(studentId.Text);

                string name = username.Text.Trim();

                int years = int.Parse(age.Text);

                int rows = repository.InsertStudent(id, name, years);

                if (rows == 0)
                {
                    status.Text = "No student record was saved.";
                    return;
                }

                string message = $"Added student {id}: {name} (age {years}).";
                MessageBox.Show(this, message, Text);
                LoadStudents(message);
            }
            catch (Exception ex) when (ex is FormatException or OverflowException)
            {
                status.Text = ex.Message;
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object? sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(studentId.Text);

                string name = username.Text.Trim();
                int years = int.Parse(age.Text);

                int rows = repository.UpdateStudent(id, name, years);
                if (rows == 0)
                {
                    status.Text = "No student record was saved.";
                    return;
                }

                string message = $"Updated {name} (age {years}).";
                MessageBox.Show(this, message, Text);
                LoadStudents(message);
            }
            catch (Exception ex) when (ex is FormatException or OverflowException)
            {
                status.Text = ex.Message;
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object? sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(studentId.Text);

                var answer = MessageBox.Show(this, $"Delete student {id}?", Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer != DialogResult.Yes)
                {
                    status.Text = "Delete canceled.";
                    return;
                }

                int rows = repository.DeleteStudent(id);
                if (rows == 0)
                {
                    status.Text = "Student not found.";
                    return;
                }

                studentId.Clear();
                username.Clear();
                age.Clear();
                LoadStudents($"Deleted student {id}.");
            }
            catch (Exception ex) when (ex is FormatException or OverflowException)
            {
                status.Text = ex.Message;
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object? sender, EventArgs e)
        {
            try
            {
                string keyword = search.Text.Trim();
                students.DataSource = repository.SearchStudents(keyword).ToList();
                status.Text = $"{students.Rows.Count} matching student(s).";
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllButton_Click(object? sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents(string? message = null)
        {
            try
            {
                students.DataSource = repository.GetStudents().ToList();
                status.Text = message ?? $"{students.Rows.Count} student(s).";
            }
            catch (SqlException ex)
            {
                status.Text = "Database request failed.";
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowStudent(StudentRepository.Student student)
        {
            studentId.Text = student.StudentId.ToString();
            username.Text = student.Username;
            age.Text = student.Age.ToString();
        }
    }
}
