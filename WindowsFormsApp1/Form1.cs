using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IStudentService service = new StudentService();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateList()
        {
            lstStudents.Items.Clear();
            foreach (Student s in service.GetAllStudents())
            {
                lstStudents.Items.Add($"{s.Code} - {s.FirstName} {s.LastName}");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("telebeler.txt"))
            {
                foreach (Student s in service.GetAllStudents())
                {
                   sw.WriteLine($"Tələbə: {s.Code} | {s.FirstName} {s.LastName} | Yaş: {s.Age}");

                    foreach (Grade g in s.Grades)
                    {
                        sw.WriteLine($"   - Fənn: {g.Subject}, Qiymət: {g.Score}");
                    }
                }
            }

            MessageBox.Show("Bütün məlumatlar uğurla fayla yadda saxlanıldı!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtFirstName.Text.Trim();
            string surname = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Məlumatları tam daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Yaşı düzgün daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student(code, name, surname, age);

            if (service.AddStudent(newStudent))
            {
                MessageBox.Show("Tələbə uğurla əlavə edildi!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateList();
                txtCode.Clear(); txtFirstName.Clear(); txtLastName.Clear(); txtAge.Clear();
            }
            else
            {
                MessageBox.Show("Bu kodla tələbə artıq mövcuddur!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void qiymətYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string subject = txtSubject.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Kod və fənn adını daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Qiyməti rəqəm olaraq daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (service.AddGrade(code, subject, score))
            {
                MessageBox.Show("Qiymət uğurla yazıldı!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubject.Clear(); txtScore.Clear();
            }
            else
            {
                MessageBox.Show("Tələbə tapılmadı və ya qiymət 0-100 aralığında deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void göstərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            Student st = service.FindStudent(code);

            lstStats.Items.Clear();

            if (st == null)
            {
                MessageBox.Show("Belə kod yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstStats.Items.Add($"Məlumat: {st.Code} | {st.FirstName} {st.LastName} | Yaş: {st.Age}");
            lstStats.Items.Add("--- Qiymətlər ---");

            List<Grade> grades = service.GetStudentGrades(code);
            if (grades.Count == 0)
            {
                lstStats.Items.Add("Hələ qiymət yazılmayıb.");
            }
            else
            {
                foreach (Grade g in grades)
                {
                    lstStats.Items.Add($"{g.Subject}: {g.Score}");
                }
            }
        }

        private void çıxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Çıxmaq istədiyinizə əminsiniz?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
public class Grade
{
    public string Subject { get; set; }
    public int Score { get; set; }

    public Grade(string subject, int score)
    {
        Subject = subject;
        Score = score;
    }
}
public class Student
{
    public string Code { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<Grade> Grades { get; set; } = new List<Grade>();

    public Student(string code, string firstName, string lastName, int age)
    {
        Code = code;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
public interface IStudentService
{
    bool AddStudent(Student student);
    Student FindStudent(string code);
    bool AddGrade(string studentCode, string subject, int score);
    List<Grade> GetStudentGrades(string studentCode);
    List<Student> GetAllStudents();
}

public class StudentService : IStudentService
{
    public static List<Student> Students = new List<Student>();
    public bool AddStudent(Student student)
    {
        foreach (Student s in Students)
        {
            if (s.Code == student.Code) return false;
        }
        Students.Add(student);
        return true;
    }

    public Student FindStudent(string code)
    {
        foreach (Student s in Students)
        {
            if (s.Code == code) return s;
        }
        return null;
    }

    public bool AddGrade(string studentCode, string subject, int score)
    {
        if (score < 0 || score > 100) return false;

        Student st = FindStudent(studentCode);
        if (st == null) return false;

        st.Grades.Add(new Grade(subject, score));
        return true;
    }
    public List<Grade> GetStudentGrades(string studentCode)
    {
        Student st = FindStudent(studentCode);
        if (st == null) return null;
        return st.Grades;
    }
    public List<Student> GetAllStudents()
    {
        return Students;
    }
}
