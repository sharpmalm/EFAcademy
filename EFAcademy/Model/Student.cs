using EFAcademy.Model;

namespace EFAcademy.Model
{
    public class Student : BaseEentity
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public List<Class> Classes { get; set; }
        public Address Address { get; set; } = default!;

        public override string ToString()
        {
            // Return the full name when ToString() is called
            return $"{FirstName} {LastName}";
        }
    }

}


