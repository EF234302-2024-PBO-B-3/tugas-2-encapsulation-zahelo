using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */


/*Fitness Tracker 
    Atribut private: 
_userName (tipe string) – nama pengguna
_steps (tipe int) – jumlah langkah yang sudah ditempuh oleh pengguna
_caloriesBurned (tipe double) – jumlah kalori yang telah dibakar oleh pengguna
_activeMinutes (tipe int) – waktu aktif yang diukur dalam menit

    Atribut publik:
UserName – properti read-write yang memungkinkan pengguna untuk melihat dan mengatur nama pengguna, dengan validasi bahwa nama tidak boleh kosong atau null. Jika kosong atau null, set dengan "Unknown"
Steps, CaloriesBurned, dan ActiveMinutes – properti read-only yang memungkinkan pengguna melihat data kebugaran mereka

    Metode: 
AddSteps(int steps) – menambahkan langkah ke total langkah, nilai steps harus positif
AddActiveMinutes(int minutes) – menambahkan menit ke waktu aktif total, nilai minutes harus positif
AddCalories(double calories) – menambahkan kalori ke total kalori yang dibakar, nilai calories harus positif
DisplaySummary() – menampilkan ringkasan kebugaran 


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

namespace Encapsulation.Extra
{
    public class FitnessTracker
    {
        private string _userName = "Unknown";  // Inisialisasi dengan nilai default
        private int _steps = 0;
        private double _caloriesBurned = 0;
        private int _activeMinutes = 0;

        public string UserName
        {
            get { return _userName; }
            set { _userName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public int Steps
        {
            get { return _steps; }
            set { _steps = value > 0 ? value : 0; }
        }

        public double CaloriesBurned
        {
            get { return _caloriesBurned; }
            set { _caloriesBurned = value > 0 ? value : 0; }
        }

        public int ActiveMinutes
        {
            get { return _activeMinutes; }
            set { _activeMinutes = value > 0 ? value : 0; }
        }

        public FitnessTracker(string userName, int steps, double caloriesBurned, int activeMinutes)
        {
            UserName = userName;
            Steps = steps;
            CaloriesBurned = caloriesBurned;
            ActiveMinutes = activeMinutes;
        }

        public void AddSteps(int steps)
        {
            if (steps > 0)
            {
                _steps += steps;
            }
            else
            {
                Console.WriteLine("Steps must be a positive value.");
            }
        }

        public void AddActiveMinutes(int minutes)
        {
            if (minutes > 0)
            {
                _activeMinutes += minutes;
            }
            else
            {
                Console.WriteLine("Active minutes must be a positive value.");
            }
        }

        public void AddCalories(double calories)
        {
            if (calories > 0)
            {
                _caloriesBurned += calories;
            }
            else
            {
                Console.WriteLine("Calories burned must be a positive value.");
            }
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Fitness Summary for {UserName}:");
            Console.WriteLine($"Steps: {_steps}");
            Console.WriteLine($"Calories Burned: {_caloriesBurned}");
            Console.WriteLine($"Active Minutes: {_activeMinutes}");
            Console.WriteLine();
        }
    }
}

