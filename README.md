🛠️ Toplu Test Aracı (All-in-One Testing Tool) 🛠️
Bu proje, SMTP, Ping, Port Testi ve DNS Testi gibi birden fazla işlevi bir arada sunan toplu bir test aracıdır. 🚀 Kullanıcılar, tek bir uygulama üzerinden farklı ağ ve sunucu testlerini gerçekleştirebilir, tüm işlemlerin loglarını takip edebilir ve hızlıca sorun giderebilir. 💻🔧

🌟 Öne Çıkan Özellikler
1. SMTP ile E-posta Gönderme 📧
SMTP sunucularına bağlanarak e-posta gönderme.

SSL/TLS seçenekleri ile güvenli bağlantı. 🔒

E-posta gönderme işlemi sırasında tüm olayların loglanması. 📝

2. Ping Testi 🏓
Belirtilen bir IP adresine veya alan adına ping atma.

Ping sonuçlarını anlık olarak görüntüleme ve loglama. ⏱️

3. Port Testi 🚪
Belirtilen bir sunucu ve port numarası üzerinden bağlantı testi.

Port erişilebilirliğini kontrol etme ve loglama. 📊

4. DNS Testi 🌐
DNS çözümleme (A, AAAA, MX, CNAME, TXT, NS, SOA kayıtları).

Ters DNS çözümleme (IP adresinden alan adı bulma).

DNS sorgu sonuçlarını loglama. 📜

5. Log Kaydı 📑
Tüm işlemler (e-posta gönderme, ping, port testi, DNS sorguları) sırasında oluşan olayların loglanması.

Hata durumlarında detaylı hata mesajları. ❌

6. Zorunlu Alan Kontrolü ⚠️
Tüm bilgilerin (kullanıcı adı, parola, sunucu bilgileri, port numaraları, e-posta bilgileri) girilmesini zorunlu kılar.

Eksik bilgi durumunda kullanıcıya uyarı verir. 🛑

7. SSL/TLS Seçenekleri 🔐
SSL, TLS veya hiçbiri seçeneklerini destekler.

Seçilen güvenlik protokolüne göre SMTP bağlantısını yapılandırır.

🚀 Nasıl Çalışır?
1. SMTP Bilgilerini Girin
Mail, Parola, Gelen Sunucu, Giden Sunucu, Gelen Port, Giden Port bilgilerini ilgili TextBox'lara girin.

SSL/TLS seçeneklerinden birini seçin. 🔒

2. E-posta Bilgilerini Girin
Kimden, Kime, Konu ve İçerik bilgilerini doldurun. 📧

3. Test İşlemlerini Gerçekleştirin
Ping Testi: Ping butonuna tıklayarak belirtilen sunucuya ping atın. 🏓

Port Testi: Port Testi butonuna tıklayarak belirtilen sunucu ve port üzerinden bağlantı testi yapın. 🚪

DNS Testi: DNS Testi butonuna tıklayarak DNS sorguları gerçekleştirin. 🌐

E-posta Gönderme: Test Et butonuna tıklayarak e-posta gönderme işlemini başlatın. 📤

4. Logları İnceleyin
Tüm işlemlerin logları smtplog RichTextBox'da görüntülenir. 📑

Hata durumlarında detaylı hata mesajları loglanır. ❌

🛠️ Kullanım Örnekleri
1. E-posta Gönderme 📧
Mail: kullanici@example.com

Parola: sifre123

Giden Sunucu: smtp.example.com

Giden Port: 587

Güvenlik: TLS

Kimden: kullanici@example.com

Kime: alici@example.com

Konu: Test E-postası

İçerik: Bu bir test e-postasıdır.

2. Ping Testi 🏓
IP Adresi: 8.8.8.8

Sonuç: Ping Başarılı veya Ping Başarısız

3. Port Testi 🚪
Sunucu: example.com

Port: 80

Sonuç: Port Testi Başarılı veya Port Erişime Kapalı

4. DNS Testi 🌐
Alan Adı: example.com

Sorgu Türü: A

Sonuç: example.com -> 93.184.216.34

📋 Gereksinimler
.NET Framework 4.7.2 veya üzeri

Visual Studio 2019 veya üzeri (geliştirme için)

🛠️ Kurulum
Kaynak Kodu İndirin:

Projeyi GitHub'dan indirin veya klonlayın:

bash
Copy
git clone https://github.com/kullanici/toplu-test-araci.git
Visual Studio'da Açın:

Projeyi Visual Studio'da açın.

Derleyin ve Çalıştırın:

Projeyi derleyin ve çalıştırın.

📸 Ekran Görüntüleri
Ana Ekran:
Ana Ekran

Log Ekranı:
Log Ekranı

🤝 Katkıda Bulunma
Bu projeye katkıda bulunmak isterseniz, lütfen bir Pull Request gönderin. Katkılarınızı bekliyoruz! 🙌

📜 Lisans
Bu proje MIT Lisansı altında lisanslanmıştır.

📞 İletişim
E-posta: aaltunfaruk@gmail.com
