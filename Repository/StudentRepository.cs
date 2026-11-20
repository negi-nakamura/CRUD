using Microsoft.Data.SqlClient;
using CRUD.Data;
using Dapper;

namespace CRUD.Repository
{
    public class StudentRepository
    {
        public StudentRepository()
        {
            
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string Username { get; set; } = "";
            public int Age { get; set; }
        }

        public IEnumerable<Student> GetStudents()
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "SELECT StudentId, Username, Age FROM Students";

            return connection.Query<Student>(sql);
        }

        public Student? GetStudent(int studentId)
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "SELECT StudentId, Username, Age FROM Students WHERE StudentId = @StudentId";

            return connection.QuerySingleOrDefault<Student>(sql, new { StudentId = studentId });
        }

        public IEnumerable<Student> SearchStudents(string keyword)
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "SELECT StudentId, Username, Age FROM Students WHERE Username LIKE @Pattern";

            return connection.Query<Student>(sql, new { Pattern = "%" + keyword + "%" });
        }

        public int InsertStudent(int studentId, string username, int age)
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "INSERT INTO Students (StudentId, Username, Age) VALUES (@StudentId, @Username, @Age)";

            return connection.Execute(sql, new { StudentId = studentId, Username = username, Age = age });
        }

        public int UpdateStudent(int studentId, string username, int age)
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "UPDATE Students SET Username = @Username, Age = @Age WHERE StudentId = @StudentId";

            return connection.Execute(sql, new { StudentId = studentId, Username = username, Age = age });
        }

        public int DeleteStudent(int studentId)
        {
            using var connection = SqlConnectionFactory.Instance.CreateConnection();
            string sql = "DELETE FROM Students WHERE StudentId = @StudentId";

            return connection.Execute(sql, new { StudentId = studentId });
        }
    }
}
