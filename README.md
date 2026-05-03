<p align="center">
  <img src="https://img.shields.io/badge/Windows-10%2B-blue?style=for-the-badge&logo=windows">
  <img src="https://img.shields.io/badge/.NET-10.0-purple?style=for-the-badge&logo=dotnet">
  <img src="https://img.shields.io/badge/ExifTool-green?style=for-the-badge">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/status-stable-brightgreen?style=for-the-badge">
  <img src="https://img.shields.io/badge/drag%26drop-yes-orange?style=for-the-badge">
</p>

---

<div align="center">
  <h1>🗑️ Metadata Stripper</h1>
  <p>remove all metadata (GPS, camera data, author info, comments) from any file</p>
</div>

---

## 📦 what this is

drop any file onto the .exe and it strips all metadata using ExifTool.

no GUI, no bloat.

this is not my metadata remover — that's ExifTool. this is just a wrapper that makes it drag & drop. all the heavy lifting is done by ExifTool by Phil Harvey.

---

<details>
  <summary><b>🎯 how to use</b></summary>

### the only way you'll use it

1. make sure exiftool.exe is in the SAME folder as Exif Tool.exe
2. grab any file (or multiple files)
3. drag them onto Exif Tool.exe
4. click OK on the popup
5. done. program closes itself

### command line (if you're fancy)

"Exif Tool.exe" "C:\Users\you\Desktop\photo.jpg"

</details>

<details>
  <summary><b>🔧 what gets removed</b></summary>

everything. literally everything:

• GPS coordinates and location data
• camera model, lens, settings
• author name and copyright
• edit history and software
• thumbnails and previews
• device serial numbers
• timestamps
• comments and descriptions

the command it runs:
exiftool -all= -overwrite_original "file"

</details>

<details>
  <summary><b>🛠️ building from source (for devs)</b></summary>

requirements:
- .NET 10.0 SDK
- Visual Studio 2022 (or any C# IDE)

build command:

dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./publish

the .exe will be in the publish folder. copy it next to exiftool.exe and you're done.

</details>

<details>
  <summary><b>❓ troubleshooting</b></summary>

"exiftool.exe not found"
→ put exiftool.exe in the same folder as the program

nothing happens when dragging
→ make sure you're dragging ONTO the .exe file, not next to it

files not stripped
→ check if files are read-only or open in another program

program opens and closes too fast
→ that's intentional. 

</details>

---

## 🔐 security

- no internet connection. ever.
- no data collection. at all.
- everything runs locally on your machine.

---

## 📄 credits

- ExifTool by Phil Harvey — exiftool.org
- built with .NET 10.0 Windows Forms

---

## 💡 tips

- pin the .exe to your taskbar for faster access
- works with: JPG, PNG, GIF, BMP, PDF, DOCX, XLSX, PPTX, MP4, MP3, and anything else ExifTool supports

---

<div align="center">
  <p>─────────────────────────────────────────</p>
  <p>made for people who are Paranoid</p>
</div>
