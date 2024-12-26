namespace uygulama1.Services
{
    //IOgretmen, öğretmen sınıflarının temel özelliklerini ve metotlarını tanımlayan bir interface oluşturuyoruz.
    //GetInfo() metodu, öğretmenin ad ve soyadını döndürmek için kullanılacak.
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor: Öğretmenin adını ve soyadını dışarıdan alır.
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Öğretmenin adını ve soyadını döndüren metot
        public string GetInfo()
        {
            return $"Baş Öğretmenimiz: {FirstName} {LastName}";
        }
    }
}
