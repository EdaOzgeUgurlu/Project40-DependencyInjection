using uygulama1.Services;

public class Program
{
    public static void Main()
    {

        // 1. Öðretmen oluþtur
        ITeacher teacher = new Teacher("Mustafa Kemal", "Atatürk");

        // 2. Sýnýf oluþtur ve öðretmeni baðla
        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. Öðretmenin bilgilerini yazdýr
        Console.WriteLine(classRoom.GetTeacherInfo());

    }
}