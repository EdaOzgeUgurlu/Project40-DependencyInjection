```markdown
# Pratik - Dependency Injection

## Görev

Aþaðýdaki sýnýflar arasýnda Dependency Injection kullanarak bir örnek oluþturun.

### Sýnýflar:

#### 1. **Teacher Sýnýfý**
- **Özellikler:**
  - `FirstName: string`
  - `LastName: string`
- **Metotlar:**
  - `GetInfo()`: Öðretmenin adýný ve soyadýný döndüren bir metot.

#### 2. **ClassRoom Sýnýfý**
- **Özellikler:**
  - `Teacher`: `Ogretmen` türünde bir nesne
- **Metotlar:**
  - `GetTeacherInfo()`: Öðretmenin bilgilerini döndüren bir metot. `Teacher` içerisindeki `GetInfo()`'yu çaðýrmasý yeterli.

---

### Görev Açýklamasý

1. `Teacher` ve `ClassRoom` sýnýflarýný yazýn.
2. `ClassRoom` sýnýfýnýn yapýcýsýna (constructor), `Teacher` sýnýfýnýn bir örneðini (instance) parametre olarak geçin. (**Constructor Injection** kullanýn.)
3. Her iki sýnýfýn metotlarýný kullanarak bir `ClassRoom` nesnesi oluþturun ve öðretmenin bilgilerini ekrana yazdýrýn.

---

### Önemli Not

**Dependency Injection**: Bir sýnýfýn ihtiyaç duyduðu baðýmlýlýklarýn dýþarýdan verilmesi anlamýna gelir. Bu yaklaþým, sýnýflar arasýndaki baðýmlýlýklarý azaltarak daha esnek ve sürdürülebilir bir yapý oluþturulmasýný saðlar.

---

### Ek
- **`Ogretmen` sýnýfý için bir Base Interface oluþturmayý unutmayýn.** (`IOgretmen`)
```