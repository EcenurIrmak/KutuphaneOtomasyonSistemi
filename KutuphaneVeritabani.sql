
USE kutuphane;

-- TABLOLAR

CREATE TABLE uyeler (
    uye_id INT IDENTITY(1,1) PRIMARY KEY,
    ad NVARCHAR(50) NOT NULL,
    soyad NVARCHAR(50) NOT NULL,
    telefon VARCHAR(20),
    email VARCHAR(100) UNIQUE,
    adres NVARCHAR(MAX),
    kayit_tarihi DATE DEFAULT CAST(GETDATE() AS DATE),
    CONSTRAINT chk_telefon CHECK (LEN(telefon) >= 10)
);


CREATE TABLE yazarlar (
    yazar_id INT IDENTITY(1,1) PRIMARY KEY,
    ad NVARCHAR(50) NOT NULL,
    soyad NVARCHAR(50) NOT NULL
);


CREATE TABLE yayinevleri (
    yayinevi_id INT IDENTITY(1,1) PRIMARY KEY,
    yayinevi_adi VARCHAR(150) NOT NULL
);


CREATE TABLE kategoriler (
    kategori_id INT IDENTITY(1,1) PRIMARY KEY,
    kategori_adi NVARCHAR(100) NOT NULL UNIQUE
);


CREATE TABLE kitaplar (
    kitap_id INT IDENTITY(1,1) PRIMARY KEY,
    isbn VARCHAR(20) UNIQUE,
    kitap_adi NVARCHAR(200) NOT NULL,
    yazar_id INT NOT NULL FOREIGN KEY REFERENCES yazarlar(yazar_id),
    yayinevi_id INT NOT NULL FOREIGN KEY REFERENCES yayinevleri(yayinevi_id),
    yayin_yili INT,
    CONSTRAINT chk_yayin_yili CHECK ( yayin_yili >= 1900)    
);


CREATE TABLE kitap_kategorileri (
    kitap_id INT FOREIGN KEY REFERENCES kitaplar(kitap_id),
    kategori_id INT FOREIGN KEY REFERENCES kategoriler(kategori_id),
    PRIMARY KEY (kitap_id, kategori_id)
);


CREATE TABLE kitap_kopyalari (
    kopya_id INT IDENTITY(1,1) PRIMARY KEY,
    kitap_id INT NOT NULL FOREIGN KEY REFERENCES kitaplar(kitap_id), 
    durum NVARCHAR(20) DEFAULT 'Müsait',
    CONSTRAINT chk_durum CHECK (durum IN ('Müsait','Ödünçte'))    
);


CREATE TABLE odunc_almalar (
    odunc_id INT IDENTITY(1,1) PRIMARY KEY,
    uye_id INT NOT NULL FOREIGN KEY REFERENCES uyeler(uye_id),
    kopya_id INT NOT NULL FOREIGN KEY REFERENCES kitap_kopyalari(kopya_id),
    alis_tarihi DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    son_teslim_tarihi DATE NOT NULL,
    iade_tarihi DATE NULL,
    CONSTRAINT chk_teslim CHECK (son_teslim_tarihi >= alis_tarihi),
    CONSTRAINT chk_iade_tarihi CHECK (iade_tarihi IS NULL OR iade_tarihi >= alis_tarihi)
);


-- =============================================


