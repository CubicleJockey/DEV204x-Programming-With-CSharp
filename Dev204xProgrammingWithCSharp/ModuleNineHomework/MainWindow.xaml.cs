using System.Collections.Generic;
using System.Windows;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly IList<Student> _students;
        private int _index;

        public MainWindow()
        {
            InitializeComponent();
            _students = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            _students.Add(new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text
            });

            _index = _students.Count;

            MessageBox.Show("Student Saved!");

            #region Cleanup

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

            #endregion Cleanup
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            _index--;
            if(_index < 0)
            {
                _index = 0;
            }
            SetTextFields(_students[_index]);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            _index++;
            if(_index > (_students.Count - 1))
            {
                _index = (_students.Count - 1);
            }
            SetTextFields(_students[_index]);
        }

        private void SetTextFields(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
        }
    }
}
