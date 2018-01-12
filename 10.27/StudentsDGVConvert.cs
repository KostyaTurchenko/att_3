using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._27
{
    class StudentsDGVConvert
    {
        public static List<Student> DGVToStudentsList(DataGridView dgv)
        {
            var students = new List<Student>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string name = row.Cells["InputStudentsDGV_name"].Value.ToString();
                int points = (int)Convert.ChangeType(row.Cells["InputStudentsDGV_points"].Value, typeof(int));  

                Student student = new Student(name, points);
                students.Add(student);
            }
            return students;
        }
        public static void StudentsListToDGV (DataGridView dgv, List<Student> students)
        {
            dgv.Rows.Clear();
            foreach (Student student in students)
            {
                dgv.Rows.Add();
                DataGridViewRow LastRow = dgv.Rows[dgv.RowCount - 1];
                LastRow.Cells["InputStudentsDGV_name"].Value = student.name;
                LastRow.Cells["InputStudentsDGV_points"].Value = student.Points;
            }
        }
    }
}
