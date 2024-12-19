# Patika Survivor

Bu proje, Patika üzerinden yapılan bir Survivor yarışması simülasyonu için geliştirilmiş bir ASP.NET Core uygulamasıdır. Projede yarışmacılar, kategoriler ve ilişkili veriler işlenir. Entity Framework Core kullanılarak veritabanı işlemleri gerçekleştirilmiştir.

## Proje İçeriği

### Kullanılan Teknolojiler
- **ASP.NET Core**: Web uygulaması geliştirme.
- **Entity Framework Core**: Veritabanı işlemleri.
- **MSSQL**: Veritabanı yönetimi.
- **LINQ**: Veri sorgulamaları.

### Uygulama Özellikleri
- **Yarışmacılar ve Kategoriler**: Yarışmacılar kategorilere atanmıştır ve ilişkili veriler Entity Framework Core ile yönetilmektedir.
- **Seed Veriler**: Uygulama başlangıcında kategoriler ve yarışmacılar için varsayılan veriler tanımlanmıştır.
- **CRUD İşlemleri**: Kategoriler ve yarışmacılar üzerinde CRUD işlemleri yapılabilir.

## Kurulum

### Gereksinimler
- .NET 6 veya daha yeni bir sürüm
- MSSQL Server
- Entity Framework Core CLI

### Adımlar
1. **Depoyu Klonlayın:**
   ```bash
   git clone https://github.com/iremrakicii/PatikaSurvivor.git
   cd PatikaSurvivor
   ```

2. **Veritabanı Ayarlarını Yapılandırın:**
   `appsettings.json` dosyasındaki bağlantı dizesini kendi MSSQL sunucunuza göre düzenleyin:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=PatikaSurvivorDB;Trusted_Connection=True;"
   }
   ```

3. **Migration Oluşturun ve Veritabanını Güncelleyin:**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Uygulamayı Başlatın:**
   ```bash
   dotnet run
   ```
   Uygulama varsayılan olarak `https://localhost:5001` adresinde çalışır.

## Veri Modeli

### Entity Modelleri
#### Competitor (Yarışmacılar)
- `Id`: Benzersiz kimlik.
- `FirstName`: Yarışmacının adı.
- `LastName`: Yarışmacının soyadı.
- `CategoryId`: Bağlı olduğu kategori.
- `IsDeleted`: Silinme durumu.

#### Category (Kategoriler)
- `Id`: Benzersiz kimlik.
- `Name`: Kategori adı.
- `IsDeleted`: Silinme durumu.

### İlişkiler
- Bir `Category`, birden fazla `Competitor` ile ilişkilidir.
- Her `Competitor` bir `Category`'ye aittir.

## Seed Veriler
Proje başlangıcında aşağıdaki veriler oluşturulmaktadır:

### Kategoriler
1. **Ünlüler**
2. **Gönüllüler**

### Yarışmacılar
| Id | Ad       | Soyad      | Kategori      |
|----|----------|------------|---------------|
| 1  | Acun     | Ilıcalı    | Ünlüler       |
| 2  | Aleyna   | Avcı       | Ünlüler       |
| 3  | Hadise   | Açıkgöz    | Ünlüler       |
| 4  | Sertan   | Bozkuş     | Ünlüler       |
| 5  | Özge     | Açık       | Ünlüler       |
| 6  | Kıvanç   | Tatlıtuğ   | Gönüllüler    |
| 7  | Ahmet    | Yılmaz     | Gönüllüler    |
| 8  | Elif     | Demirtaş   | Gönüllüler    |
| 9  | Cem      | Öztürk     | Gönüllüler    |
| 10 | Ayşe     | Karaca     | Gönüllüler    |

