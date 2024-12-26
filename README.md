```markdown
# Pratik - Dependency Injection

## G�rev

A�a��daki s�n�flar aras�nda Dependency Injection kullanarak bir �rnek olu�turun.

### S�n�flar:

#### 1. **Teacher S�n�f�**
- **�zellikler:**
  - `FirstName: string`
  - `LastName: string`
- **Metotlar:**
  - `GetInfo()`: ��retmenin ad�n� ve soyad�n� d�nd�ren bir metot.

#### 2. **ClassRoom S�n�f�**
- **�zellikler:**
  - `Teacher`: `Ogretmen` t�r�nde bir nesne
- **Metotlar:**
  - `GetTeacherInfo()`: ��retmenin bilgilerini d�nd�ren bir metot. `Teacher` i�erisindeki `GetInfo()`'yu �a��rmas� yeterli.

---

### G�rev A��klamas�

1. `Teacher` ve `ClassRoom` s�n�flar�n� yaz�n.
2. `ClassRoom` s�n�f�n�n yap�c�s�na (constructor), `Teacher` s�n�f�n�n bir �rne�ini (instance) parametre olarak ge�in. (**Constructor Injection** kullan�n.)
3. Her iki s�n�f�n metotlar�n� kullanarak bir `ClassRoom` nesnesi olu�turun ve ��retmenin bilgilerini ekrana yazd�r�n.

---

### �nemli Not

**Dependency Injection**: Bir s�n�f�n ihtiya� duydu�u ba��ml�l�klar�n d��ar�dan verilmesi anlam�na gelir. Bu yakla��m, s�n�flar aras�ndaki ba��ml�l�klar� azaltarak daha esnek ve s�rd�r�lebilir bir yap� olu�turulmas�n� sa�lar.

---

### Ek
- **`Ogretmen` s�n�f� i�in bir Base Interface olu�turmay� unutmay�n.** (`IOgretmen`)
```