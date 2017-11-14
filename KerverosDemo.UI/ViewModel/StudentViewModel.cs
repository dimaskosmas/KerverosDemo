using KerverosDemo.UI.Common;
using KerverosDemo.UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.UI.ViewModel
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new DelegateICommand(OnDelete, CanDelete);
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" }
            };

            Students = students;
        }

        public DelegateICommand DeleteCommand { get; set; }

    }
}
