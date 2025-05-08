namespace az_webapp_vs_ci_cd.Data
{
    public class Person
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DataOfBirth { get; set; }
    }
}