INSERT INTO uyeler(ad,soyad,telefon,email,adres,kayit_tarihi)
VALUES
('Ahmet', 'Yıldız', '05321562442', 'ahmetyildiz@gmail.com', 'İzmit/Kocaeli','2024-01-01'),
('Ayşe', 'Korkmaz', '05363541236', 'aysekorkmaz1999@gmail.com', 'Gebze/Kocaeli','2024-01-01'),
('Mehmet', 'Çelik', '05374568925', 'mehmetcelik07@gmail.com', 'Darıca/Kocaeli','2024-02-01'),
('Elif', 'Arslan', '05536547896', 'elifarslan65@gmail.com', 'Kartal/İstanbul','2024-02-05'),
('Ali', 'Koç', '05394362255', 'ali34koc@gmail.com', 'Pendik/İstanbul','2024-03-01'),
('Zeynep', 'Demir', '05487539658', 'zeynep61demir@gmail.com', 'Körfez/Kocaeli','2024-03-11'),
('Hasan', 'Şahin', '05896352100', 'hasan37sahin@gmail.com', 'Bursa/Osmangazi','2024-04-01'),
('Fatma', 'Yılmaz', '05324784555', 'fatmaYyilmaz@gmail.com', 'Sakarya/Adapazarı','2024-04-01'),
('Emre', 'Aksoy', '05364111172', 'emreaksoy@gmail.com', 'İzmit/Kocaeli','2024-06-01'),
('Merve', 'Polat', '05784522263', 'mervePolat22@gmail.com', 'Gebze/Kocaeli','2024-06-15'),
('Burak', 'Aslan', '05624589357', 'burakAs1an@gmail.com', 'Ankara/Çankaya','2024-07-01'),
('Derya', 'Güneş', '05364215899', 'gunesderya@gmail.com', 'İstanbul/Bağcılar','2024-07-02'),
('Okan', 'Kılıç', '05459963596', 'okankilic02@gmail.com', 'Kocaeli/Gölcük','2024-07-09'),
('Seda', 'Aydın', '05324588971', 'sedAydin@gmail.com', 'İzmir/Karşıyaka','2024-07-11'),
('Hüseyin', 'Öztürk', '05152367485', 'huseyin14ozturk@gmail.com', 'Bolu/Merkez','2024-07-21'),
('Ceren', 'Taş', '05326547899', 'cerentas09@gmail.com', 'Tekirdağ/Çorlu','2024-08-01'),
('Volkan', 'Eren', '05697362289', 'volkanEeren@gmail.com', 'Kocaeli/Derince','2024-08-01'),
('Gamze', 'Uçar', '05364523871', 'gamzeUcar@gmail.com', 'İstanbul/Esenyurt','2024-08-01'),
('Serkan', 'Polat', '05396181145', 'serkanpolat@gmail.com', 'Samsun/Atakum','2024-09-01'),
('İrem', 'Bulut', '05893455217', 'irem05bulut@gmail.com', 'Antalya/Muratpaşa','2024-09-10');


INSERT INTO yazarlar(ad,soyad)
VALUES 
('Sabahattin','Ali'),
('Oğuz','Atay'),
('Arthur Conan','Doyle'),
('Halit Ziya','Uşaklıgil'),
('J. K.','Rowling'),
('Suzanne','Collins'),
('Stieg','Larsson'),
('Halide Edip','Adıvar'),
('Jane','Austen'),
('William','Gibson');

INSERT INTO yayinevleri(yayinevi_adi)
VALUES 
('İş Bankası Kültür Yayınları'),
('Can Yayınları'),
('Yapı Kredi Yayınları'),
('Potink Kitap'),
('İletişim Yayınları'),
('Olympia Yayınları'),
('Martı Yayınları'),
('Doğan Yayınları'),
('Pegasus Yayınları'),
('AltıKırkbeş Yayın');

INSERT INTO kitaplar(isbn,kitap_adi,yazar_id,yayinevi_id,yayin_yili)
VALUES 
('9786058073920','Kürk Mantolu Madonna',1,4,2019),
('9789750742712','İçimizdeki Şeytan',1,2,2020),
('9789750525728','Tutunamayanlar',2,5,2025),
('9789750525681','Günlük',2,5,2019),
('978059384063','Mai ve Siyah',4,6,2022),
('9789750802942','Harry Potter ve Felsefe Taşı',5,3,2001),
('9789750802959','Harry Potter ve Sırlar Odası',5,3,2001),
('9786254487163','Süphe Asla Uyumaz Sherlock Holmes',3,7,2021),
('9786258021738','Açlık Oyunları',6,8,2023),
('9786054263301','Ejderha Dövmeli Kız',7,9,2010),
('9789750720048','Ateşten Gömlek',8,2,2014),
('9786256198449','Gurur ve Önyargı',9,8,2021),
('9786055532666','Neuromancer',10,10,2014);



INSERT INTO kategoriler(kategori_adi)
VALUES
('Roman'),   
('Edebi Kurgu'),
('Kurgu'),
('Bilinç Akışı'),
('Otobiyografi'),
('Fantastik'),
('Çocuk Edebiyatı'),
('Polisiye'),
('Gizem'),
('Hikaye'),
('Gerilim'),
('Macera'),
('Bilim Kurgu'),
('Romantik'),
('Distopik Kurgu');

INSERT INTO kitap_kategorileri(kitap_id,kategori_id)
VALUES
(1,1), (1,2),
(2,3),
(3,3), (3,4),
(4,5),
(5,1),
(6,6), (6,7),
(7,6), (7,7),
(8,8), (8,9), (8,10),
(9,1), (9,7), (9,11), (9,12), (9,13),
(10,8), (10,9), (10,11), 
(11,1), (11,3),
(12,1), (12,12), (12,14),
(13,1), (13,13), (13,15);


