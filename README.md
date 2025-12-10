# TodoApp - ASP.NET Core MVC Todo Uygulaması

Modern, full-stack bir todo yönetim uygulaması. ASP.NET Core 9.0 MVC, Entity Framework Core ve SQLite kullanılarak geliştirilmiştir.

## 🚀 Özellikler

- ✅ Todo ekleme, düzenleme ve silme (CRUD işlemleri)
- ✅ Todo'ları tamamlandı olarak işaretleme
- ✅ Öncelik seviyeleri (Düşük, Orta, Yüksek)
- ✅ Modern ve responsive UI tasarımı (Bootstrap 5)
- ✅ SQLite veritabanı entegrasyonu
- ✅ Entity Framework Core ile veritabanı yönetimi
- ✅ Model validation (Data Annotations)
- ✅ Seed data ile başlangıç verileri

## 🛠️ Teknolojiler

- **Backend Framework:** ASP.NET Core 9.0 MVC
- **ORM:** Entity Framework Core 9.0
- **Veritabanı:** SQLite
- **Frontend:** HTML5, CSS3, Bootstrap 5
- **Programlama Dili:** C# 12
- **Mimari:** MVC (Model-View-Controller) Pattern
- **Dependency Injection:** Built-in DI Container

## 📋 Gereksinimler

- .NET 9.0 SDK veya üzeri
- Visual Studio 2022, Visual Studio Code veya herhangi bir .NET uyumlu IDE

## 🔧 Kurulum

1. **Projeyi klonlayın:**
git clone https://github.com/bugracanu/TodoApp.git
cd TodoApp2. **Paketleri restore edin:**
dotnet restore3. **Uygulamayı çalıştırın:**
dotnet run4. **Tarayıcıda açın:**

dotnet restorede gösterilen URL'i kullanın.

## 📁 Proje Yapısı

dotnet runlanım

### Todo Ekleme
1. Ana sayfada "Yeni Todo" butonuna tıklayın
2. Başlık, açıklama ve öncelik seviyesini girin
3. "Kaydet" butonuna tıklayın

### Todo Düzenleme
1. Todo kartındaki "Düzenle" butonuna tıklayın
2. Bilgileri güncelleyin
3. "Güncelle" butonuna tıklayın

### Todo Tamamlama
1. Todo kartındaki "Tamamla" butonuna tıklayın
2. Todo tamamlandı olarak işaretlenir

### Todo Silme
1. Todo kartındaki "Sil" butonuna tıklayın
2. Onay mesajını kabul edin

## 🔍 Özellik Detayları

### Model Validation
- Başlık: Zorunlu, maksimum 100 karakter
- Açıklama: İsteğe bağlı, maksimum 500 karakter
- Öncelik: Zorunlu (Low, Medium, High)

### Veritabanı
- SQLite veritabanı otomatik oluşturulur
- Seed data ile başlangıçta 3 örnek todo eklenir
- Veritabanı dosyası: `todoapp.db`

## 🧪 Test

Projeyi test etmek için:
sh
dotnet build
dotnet run## 📝 Lisans

Bu proje eğitim amaçlıdır ve açık kaynak kodludur.

## 👤 Geliştirici

**Buğra Can Usta**

- GitHub: [@bugracanu](https://github.com/bugracanu)
- LinkedIn: [linkedin.com/in/bugracanu](https://linkedin.com/in/bugracanu)
- Email: bugracanusta@gmail.com

## 🙏 Teşekkürler

Bu proje, ASP.NET Core MVC öğrenme sürecinin bir parçası olarak geliştirilmiştir.

---

⭐ Bu projeyi beğendiyseniz, yıldız vermeyi unutmayın!!