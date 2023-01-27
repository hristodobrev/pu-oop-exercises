namespace _6.University
{
    public class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int age;
        private string address;
        private string mobile;
        private string email;
        private string course;
        private string specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }
        public Student(string firstName, string middleName, string lastName, int age,
            string address, string mobile, string email, string course,
            string specialty, University university, Faculty faculty) : this(firstName, middleName, lastName)
        {
            this.age = age;
            this.address = address;
            this.mobile = mobile;
            this.email = email;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }

        public string Name { get => $"{this.firstName} {this.middleName} {this.lastName}"; }

        public override string ToString()
        {
            return $"{this.Name} - Age: {this.age}, Mobile: {this.mobile}, Email: {this.email}, Address: {this.address}{Environment.NewLine}University: {this.university}, {this.faculty}, {this.specialty}, {this.course}";
        }
    }
}
