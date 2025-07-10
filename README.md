# Absensi Apps - Web Developer Internship Pre-Test

Sebuah aplikasi web berbasis **ASP.NET Core MVC** yang digunakan untuk mencatat dan menampilkan data absensi pegawai, dikembangkan untuk menyelesaikan **take-home test Web Developer Internship** di PT. Inovasi Sukses Sentosa.

---

## 📦 Fitur Aplikasi

✅ Form input absensi pegawai (NIK & tanggal)  
✅ Menampilkan data absen hasil JOIN (Soal 2)  
✅ Menampilkan matrix kehadiran harian (Soal 3)  
✅ Rekap absen bulanan per pegawai (Soal 4)  
✅ Validasi form + dropdown otomatis  
✅ Responsive table + tampilan rapi  

---

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

## ⚙️ Cara Install & Run

1. **Clone repo:**

```bash
git clone https://github.com/username/absensi-app.git
cd absensi-app
