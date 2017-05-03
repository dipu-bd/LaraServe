using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraServe.Models
{
    public class Projects : List<Project>
    {
        public Projects()
        {
        }

        public static List<Project> SampleData()
        {
            Projects projects = new Projects();

            Project project1 = new Project();
            project1.Name = "Test Project";
            project1.Location = @"D:\Projects\LaraServe";
            project1.Port = 3432;
            project1.AddCommand("Test", "chdir");
            project1.AddCommand("CD Test", "D:\ncd $Location\nchdir");
            projects.Add(project1);

            Project project3 = new Project();
            project3.Location = @"D:\Projects\course_feedback";
            project3.Name = "Course Feedback";
            project3.AddCommand("Run", "php artisan serve");
            projects.Add(project3);

            Project project4 = new Project();
            project4.Location = @"D:\Projects\course_feedback";
            project4.Name = "Course Feedback";
            project4.AddCommand("Watch", "yarn watch");
            project4.AddCommand("Dev", "yarn run dev");
            project4.AddCommand("Serve", "php artisan serve --host=$Host --port=$Port");
            projects.Add(project4);

            Project project2 = new Project();
            project2.Name = "Facebook";
            project2.UseSecure = true;
            project2.Host = "www.facebook.com";
            project2.Port = 80;
            projects.Add(project2);

            return projects;
        }

    }
}
