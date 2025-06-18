# FixRegistry - Game Protocol Registry Fixer

A simple C# utility to automatically update the Windows Registry for custom game URI protocols (e.g., `yourgame://launch`). This tool is designed for games that can be moved to different directories, ensuring that web-based launchers continue to work correctly without manual registry edits.

This repository contains the source code only. You will need to build the executable yourself.

---

### 🇮🇩 [Baca dalam Bahasa Indonesia](#-deskripsi-bahasa-indonesia)

---

## 🇬🇧 English Description

### The Problem

Many games use a custom URI protocol to launch from a website. This is registered in the Windows Registry with a hardcoded path to the game's executable. If a user moves the game folder to a new location (e.g., from `C:\Games` to `D:\MyGames`), the registry path becomes invalid, and the launcher link breaks.

### The Solution

This tool solves that problem. By building and running this application from the game's root folder, it will automatically:
1.  Detect its current location.
2.  Find the main game executable in the same folder.
3.  Update the necessary Windows Registry keys to point to the new, correct path.

### Getting Started: How to Build and Use

Since no pre-compiled executable is provided, you must build it from the source code first.

#### Step 1: Prerequisites
You need the .NET SDK installed on your computer. If you don't have it, you can download it here:
* [.NET 8.0 SDK (or newer)](https://dotnet.microsoft.com/download)

Alternatively, you can use Visual Studio with the ".NET desktop development" workload installed.

#### Step 2: Build the Application

First, clone this repository to your local machine:
```sh
git clone [https://github.com/xenodev29/fixregistry.git](https://github.com/xenodev29/fixregistry.git)
```
Then, choose one of the following methods to build it:

**Method A: Using the Command Line**
1.  Open a Command Prompt or PowerShell.
2.  Navigate into the cloned repository's directory:
    ```sh
    cd fixregistry
    ```
3.  Run the build command:
    ```sh
    dotnet build --configuration Release
    ```
4.  The executable (`FixRegistry.exe`) will be located in the `bin/Release/net8.0/` folder.

**Method B: Using Visual Studio**
1.  Open the `FixRegistry.sln` file in Visual Studio.
2.  In the top menu, set the build configuration to **Release**.
3.  Build the solution by pressing `Ctrl+Shift+B` or by going to **Build > Build Solution**.
4.  The executable will be in the project's `bin/Release/net8.0/` folder.

#### Step 3: Use the Application
1.  Copy the compiled `FixRegistry.exe` into your main game folder (the same folder that contains `GameLauncher.exe`).
2.  Whenever the web launcher stops working after moving the game, **right-click** on `FixRegistry.exe` and select **"Run as administrator"**.
3.  Done! The registry path is now corrected.

### Configuration

If you want to adapt this tool for a different game, you can easily modify the configuration at the top of the `Program.cs` file:
```csharp
string protocolName = "gameproject";
string gameExecutableName = "GameLauncher.exe";
```

### License
This project is licensed under the MIT License.

---
---

## 🇮🇩 Deskripsi Bahasa Indonesia

### Permasalahan
Banyak game menggunakan protokol URI khusus untuk bisa dijalankan dari website. Protokol ini didaftarkan di Registri Windows dengan path (lokasi) yang spesifik ke file `.exe` game. Jika pengguna memindahkan folder game, path di registri menjadi tidak valid dan tautan dari website akan rusak.

### Solusi
Aplikasi ini menyelesaikan masalah tersebut. Dengan membangun (build) dan menjalankan aplikasi ini dari folder utama game, ia akan secara otomatis:
1.  Mendeteksi lokasi barunya.
2.  Menemukan file `.exe` utama game di folder yang sama.
3.  Memperbarui kunci Registri Windows agar menunjuk ke path yang benar.

### Panduan Memulai: Cara Membangun dan Menggunakan
Repositori ini tidak menyediakan file `.exe` yang sudah jadi. Anda harus membuatnya sendiri dari kode sumber yang tersedia.

#### Langkah 1: Prasyarat
Anda wajib memiliki .NET SDK yang terinstal di komputer. Jika belum punya, Anda dapat mengunduhnya di sini:
* [.NET 8.0 SDK (atau yang lebih baru)](https://dotnet.microsoft.com/download)

Sebagai alternatif, Anda bisa menggunakan Visual Studio yang sudah terinstal dengan *workload* ".NET desktop development".

#### Langkah 2: Membangun Aplikasi
Pertama, salin (clone) repositori ini ke komputer Anda:
```sh
git clone [https://github.com/xenodev29/fixregistry.git](https://github.com/xenodev29/fixregistry.git)
```
Selanjutnya, pilih salah satu metode berikut untuk membangunnya:

**Metode A: Menggunakan Command Line**
1.  Buka Command Prompt atau PowerShell.
2.  Masuk ke dalam direktori repositori yang sudah di-clone:
    ```sh
    cd fixregistry
    ```
3.  Jalankan perintah build:
    ```sh
    dotnet build --configuration Release
    ```
4.  File `FixRegistry.exe` yang sudah jadi akan berada di folder `bin/Release/net8.0/`.

**Metode B: Menggunakan Visual Studio**
1.  Buka file `FixRegistry.sln` menggunakan Visual Studio.
2.  Pada menu atas, atur konfigurasi build ke **Release**.
3.  Bangun solusinya dengan menekan `Ctrl+Shift+B` atau melalui menu **Build > Build Solution**.
4.  File `.exe` akan berada di folder `bin/Release/net8.0/` proyek.

#### Langkah 3: Menggunakan Aplikasi
1.  Salin file `FixRegistry.exe` yang sudah Anda bangun ke folder utama game Anda (folder yang sama dengan `GameLauncher.exe`).
2.  Setiap kali peluncur web berhenti berfungsi setelah Anda memindahkan folder game, **klik kanan** pada `FixRegistry.exe` dan pilih **"Run as administrator"**.
3.  Selesai! Path di registri kini telah diperbaiki.

### Konfigurasi
Jika Anda ingin mengadaptasi aplikasi ini untuk game lain, Anda bisa dengan mudah mengubah konfigurasi di bagian atas file `Program.cs`:
```csharp
string protocolName = "gameproject";
string gameExecutableName = "GameLauncher.exe";
```

### Lisensi
Proyek ini dilisensikan di bawah Lisensi MIT.
