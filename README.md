# 🔢 Sayı Bulma Oyunu (Number Guessing Game)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş basit ve eğlenceli bir sayı bulma oyunudur. İki oyuncu ile oynanabilir ve başlangıç seviyesinde programlama becerilerini geliştirmek için tasarlanmıştır.

## 🎮 Oyun Hakkında

Sayı Bulma Oyunu, klasik "Mastermind" oyununun basitleştirilmiş bir versiyonudur. Birinci oyuncu 4 haneli gizli bir sayı belirler, ikinci oyuncu ise bu sayıyı tahmin etmeye çalışır.

### 🎯 Oyun Kuralları
- **Gizli Sayı**: 4 haneli, tekrarsız rakamlardan oluşur (örn: 1234, 5678)
- **Tahmin**: Oyuncu 4 haneli tekrarsız bir sayı tahmin eder
- **Geri Bildirim**: 
  - 🔵 **Mavi**: Doğru rakam, doğru pozisyonda
  - 🔴 **Kırmızı**: Doğru rakam, yanlış pozisyonda
  - ❌ **Hiçbiri yok**: Hiçbir rakam eşleşmiyor

## ✨ Özellikler

### 🎮 Temel Özellikler
- ✅ **2 Oyuncu Sistemi**: Birinci oyuncu gizli sayıyı belirler
- ✅ **Tekrarsız Rakam Kontrolü**: Aynı rakam birden fazla kullanılamaz
- ✅ **Renkli Geri Bildirim**: Mavi ve kırmızı renklerle sonuç gösterimi
- ✅ **Ayarlanabilir Hak Sayısı**: 1-20 arası hak belirleme
- ✅ **Zaman Sınırı**: Her oyun için 5 dakika süre
- ✅ **Skor Sistemi**: Dosyada skor kaydetme ve görüntüleme

### 🎯 Gelişmiş Özellikler
- 📊 **Tahmin Geçmişi**: Tüm tahminler ve sonuçları listelenir
- ⏱️ **Geri Sayım Timer**: Kalan süre gösterimi
- 🏆 **Skor Hesaplama**: Deneme sayısı ve süreye göre puanlama
- 💾 **Otomatik Kayıt**: Skorlar `scores.txt` dosyasında saklanır
- ⌨️ **Enter Tuşu Desteği**: Hızlı oyun için klavye kısayolu

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler
- .NET 8.0 SDK veya üzeri
- Windows işletim sistemi
- Visual Studio 2022 veya Visual Studio Code

### Adımlar
1. **Projeyi İndirin**
   ```bash
   git clone https://github.com/BerfinSemiz/finding_number.git
   cd sayi-bulma-oyunu
   ```

2. **Projeyi Derleyin**
   ```bash
   dotnet build
   ```

3. **Oyunu Çalıştırın**
   ```bash
   dotnet run
   ```

## 🎮 Nasıl Oynanır?

### 1. Oyun Ayarları
- **Gizli Sayı**: Birinci oyuncu 4 haneli tekrarsız bir sayı girer
- **Hak Sayısı**: Maksimum tahmin hakkını belirleyin (1-20)
- **Oyunu Başlat**: "Oyunu Başlat" butonuna tıklayın

### 2. Oyun Süreci
- **Tahmin Girin**: 4 haneli tekrarsız bir sayı girin
- **Sonucu Görün**: Mavi/kırmızı renklerle geri bildirim alın
- **Strateji Geliştirin**: Sonuçlara göre bir sonraki tahmininizi planlayın

### 3. Oyun Sonu
- **Kazanma**: Doğru sayıyı bulduğunuzda oyun biter
- **Kaybetme**: Hak sayısı veya süre dolduğunda oyun biter
- **Skor**: Performansınıza göre puan alırsınız

## 📊 Skor Sistemi

Skor hesaplama formülü:
```
Skor = 1000 - (Deneme Sayısı × 50) + (Kalan Süre × 10)
```

**Örnek:**
- 5 denemede kazandınız
- 180 saniye kaldı
- Skor = 1000 - (5 × 50) + (180 × 10) = 1000 - 250 + 1800 = **2550**

## 🛠️ Teknik Detaylar

### Kullanılan Teknolojiler
- **C#** - Ana programlama dili
- **Windows Forms** - Kullanıcı arayüzü
- **.NET 8.0** - Framework
- **System.IO** - Dosya işlemleri

### Proje Yapısı
```
finding_number_game/
├── Form1.cs              # Ana oyun mantığı
├── Form1.Designer.cs     # Arayüz tasarımı
├── Program.cs            # Uygulama giriş noktası
├── finding_number_game.csproj  # Proje dosyası
└── scores.txt            # Skor kayıtları (otomatik oluşturulur)
```

### Ana Sınıflar ve Metodlar
- `Form1`: Ana form sınıfı
- `btnStartGame_Click()`: Oyun başlatma
- `MakeGuess()`: Tahmin işleme
- `CalculateGuessResult()`: Sonuç hesaplama
- `SaveScore()`: Skor kaydetme

## 🎓 Öğrenme Hedefleri

Bu proje ile öğrenebileceğiniz konular:

### 🖥️ Programlama Temelleri
- Değişkenler ve veri tipleri
- Döngüler ve koşullu ifadeler
- Metodlar ve fonksiyonlar
- Hata yakalama (try-catch)

### 🎨 Kullanıcı Arayüzü
- Windows Forms kontrolleri
- Event handling (olay yönetimi)
- Timer kullanımı
- Dosya işlemleri

### 🧠 Algoritma ve Mantık
- String işlemleri
- Array ve List kullanımı
- Oyun mantığı geliştirme
- Skor hesaplama algoritması

Bu proje eğitim amaçlı geliştirilmiştir. Özgürce kullanabilir ve geliştirebilirsiniz.


