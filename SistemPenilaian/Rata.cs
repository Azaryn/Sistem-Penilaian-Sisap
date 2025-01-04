using System;
using System.Collections.Generic;

namespace SistemPenilaian
{
    public class Rata
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
}