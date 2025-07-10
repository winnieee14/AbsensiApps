# Absensi Apps - Web Developer Internship Pre-Test

## 🧱 Struktur Tabel

### 🔹 Employee
| Kolom     | Tipe       | Keterangan     |
|-----------|------------|----------------|
| NIK       | VARCHAR(10)| Primary Key    |
| Nama      | VARCHAR(100)| Nama Pegawai  |

### 🔹 Absen
| Kolom         | Tipe     | Keterangan                 |
|---------------|----------|----------------------------|
| ID            | INT      | Primary Key (Identity)     |
| NIK           | VARCHAR  | Foreign key ke Employee    |
| TanggalAbsen  | DATE     | Tanggal kehadiran          |

---


## 🖼️ Tampilan Halaman

### Halaman Input Absen
![Form Input](assets/image1.png)

### Halaman Tabel Absensi
![Tabel Join](.../image2.png)

###  Kehadiran Harian dan Rekap Bulanan (Soal 3 dan 4)
![Matrix](.../image34.png)



---


## ⚙️ Cara Install & Run

1. **Clone repo:**
   
   git clone https://github.com/username/absensi-app.git](https://github.com/winnieee14/AbsensiApps.git
   


2. **Buka di Visual Studio**  
Buka file solusi (`.sln`) di dalam Visual Studio.

3. **Restore dan Build**  
Tekan `Ctrl + Shift + B` untuk build project.  
Pastikan semua dependency berhasil di-restore dan tidak ada error.

4. **Import Database**  
- Buka file `Database/AbsensiDB.sql`
- Buka SQL Server Management Studio (SSMS) atau SQL Server Object Explorer di Visual Studio
- Buat database baru bernama `AbsensiDB` (jika belum ada)
- Eksekusi script SQL untuk membuat tabel dan mengisi sample data

5. **Jalankan Aplikasi**  
- Tekan `Ctrl + F5` untuk menjalankan project


---
