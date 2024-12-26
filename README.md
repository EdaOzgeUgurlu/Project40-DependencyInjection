# 🎓 Dependency Injection Uygulama1 - Sınıf Öğretmeni Uygulaması

Bu proje, basit bir sınıf öğretmeni uygulaması örneğidir. Öğretmen sınıflarının bağımlılık enjeksiyonu ile nasıl kullanılabileceğini gösterir.

## 🚀 Başlangıç

Aşağıdaki adımları takip ederek projeyi çalıştırabilirsiniz.

### 📋 Gereksinimler

- .NET 6 veya üzeri
- PostgreSQL veritabanı

### ⚙️ Kurulum

1. **Proje Deposu** 📂:
   ```bash
   git clone https://github.com/kullaniciadi/uygulama1.git
   cd uygulama1
   ```

2. **Bağımlılıkları Yükleyin** 📦:
   ```bash
   dotnet restore
   ```

3. **Veritabanını Ayarlayın** 🛠️:
    PostgreSQL veritabanınızı kurun ve bağlantı dizesini `OnConfiguring` metodunda güncelleyin.

### ▶️ Çalıştırma

Projeyi aşağıdaki komutla çalıştırın:
```bash
dotnet run
```

### 🛠️ Kullanım

Proje çalıştırıldığında, öğretmen ve sınıf bilgileri konsola yazdırılacaktır.

### 💻 Örnek Kod

```csharp
using uygulama1.Services;

public class Program
{
    public static void Main()
    {
        // 1. Öğretmen oluştur
        ITeacher teacher = new Teacher("Mustafa Kemal", "Atatürk");

        // 2. Sınıf oluştur ve öğretmeni bağla
        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. Öğretmenin bilgilerini yazdır
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}
```

## 📁 Yapı

Proje aşağıdaki yapıyı takip eder:

- `Program.cs`: Uygulamanın giriş noktası.
- `Services` klasörü: Öğretmen ve sınıf servislerini içerir.
  - `ITeacher.cs`: Öğretmen arayüzü.
  - `Teacher.cs`: Öğretmen sınıfı.
  - `ClassRoom.cs`: Sınıf sınıfı.

## 💡 Bağımlılık Enjeksiyonu (Dependency Injection)

Bu projede bağımlılık enjeksiyonu kullanarak `ClassRoom` sınıfına bir öğretmen nesnesi enjekte edilmektedir. Bu, nesneler arası bağımlılıkları yönetmeyi ve test edilebilirliği artırmayı sağlar. Aşağıdaki örnekte, `ClassRoom` sınıfına bir `ITeacher` nesnesi enjekte edilmektedir.

### 🔧 Örnek Kullanım

```csharp
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
```

