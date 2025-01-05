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

            Console.Clear();
            Rata rata = new Rata();
            Grading grading = new Grading();

            for (int i = 0; i < list_mahasiswa.Count; i++)
            {
                List<int> nilaimahasiswa = new List<int> { list_matkul1[i], list_matkul2[i], list_matkul3[i] };
                double rataRata = rata.HitungRata(nilaimahasiswa);
                string grade = grading.TentukanGrade(rataRata);

                Console.WriteLine("=====================================");
                Console.WriteLine($"Nama Mahasiswa: {list_mahasiswa[i]}");
                Console.WriteLine($"Rata-rata: {rataRata}");
                Console.WriteLine($"Grade: {grade}");
            }
            MatkulPertama Algo = new MatkulPertama();
            MatkulKedua Matdis = new MatkulKedua();
            MatkulKetiga Jarkom = new MatkulKetiga();

            double rataAlgo = Algo.Matkul(list_matkul1);
            double rataMatdis = Matdis.Matkul(list_matkul2);
            double rataJarkom = Jarkom.Matkul(list_matkul3);

            Console.WriteLine(" ");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Rata rata Mata Kuliah Algoritma: {rataAlgo}");
            Console.WriteLine($"Rata rata Mata Kuliah Matematika Diskrit: {rataMatdis}");
            Console.WriteLine($"Rata rata Mata Kuliah Jaringan Komputer: {rataJarkom}");
            Console.WriteLine("=====================================");
            Console.WriteLine(" ");

            Console.ReadLine();
            
        }
        class Grading
        {
            public string TentukanGrade(double rataMahasiswa)
            {
                string grade = "";

                if (rataMahasiswa >= 90)
                {
                    grade = "A";
                }
                else if (rataMahasiswa >= 80)
                {
                    grade = "B";
                }
                else if (rataMahasiswa >= 70)
                {
                    grade = "C";
                }
                else
                {
                    grade = "D";
                }
                return grade;
            }
        }
        class Rata
        {
            public double HitungRata(List<int> nilai)
            {
                if (nilai.Count == 0)
                {
                    throw new ArgumentException("List tidak boleh kosong.");
                }
                double rata = 0;
                foreach (var num in nilai)
                {
                    rata += num;
                }
                return rata / nilai.Count;
            }
        }
        class MatkulPertama
            {
                public double Matkul(List<int> list_matkul1)
                {
                    double rataPertama = 0;
                    foreach (int num in list_matkul1)
                    {
                        rataPertama += num;
                    }
                    return rataPertama / list_matkul1.Count;
                }
            }
        class MatkulKedua
        {
            public double Matkul(List<int> list_matkul2)
            {
                double rataKedua = 0;
                foreach (int num in list_matkul2)
                {
                    rataKedua += num;
                }
                return rataKedua / list_matkul2.Count;
            }
        }        
        class MatkulKetiga
        {
            public double Matkul(List<int> list_matkul3)
            {
                double rataKetiga = 0;
                foreach (int num in list_matkul3)
                {
                    rataKetiga += num;
                }
                return rataKetiga / list_matkul3.Count;
            }
        }
    }
}
