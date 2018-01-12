using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;




namespace _10._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputStudentsDGV, 40, false, true, true, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = StudentsDGVConvert.DGVToStudentsList(InputStudentsDGV);
                StudentsDGVConvert.StudentsListToDGV(InputStudentsDGV, StudentsSort.Sort(students));

                ExcludeStudents instance = new ExcludeStudents((int)minPoint.Value, (int)minsumOfStudents.Value);
                List<string> ListExcludedStudents = instance.Exclude(students);
                ExcludedStudents.Text = string.Join("; ", ListExcludedStudents);
            }
            catch(Exception ex)
            {
                MessageUtils.ShowError("Произошла ошибка");
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExcludedStudents_Click(object sender, EventArgs e)
        {

        }

        private void MenuFailOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFileDialog.FileName;

                    List<Student> studentsList = StudentsFiles.ReadStudentsListFromFile(path);

                    StudentsDGVConvert.StudentsListToDGV(InputStudentsDGV, studentsList);
                }
                catch (Exception ex)
                {
                    MessageUtils.ShowError("Ошиба чтения из файла");
                }
            }





        }

        private void MenuFailSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = SaveFileDialog.FileName;

                    List<Student> studentsList = StudentsDGVConvert.DGVToStudentsList(InputStudentsDGV);

                    StudentsFiles.SaveStudentsListInFile(path, studentsList);
                }
                catch (Exception ex)
                {
                    MessageUtils.ShowError("Ошиба сохранения файла");
                }
            }
        }
    }
}
