using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

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
    public class FitnessTracker
    {
        private string _userName;
        private int _steps;
        private double _caloriesBurned;
        private int _activeMinutes;

        public string UserName
        {
            get { return _userName; }
            set { _userName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public int Steps
        {
            get { return _steps; }
        }

        public double CaloriesBurned
        {
            get { return _caloriesBurned; }
        }

        public int ActiveMinutes
        {
            get { return _activeMinutes; }
        }

        public FitnessTracker(string userName)
        {
            UserName = userName;
            _steps = 0;
            _caloriesBurned = 0;
            _activeMinutes = 0;
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

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create two users for fitness tracking
            FitnessTracker user1 = new FitnessTracker("John");
            FitnessTracker user2 = new FitnessTracker("Jane");

            // Add data for user 1
            user1.AddSteps(5000);
            user1.AddCalories(300);
            user1.AddActiveMinutes(60);

            // Add data for user 2
            user2.AddSteps(7500);
            user2.AddCalories(450);
            user2.AddActiveMinutes(90);

            // Display summaries
            user1.DisplaySummary();
            user2.DisplaySummary();
    }
}
