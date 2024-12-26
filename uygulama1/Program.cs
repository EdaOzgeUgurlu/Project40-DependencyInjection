using uygulama1.Services;

public class Program
{
    public static void Main()
    {

        // 1. ��retmen olu�tur
        ITeacher teacher = new Teacher("Mustafa Kemal", "Atat�rk");

        // 2. S�n�f olu�tur ve ��retmeni ba�la
        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. ��retmenin bilgilerini yazd�r
        Console.WriteLine(classRoom.GetTeacherInfo());

    }
}