INSERT INTO kitap_kopyalari(kitap_id)
VALUES 
(1), (1), (1), (1), (1),
(2), (2), (2), (2), (2),
(3), (3), (3), (3), (3),
(4), (4), (4), (4), (4),
(5), (5), (5), (5), (5),
(6), (6), (6), (6), (6),
(7), (7), (7), (7), (7),
(8), (8), (8), (8), (8),
(9), (9), (9), (9), (9),
(10), (10), (10), (10), (10),
(11), (11), (11), (11), (11),
(12), (12), (12), (12), (12),
(13), (13), (13), (13), (13);


INSERT INTO odunc_almalar(uye_id, kopya_id, alis_tarihi, son_teslim_tarihi, iade_tarihi) 
VALUES
(1,6,'2025-02-01','2025-03-01','2025-02-15'),
(1,15,'2025-03-07','2025-04-07','2025-04-01'),
(2,24,'2025-07-02','2025-08-02','2025-07-26'),
(7,4,'2025-11-01','2025-12-01',NULL),
(5,14,'2026-01-01','2026-02-01','2026-01-18'),
(3,9,'2026-01-05','2026-02-05',NULL),
(4,6,'2026-01-06','2026-02-06','2026-02-04'),
(4,20,'2026-03-13','2026-04-13','2026-03-29'),
(5,12,'2026-01-31','2026-03-02','2026-02-17'),
(6,37,'2026-01-04','2026-02-04','2026-01-21'),
(9,45,'2026-01-15','2026-02-15','2026-02-07'),
(6,41,'2026-01-21','2026-02-21','2026-02-15'),
(8,56,'2026-03-06','2026-04-06','2026-03-22'),
(12,26,'2026-05-04','2026-06-04',NULL),
(18,60,'2026-04-17','2026-05-17','2026-04-30'),
(20,49,'2026-05-01','2026-06-01',NULL),
(13,32,'2026-04-24','2026-05-24','2026-05-20'),
(15,38,'2026-05-25','2026-06-25',NULL),
(2,3,'2026-04-29','2026-05-29','2026-05-12'),
(8,7,'2026-05-01','2026-06-01',NULL);

UPDATE kitap_kopyalari
SET durum = 'Ödünçte'
WHERE kopya_id IN (
    SELECT kopya_id
    FROM odunc_almalar
    WHERE iade_tarihi IS NULL
);



-- INDEX'ler


CREATE INDEX idx_kitap_adi ON kitaplar(kitap_adi);

CREATE INDEX idx_uye_soyad ON uyeler(soyad);

CREATE INDEX idx_alis_tarihi ON odunc_almalar(alis_tarihi);
GO

-- VIEW'ler


CREATE VIEW vw_kitap_detaylari AS
SELECT
    k.kitap_id,
    k.kitap_adi,
    k.isbn,
    CONCAT(y.ad,' ',y.soyad) AS yazar,
    yy.yayinevi_adi,
    k.yayin_yili,
    STRING_AGG(ka.kategori_adi, ', ') AS kategoriler
FROM kitaplar k
JOIN yazarlar y ON k.yazar_id = y.yazar_id
JOIN yayinevleri yy ON k.yayinevi_id = yy.yayinevi_id
LEFT JOIN kitap_kategorileri kk ON k.kitap_id = kk.kitap_id
LEFT JOIN kategoriler ka ON kk.kategori_id = ka.kategori_id
GROUP BY
    k.kitap_id, k.kitap_adi, k.isbn,
    y.ad, y.soyad,
    yy.yayinevi_adi,
    k.yayin_yili;
GO

CREATE VIEW vw_odunc_kitaplar AS
SELECT
    o.odunc_id,
    CONCAT(u.ad,' ',u.soyad) AS uye,
    k.kitap_adi,
    o.alis_tarihi,
    o.son_teslim_tarihi,
    o.iade_tarihi,
    kk.durum
FROM odunc_almalar o
JOIN uyeler u ON o.uye_id = u.uye_id
JOIN kitap_kopyalari kk ON o.kopya_id = kk.kopya_id
JOIN kitaplar k ON kk.kitap_id = k.kitap_id;
GO


-- TRIGGER'lar


CREATE TRIGGER trg_odunc_alma
ON odunc_almalar
AFTER INSERT
AS
BEGIN
    UPDATE kitap_kopyalari
    SET durum = 'Ödünçte'
    FROM kitap_kopyalari k
    JOIN inserted i ON k.kopya_id = i.kopya_id;
END;
GO



CREATE TRIGGER trg_iade
ON odunc_almalar
AFTER UPDATE
AS
BEGIN
    UPDATE kk
    SET durum = 'Müsait'
    FROM kitap_kopyalari kk
    INNER JOIN inserted i ON kk.kopya_id = i.kopya_id
    INNER JOIN deleted d ON i.odunc_id = d.odunc_id
    WHERE d.iade_tarihi IS NULL
      AND i.iade_tarihi IS NOT NULL;
