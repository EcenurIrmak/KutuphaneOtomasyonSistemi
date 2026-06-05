# Kutuphane Otomasyon Sistemi

## 1. PROBLEM TANIMI

Geleneksel kütüphane sistemlerinde kitapların takibi, üyelerin ödünç aldığı kitapların kontrolü ve iade süreçleri manuel olarak yapılmaktadır. Bu durum; veri kaybına, kitapların yanlış takip edilmesine, ödünç/iade işlemlerinde karışıklığaneden olmaktadır.
Bu proje kapsamında, kütüphane işlemlerinin dijital ortamda yönetilmesini sağlayan bir otomasyon sistemi geliştirilmiştir. 
Amaç; kitap, üye ve ödünç işlemlerini merkezi bir veritabanı üzerinden yönetmektir.

## 2. YAPILAN ARAŞTIRMALAR
#### Proje geliştirme sürecinde aşağıdaki konular araştırılmıştır:
  - Microsoft SQL Server veritabanı tasarımı
  - C# WinForms ile veritabanı bağlantısı (ADO.NET)
  - Trigger kullanımı ile otomatik veri güncelleme
  - View yapıları ile raporlama sistemleri
  - Foreign Key ilişkileri ve normalizasyon kuralları
  - Get or Creat yaklaşımı
## Karşılaşılan sorunlar ve çözümler:
  - Veri tutarlılığı sorunu: Trigger kullanılarak çözüldü.
  - SQL sorgu karmaşıklığı: View yapıları ile sadeleştirildi.
  - İlişkisel veri yönetimi: Foreign key yapıları ile düzenlendi.
  - Tekrar eden kayılar: Get or creat yaklaşımı ile engellendi.

## 3. Akış Şeması
Sistemin çalışma mantığını gösteren akış şeması aşağıda sunulmuştur.
![Akış Şeması](flowchart.png)


## 4.YAZILIM MİMARİSİ

Proje 3 katmanlı basit mimari ile geliştirilmiştir:
### 1. Sunum Katmanı (UI)
  Kullanıcı arayüzü C# WinForms kullanılarak geliştirilmiştir.

Kullanılan formlar: 
       - UyelerForm
       - KitaplarForm,
       - OduncVerForm
       - OduncListesiForm
       - UyeEklemeForm
       - IadeEtmeForm
       - KitapEkleForm
### 2. İş Katmanı (Logic)
Bu katmanda sistem kuralları ve doğrulama işlemleri yer almaktadır.
  - Ödünç verme kuralları
  - Veri doğrulama işlemleri
  - Trigger ve procedure kullanımı
### 3. Veri Katmanı (Database)
  Veri yönetimi Microsoft SQL Server üzerinde gerçekleştirilmiştir.

Kullanılan tablolar: 
      - uyeler
      - yayınevleri
      - kategoriler
      - kitap_kategorileri
      - kitaplar
      - yazarlar
      - kitap_kopyalari
      - odunc_almalar
    
## 5. VERİTABANI DİYAGRAMI (ER MODELİ)
Sistemin veritabanı yapısı ilişkisel veritabanı prensiplerine uygun olarak tasarlanmıştır. Tablolar arasında Primary Key ve Foreign Key ilişkileri kullanılarak veri bütünlüğü sağlanmıştır.

![ER Diyagramı Görseli]

## 6. GENEL YAPI

Proje şu modüllerden oluşmaktadır:
  ### Üye Yönetimi 
  - Ekleme
  - listeleme
  ### Kitap Yönetimi 
  - Ekleme
  - listeleme
  ### Ödünç İşlemleri
 - Kitap ödünç verme
 - Aktif ödünç kayıtlarının takibi
  ### Ödünç Raporlama
  - Ödünç alınan kitapların görüntülenmesi
  ### İade İşlemleri
  - Kitap iadesi
  - Durum güncelleme işlemleri

Sistem, SQL Server veritabanı ile entegre olarak geliştirilmiştir. Üye, kitap, ödünç ve iade işlemleri kullanıcı arayüzü üzerinden yönetilmekte, tüm veriler veritabanında güvenli ve tutarlı bir şekilde saklanmaktadır. Ayrıca veritabanı üzerinde sorgulama, ekleme, güncelleme ve silme işlemleri de gerçekleştirilebilmektedir.

## 7. SONUÇ
Geliştirilen Kütüphane Otomasyon Sistemi sayesinde kütüphane işlemleri dijital ortama taşınmış, manuel işlemlerden kaynaklanan hata oranları azaltılmıştır. Sistem; kitap, üye, ödünç ve iade süreçlerinin daha hızlı, güvenilir ve düzenli bir şekilde yürütülmesini sağlamaktadır. Ayrıca veritabanı üzerinde uygulanan ilişkisel yapı, trigger ve view mekanizmaları sayesinde veri bütünlüğü korunmuş ve raporlama işlemleri kolaylaştırılmıştır.

## 8. REFERANSLAR
#### Proje geliştirme sürecinde kullanılan kaynaklar:
  - Microsoft Learn – SQL Server Documentation
      https://learn.microsoft.com/sql/
  - C# ADO.NET Guide
      https://learn.microsoft.com/dotnet/framework/data/adonet/
  - W3Schools 
      https://www.w3schools.com
  - Geeksforgeeks
      https://www.geeksforgeeks.org/


