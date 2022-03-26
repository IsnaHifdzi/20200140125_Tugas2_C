using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = LAPTOP-BCV032MA; database = exerices; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand(
                "insert into Toko (Id_Pemilik, Nama_Toko, Alamat, Nomer_hp) values ('Isna Hifdzi', 'DisniyCake', 'Desa Podosari', '081234567891')"
                + "insert into Kue (Id_kue, nama_kue) values ('01', 'Pukis')"
                + "insert into Kue (Id_kue, nama_kue) values ('02', 'Bika Ambon')"
                + "insert into Kue (Id_kue, nama_kue) values ('03', 'Lapis')"
                + "insert into Kue (Id_kue, nama_kue) values ('04', 'Cucur')"
                + "insert into harga (nama_kue, Harga_satuan) values ('Pukis', '1000')"
                + "insert into harga (nama_kue, Harga_satuan) values ('Bika Ambon', '1000')"
                + "insert into harga (nama_kue, Harga_satuan) values ('Lapis', '35000')"
                + "insert into harga (nama_kue, Harga_satuan) values ('Cucur', '5000')"
                + "insert into  Transksi (Id_Transaksi, Harga_satuan, Id_kue, Banyaknya, nama_kue, Jumplah, Id_Pemilik) values ('001','1000','01','1','Pukis','2','2000','Isna Hifdzi')"
                + "insert into  Transksi (Id_Transaksi, Harga_satuan, Id_kue, Banyaknya, ama_kue, Jumplah,Id_Pemilik) values ('002','1500','01','1','Bika Ambon','1','1500','Isna Hifdzi')"
                + "insert into  Transksi (Id_Transaksi, Harga_satuan, Id_kue, Banyaknya, Nama_kue, Jumplah,Id_Pemilik) values ('001','35000','01','1','Lapis','1','25000','Isna Hifdzi')"
                + "insert into  Transksi (Id_Transaksi, Harga_satuan, Id_kue, Banyaknya, Nama_kue, Jumplah,Id_Pemilik) values ('001','5000','01','1','Cucur','1','5000','Isna Hifdzi')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Kesalahan Terdeteksi !?." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}