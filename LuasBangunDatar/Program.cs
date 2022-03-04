using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks>Class BangunDatar dapat menghitung luas bangun datar</remarks>
    class BangunDatar
    {
        /// <summary>
        /// Sub class untuk menghitung luas persegi panjang
        /// </summary>
        public class PersegiPanjang
        {

            public double panjang, lebar;

            /// <summary>
            /// Method untuk input panjang dan lebar persegi panjang
            /// </summary>
            public void sisiPP()
            {
                Console.Write("Masukkan panjang = ");
                panjang = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan lebar = ");
                lebar = Convert.ToDouble(Console.ReadLine());
            }

            /// <summary>
            /// Method untuk menghitung luas persegi panjang
            /// </summary>
            /// <param name="p">Panjang persegi panjang yang telah diinputkan oleh user</param>
            /// <param name="l">Lebar persegi panjang yang telah diinputkan oleh user</param>
            /// <returns>Hasil dari rumus mencari luas persegi panjang</returns>
            public double LuasPP(double p, double l)
            {
                return p * l;
            }



            /// <summary>
            /// Method untuk menampilkan luas persgi panjang
            /// </summary>
            public void tampilPP()
            {
                Console.WriteLine("Luas Persegi panjang = " + this.LuasPP(panjang, lebar));
                Console.ReadKey();
            }
        }


        /// <summary>
        /// Sub Class untuk mencari Luas Lingkaran
        /// </summary>
        public class Lingkaran
        {

            ///
            public double jejari;

            /// <summary>
            /// Method untuk input jari-jari lingkaran
            /// </summary>
            public void jariLingkaran()
            {
                Console.Write("Masukkan jari-jari = ");
                jejari = Convert.ToDouble(Console.ReadLine());
            }

            /// <summary>
            /// Method untuk menghitung Luas lingkaran
            /// </summary>
            /// <param name="r">Jari-jari lingkaran yang telah diinputkan oleh user</param>
            /// <returns>Hasil dari rumus mencari luas lingkaran</returns>
            public double LuasLing(double r)
            {
                return 3.14 * r * r;
            }

            /// <summary>
            /// Method untuk menampilkan luas lingkaran
            /// </summary>
            public void tampilLing()
            {
                Console.WriteLine("Luas Lingkaran = " + this.LuasLing(jejari));
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Sub Class untuk mencari luas segitiga
        /// </summary>
        public class Segitiga
        {
            public double alas, tinggi;

            /// <summary>
            /// Method untuk input alas dan tinggi segitiga
            /// </summary>
            public void sisiS3()
            {
                Console.Write("Masukkan alas = ");
                alas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan tinggi = ");
                tinggi = Convert.ToDouble(Console.ReadLine());
            }

            /// <summary>
            /// Method untuk menghitung luas segitiga
            /// </summary>
            /// <param name="a">Alas dari segitiga yang telah diinputkan oleh user</param>
            /// <param name="t">Tinggi dari segitiga yang telah diinputkan oleh user</param>
            /// <returns>Hasil dari rumus untuk menghitung luas segituga</returns>
            public double LuasS3(double a, double t)
            {
                return 0.5 * a * t;
            }

            /// <summary>
            /// Method untuk menampilkan luas segitiga
            /// </summary>
            public void tampilS3()
            {
                Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Method untuk memanggil dan mengeksekusi setiap method.
        /// </summary>
        /// <param name="args">Sebuah array dalam bentuk String yang menyimpan arguments </param>
        static void Main(string[] args)
        {

            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga
                ();

            int pilih;

            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Luas Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    lk.jariLingkaran();
                    lk.tampilLing();
                    break;
                case 3:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Pilihan salah !");
                    Console.ReadKey();
                    break;
            }
        }
    }

}
