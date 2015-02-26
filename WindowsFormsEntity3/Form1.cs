using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DbModel;
using DbModel.DTO;

namespace WindowsFormsEntity3
{
    public partial class Form1 : Form
    {
        UnitOfWork first = new UnitOfWork();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowGroups_Click(object sender, EventArgs e)
        {
            var groupsNow = first.GroupRepository.All;
            dataGridGroups.DataSource = groupsNow.ToList();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            var StudentsNow = first.StudentRepository.ShowStudents();
            dataGridStudents.DataSource = StudentsNow.ToList();
            selectionMode1();
            
        }

        private void btnShowSubjects_Click(object sender, EventArgs e)
        {
            var SubjectsNow = first.SubjectRepository.ShowSubjects();
            dataGridSubjects.DataSource = SubjectsNow.ToList();
        }

        private void btnShowGrToSubj_Click(object sender, EventArgs e)
        {
            var GroupToSubjectsNow = first.GroupToSubjectRepository.ShowGroupToSubjects();
            dataGridGroupToSubject.DataSource = GroupToSubjectsNow.ToList();            
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {                  
            Groups Group = new Groups();
            Group.Name = textBoxGroup.Text;
            first.GroupRepository.AddRowToGroup(Group);
            dataGridGroups.DataSource = first.GroupRepository.ShowGroups().ToList();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
       
            var Group_Id = Convert.ToInt32(dataGridGroups.CurrentRow.Cells[0].Value);
            first.GroupRepository.DeleteRowInGroup(Group_Id);
            dataGridGroups.DataSource = first.GroupRepository.ShowGroups().ToList();
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            var Group_Id = Convert.ToInt32(dataGridGroups.CurrentRow.Cells[0].Value);
            var updGroupName = textBoxGroup.Text;
            first.GroupRepository.UpdateRowInGroup (updGroupName, Group_Id);
            dataGridGroups.DataSource = first.GroupRepository.ShowGroups().ToList();
        }

        private void dataGridGroups_SelectionChanged(object sender, EventArgs e)
        {
            textBoxGroup.Text = dataGridGroups.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridSubjects_SelectionChanged(object sender, EventArgs e)
        {
            textBoxSubject.Text = dataGridSubjects.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {                        
            Subjects Subject = new Subjects();
            Subject.Name = textBoxSubject.Text.ToString();
            first.SubjectRepository.AddRowToSubjects(Subject);
            dataGridSubjects.DataSource = first.SubjectRepository.ShowSubjects().ToList();             
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            var Subject_Id = Convert.ToInt32(dataGridSubjects.CurrentRow.Cells[0].Value);
            first.SubjectRepository.DeleteRowInSubjects(Subject_Id);
            dataGridSubjects.DataSource = first.SubjectRepository.ShowSubjects().ToList();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            var Subject_Id = Convert.ToInt32(dataGridSubjects.CurrentRow.Cells[0].Value);
            var updGroupName = textBoxSubject.Text;
            first.SubjectRepository.UpdateRowInSubjects(updGroupName, Subject_Id);
            dataGridSubjects.DataSource = first.SubjectRepository.ShowSubjects().ToList();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {            
            Students Student = new Students();
            Student.FirstName = textBoxFirstName.Text;
            Student.LastName = textBoxLastName.Text;
            Student.Age = Convert.ToInt32(textBoxAge.Text);
                       
            int groupIds = (int)comboBoxStudentGroup.SelectedValue;            
            Student.GroupId = groupIds;
            
            first.StudentRepository.AddRowToStudent(Student);
            dataGridStudents.DataSource = first.StudentRepository.ShowStudents().ToList();
        }

        private void dataGridStudents_SelectionChanged(object sender, EventArgs e)
        {
            textBoxFirstName.Text = dataGridStudents.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridStudents.CurrentRow.Cells[2].Value.ToString();
            textBoxAge.Text = dataGridStudents.CurrentRow.Cells[3].Value.ToString();
            comboBoxStudentGroup.Text = dataGridStudents.CurrentRow.Cells[4].Value.ToString();

        }

        public void selectionMode1() {

            comboBoxStudentGroup.DataSource = first.GroupRepository.ShowGroups().ToList();
            comboBoxStudentGroup.ValueMember = "Id";
            comboBoxStudentGroup.DisplayMember = "Name";        
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            var Student_Id = Convert.ToInt32(dataGridStudents.CurrentRow.Cells[0].Value.ToString());
            first.StudentRepository.DelRowInStudent(Student_Id);

            dataGridStudents.DataSource = first.StudentRepository.ShowStudents().ToList();
        }
    }
}
