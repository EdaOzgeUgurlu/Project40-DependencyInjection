namespace uygulama1.Services
{

    public class ClassRoom
    {
        private readonly ITeacher _teacher; // Bağımlılık olarak öğretmen nesnesi

        // Constructor Injection: Öğretmen nesnesi dışarıdan alınır.
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        // Öğretmenin bilgilerini döndüren metot
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}