using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Mod11_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly ArrayList students = new ArrayList();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var newStudent = new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text
            };
            ClearForm();

            var task = new Task(() => AddToCollection(newStudent));
            task.Start();
        }

        
        private void AddToCollection(Student student)
        {
            // This line of code is intended to simulate network or database latency
            // It causes a non-responsive UI
            // Do not remove this line of code as a way of completing the assignment
            // You MUST use a C# task to get credit
            Thread.Sleep(5000);
            students.Add(student);
            var count = students.Count;
            MessageBox.Show(string.Format("Student created successfully.  Collection contains {0} Students(s).", count));
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }
    }
}