END;
GO

-- PROCEDURES


CREATE PROCEDURE sp_uye_ekle
    @ad NVARCHAR(50),
    @soyad NVARCHAR(50),
    @telefon VARCHAR(20),
    @email VARCHAR(100),
    @adres NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO uyeler(ad, soyad, telefon, email, adres)
    VALUES (@ad, @soyad, @telefon, @email, @adres);
END;
GO



CREATE PROCEDURE sp_uye_oduncleri
    @uye_id INT
AS
BEGIN
    SELECT
        k.kitap_adi,
        o.alis_tarihi,
        o.son_teslim_tarihi,
        o.iade_tarihi
    FROM odunc_almalar o
    JOIN kitap_kopyalari kk ON o.kopya_id = kk.kopya_id
    JOIN kitaplar k ON kk.kitap_id = k.kitap_id
    WHERE o.uye_id = @uye_id;
END;
GO



CREATE PROCEDURE sp_kitap_odunc_ver
    @uye_id INT,
    @kopya_id INT,
    @alis_tarihi DATE,
    @son_teslim_tarihi DATE
AS
BEGIN

    IF EXISTS (
        SELECT 1
        FROM kitap_kopyalari
        WHERE kopya_id = @kopya_id
        AND durum = 'Ödünçte'
    )
    BEGIN
        THROW 50001, 'Kitap şu anda ödünçte.',1;
        
    END

    INSERT INTO odunc_almalar
    (
        uye_id,
        kopya_id,
        alis_tarihi,
        son_teslim_tarihi
    )
    VALUES
    (
        @uye_id,
        @kopya_id,
        @alis_tarihi,
        @son_teslim_tarihi
    );

END;
GO



CREATE PROCEDURE sp_kitap_iade
    @odunc_id INT
AS
BEGIN
UPDATE odunc_almalar
    SET iade_tarihi = CAST(GETDATE() AS DATE)
    WHERE odunc_id = @odunc_id;

END;
GO




CREATE PROCEDURE sp_kitap_ekle
    @kitap_adi NVARCHAR(200),
    @isbn VARCHAR(20),
    @yazar_ad NVARCHAR(50),
    @yazar_soyad NVARCHAR(50),
    @yayinevi_adi VARCHAR(150),
    @kategori_adi NVARCHAR(100),
    @yayin_yili INT,
    @kopya_sayisi INT
AS
BEGIN
    DECLARE @yazar_id INT, @yayinevi_id INT, @kategori_id INT, @kitap_id INT;

    -- YAZAR YOKSA YAZAR EKLE
    SELECT @yazar_id = yazar_id
    FROM yazarlar
    WHERE ad = @yazar_ad AND soyad = @yazar_soyad;

    IF @yazar_id IS NULL
    BEGIN
        INSERT INTO yazarlar(ad, soyad)
        VALUES (@yazar_ad, @yazar_soyad);

        SET @yazar_id = SCOPE_IDENTITY();
    END

    -- YAYINEVİ YOKSA YAYINEVİ EKLE
    SELECT @yayinevi_id = yayinevi_id
    FROM yayinevleri
    WHERE yayinevi_adi = @yayinevi_adi;

    IF @yayinevi_id IS NULL
    BEGIN
        INSERT INTO yayinevleri(yayinevi_adi)
        VALUES (@yayinevi_adi);

        SET @yayinevi_id = SCOPE_IDENTITY();
    END

    -- KİTAP EKLE
    INSERT INTO kitaplar(isbn, kitap_adi, yazar_id, yayinevi_id, yayin_yili)
    VALUES (@isbn, @kitap_adi, @yazar_id, @yayinevi_id, @yayin_yili);

    SET @kitap_id = SCOPE_IDENTITY();

    -- KATEGORİ YOKSA KATEGORİ EKLE
    SELECT @kategori_id = kategori_id
    FROM kategoriler
    WHERE kategori_adi = @kategori_adi;

    IF @kategori_id IS NULL
    BEGIN
        INSERT INTO kategoriler(kategori_adi)
        VALUES (@kategori_adi);

        SET @kategori_id = SCOPE_IDENTITY();
    END

    INSERT INTO kitap_kategorileri(kitap_id, kategori_id)
    VALUES (@kitap_id, @kategori_id);

    -- KOPYA EKLE
    DECLARE @i INT = 1;
    WHILE @i <= @kopya_sayisi
    BEGIN
        INSERT INTO kitap_kopyalari(kitap_id) VALUES (@kitap_id);
         SET @i = @i + 1;
    END
END;
GO



