namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>{ 
            new Student
            {
                Id=1,
                StudentName="Mainak",
                Email="xyz@gmail.com",
                Address="abc"

            },
             new Student
             {
                 Id =2,
                 StudentName = "Mainak",
                 Email = "xyz@gmail.com",
                 Address = "abc"

             }

            };
    }
}
