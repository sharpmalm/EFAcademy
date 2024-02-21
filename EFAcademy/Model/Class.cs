namespace EFAcademy.Model
{
    public class Class : BaseEentity
    {
        public string Title { get; set; } = default!;
        public List<Student> Students { get; set; } = default!;
        public Professor Professor { get; set; }
    }
}
