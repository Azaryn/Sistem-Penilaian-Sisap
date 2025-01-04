using System;

namespace SistemPenilaian
{
    public class Grading
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
}