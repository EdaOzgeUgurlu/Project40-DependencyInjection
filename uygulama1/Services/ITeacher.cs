namespace uygulama1.Services
{
    public interface ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetInfo();
    }
}
