# e-Handbook : Socials Tab

> _The Electronic Student Handbook, or e-Handbook for short, is a digital handbook used by the students of Hope's Peak Academy and the Ultimate Academy for Gifted Juveniles. The latest e-Handbook edition now features a **Socials Tab** where students can find friends more easily._

## How Does It Work
Pemecahan masalah diawali dengan memecah deskripsi persoalan yang diberikan menjadi beberapa modul terpisah yang dapat diimplementasikan satu-persatu, yakni:
- Input file dan representasi graf
- Fitur friend recommendation
- Fitur explore friends menggunakan BFS
- Fitur explore friends menggunakan DFS
- Implementasi GUI
1. **Input file dan representasi graf**\
Representasi graf memiliki pertimbangan pemilihan struktur data yang paling memudahkan implementasi fitur-fitur lainnya. Dictionary dipilih karena kemudahan akses, menambah dan mengurangi elemen, serta dipisahkannya tiap elemen menjadi key dan value. Pada implementasi graf program ini, key adalah nama vertice (string), dan value adalah hashmap dari setiap nama vertice yang bertetangga dengan vertice tersebut.
2. **Fitur friend recommendation**\
Method Friend Recommendation sebenarnya merupakan implementasi sederhana dari Algoritma BFS dan memiliki batasan pencarian hingga pada depth kedua untuk mendapatkan semua  kemungkinan himpunan penyelesaian. Kemudian dilakukan pengecekan kembali untuk mengeliminasi node-node yang merupakan himpunan adjacent dari node yang dicari. 
3. **Implementasi GUI**\
Dalam mengimplementasikan Graphical User Interface atau GUI yang didesain, diperlukan tiga buah Windows Form yang terdiri dari halaman utama, halaman untuk Explore Friends, dan halaman untuk Friend Recommendation. Untuk menampilkan bentuk graf, digunakan library tambahan Microsoft Auto Graph Layout.

## Requirement and Installation
Untuk menjalankan aplikasi e-Handbook : Socials Tab dapat langsung membuka *executable file*-nya pada
```
./bin/e-Hanbook.exe
```
Sebagai contoh kasus-kasus yang dapat digunakan terdapat di dalam folder `./test` yang sudah tersedia beberapa file graf sesuai format.

## Author

Aplikasi ini disusun untuk memenuhi tugas besar mata kuliah IF2211 Strategi Algoritma oleh:

- 13519083 Shaffira Alya Mevia | [@salyamevia](https://github.com/salyamevia)
- 13519111 Febriawan Ghally Ar Rahman | [@ghally](https://github.com/ghallyy)
- 13519166 Karina Imani | [@imanikarina](https://github.com/imanikarina)
