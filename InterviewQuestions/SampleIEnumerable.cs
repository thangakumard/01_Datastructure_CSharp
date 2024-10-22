using System.Collections;

namespace DatastructureMSTest.InterviewQuestions
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
    }

    public class StudentCollection : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        // Method to add students to the collection
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // IEnumerable<Student> requires this method for generic iteration
        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        // Non-generic IEnumerable requires this method for non-generic iteration
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Calls the generic version
        }
    }

    [TestClass]
    public class IEnumerableTest
    {
        [TestMethod]
        public void TestStudentCollection()
        {
            // Create the student collection and add some students
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddStudent(new Student { Id = 1, StudentName = "John Doe" });
            studentCollection.AddStudent(new Student { Id = 2, StudentName = "Jane Doe" });
            studentCollection.AddStudent(new Student { Id = 3, StudentName = "Sam Smith" });

            // Use a foreach loop to iterate over the student collection
            foreach (var student in studentCollection)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.StudentName}");
            }
        }
    }

}
