using C__EF_S02_Assignment.Contexts;
using C__EF_S02_Assignment.Entities;
using System.Runtime.Intrinsics.X86;

namespace C__EF_S02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 02

            #region 1.Do CRUD operations on all tables(Use Previous Assignment)
            EFS02AssDbContext db = new EFS02AssDbContext();
            #region Insert || Create
            //Department
 
            //var Department = new Department()
            //{
            //    HiringDate = DateTime.Now,
            //    Ins_Id = 12,
            //    Name = "Hazem",


            //};
            //db.Departments.Add(Department);
            //Student

            //var Student = new Student()
            //{
            //    Address="Alex",
            //    Age=20,
            //    Dept_Id=12,
            //    FName="Alia"
            //    ,LName="Ali"
            //};

            //db.students.Add(Student);

            // Instructor
            //var instructor = new Instructor()
            //{
            //    Dept_Id = 18,
            //    Address="Zagazig",
            //    Bouns=280,
            //    HourRate=20,
            //    Name="Ali",
            //    Salary=120000
                
                

            //};
            //db.Instructors.Add(instructor);

            //Course
            //var course=new Course()
            //{
            //    Description="hhkhui uigig kjhgu7g",
            //    Duration=3,
            //    Name="ITI",
                
            //};
            //db.Courses.Add(course);

            //Topic
            var topic=new Topic()
            {
                Course_ID=10,
                Name="Kawarshy"
            };
            // db.Topics.Add(topic);

            //db.SaveChanges();


            #endregion

            #region Read || Select


            //Course
            // var Result = db.Courses.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : ITI :: Duration : 3 :: Description : hhkhui uigig kjhgu7g


            //Department
            // var Result = db.Departments.FirstOrDefault(C => C.Id == 12);//Id : 12 :: Name : It :: HiringDate : 28/08/2024 00:00:00 :: InstructorId : 7


            // Instructors
            //var Result = db.Instructors.FirstOrDefault(C => C.Id == 13);//Id : 13 :: Name : Fady :: Bouns : 150 :: Salary : 12000 :: Address : Cairo :: HourRate : 4.5


            // Student
            // var Result = db.students.FirstOrDefault(C => C.Id == 10);//Id : 10 :: FName : Fady :: LName : Fady :: Address : Alex :: DepartmentId : 12

            // Topics
            //var Result = db.Topics.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : Kawarshy ::  CpurseId : 10
            // Console.WriteLine(Result);


            #endregion


            #region Update

            //Course
            // var Result = db.Courses.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : ITI :: Duration : 3 :: Description : hhkhui uigig kjhgu7g
            //Console.WriteLine(Result);//Id : 10 :: Name : ITI :: Duration : 3 :: Description : hhkhui uigig kjhgu7g
            //Result.Name = "Cti";
            //Console.WriteLine(Result);//Id : 10 :: Name : Cti :: Duration : 3 :: Description : hhkhui uigig kjhgu7g

            //Department
            //var Result = db.Departments.FirstOrDefault(C => C.Id == 12);//Id : 12 :: Name : It :: HiringDate : 28/08/2024 00:00:00 :: InstructorId : 7
            //Result.Name = "Ds";
            //Console.WriteLine(Result);//Id : 12 :: Name : Ds :: HiringDate : 28/08/2024 00:00:00 :: InstructorId : 7

            // Instructors
            //var Result = db.Instructors.FirstOrDefault(C => C.Id == 13);//Id : 13 :: Name : Fady :: Bouns : 150 :: Salary : 12000 :: Address : Cairo :: HourRate : 4.5
            //Result.Name = "Ali";
            //Console.WriteLine(Result);//Id : 13 :: Name : Ali :: Bouns : 150 :: Salary : 12000 :: Address : Cairo :: HourRate : 4.5

            // Student
            //var Result = db.students.FirstOrDefault(C => C.Id == 10);//Id : 10 :: FName : Fady :: LName : Fady :: Address : Alex :: DepartmentId : 12
            //Result.LName = "Fady";
            //Result.FName = "Hazedm";
            //Console.WriteLine(Result);//Id : 10 :: FName : Hazedm :: LName : Hazedm :: Address : Alex :: DepartmentId : 12



            // Topics
            //var Result = db.Topics.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : Kawarshy ::  CpurseId : 10
            //Console.WriteLine(Result);
            //Result.Name= "CSS";
            //Console.WriteLine(Result);//Id : 10 :: Name : CSS ::  CpurseId : 10
            // db.SaveChanges();


            #endregion


            #region Remove || Delete

            //Course
            // var Result = db.Courses.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : ITI :: Duration : 3 :: Description : hhkhui uigig kjhgu7g
            //db.Courses.Remove(Result);
            //db.SaveChanges();



            ////// Topics
            ////var Result = db.Topics.FirstOrDefault(C => C.Id == 10);//Id : 10 :: Name : Kawarshy ::  CpurseId : 10
            ////db.Topics.Remove(Result);
            ////db.SaveChanges();
          

            // Instructors
            //var Result = db.Instructors.FirstOrDefault(C => C.Id == 13);//Id : 13 :: Name : Fady :: Bouns : 150 :: Salary : 12000 :: Address : Cairo :: HourRate : 4.5
            //db.Instructors.Remove(Result);
            //db.SaveChanges();

            //Department
            //var Result = db.Departments.FirstOrDefault(C => C.Id == 12);//Id : 12 :: Name : It :: HiringDate : 28/08/2024 00:00:00 :: InstructorId : 7
            //db.Departments.Remove(Result);
            //db.SaveChanges();




            // Student
            //var Result = db.students.FirstOrDefault(C => C.Id == 10);//Id : 10 :: FName : Fady :: LName : Fady :: Address : Alex :: DepartmentId : 12
            //db.students.Remove(Result);
            //db.SaveChanges();






            #endregion

            #endregion



        }
    }
}
