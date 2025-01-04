using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SistemPenilaian
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Selamat Datang Mahasiswa Fasilkom");
            Console.WriteLine("==================================");
            string mahasiswa;
            List<string> list_mahasiswa = new List<string>();
            List<int> list_matkul1 = new List<int>();
            List<int> list_matkul2 = new List<int>();
            List<int> list_matkul3 = new List<int>();

            do
            {
                Console.Write("Masukan nama mahasiswa: ");
                mahasiswa = Console.ReadLine();
                list_mahasiswa.Add(mahasiswa);

                Console.Write("Masukkan nilai pertama: ");
                int matkul1 = Convert.ToInt32(Console.ReadLine());
                list_matkul1.Add(matkul1);

                Console.Write("Masukkan nilai kedua: ");
                int matkul2 = Convert.ToInt32(Console.ReadLine());
                list_matkul2.Add(matkul2);

                Console.Write("Masukkan nilai ketiga: ");
                int matkul3 = Convert.ToInt32(Console.ReadLine());
                list_matkul3.Add(matkul3);

                Console.WriteLine("Would you like to continue? [Y/N]: ");
            } while (Console.ReadLine()?.ToUpper() == "Y");

            Rata rata = new Rata();
            Grading grading = new Grading();

            for (int i = 0; i < list_mahasiswa.Count; i++)
            {
                List<int> nilaimahasiswa = new List<int> { list_matkul1[i], list_matkul2[i], list_matkul3[i] };
                double rataRata = rata.HitungRata(nilaimahasiswa);
                string grade = grading.TentukanGrade(rataRata);

                Console.WriteLine($"Nama Mahasiswa: {list_mahasiswa[i]}");
                Console.WriteLine($"Rata-rata: {rataRata}");
                Console.WriteLine($"Grade: {grade}");
            }
            Console.ReadLine();

        }
    }
}
