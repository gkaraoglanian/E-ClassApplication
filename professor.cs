using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject1
{
    class professor<User>
    {
        List<Course> courseList;

        private void createProject(string id,string name, string description,double maxgrade)
        {
            Project project = new Project();
            project.projectID(id);
            project.setName(name);
            project.setdescreption(descritpion);
            project.setmaxGrade(maxgrade);
        }
        private void editProject()
        {
            //difference in edit and create
            //need to see project class constructor
            //project class set functions for create, edit or delete?
        }
        private void deleteProject()
        {

        }
        private void createTeam()
        {

        }
        private void editTeam()
        {

        }
        private void deleteTeam()
        {

        }
        private void gradeProject()
        {

        }
        private List<Course> getCourseList()
        {

        }
        private void setCourseList(List<Course> clist)
        {

        }
    }
}
