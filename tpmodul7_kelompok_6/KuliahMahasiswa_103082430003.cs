using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_6
{
    public class MataKuliah
    {
        public string kode_mata_kuliah;
        public string nama_mata_kuliah;
    }
    public class KuliahMahasiswa
    {
        public List<MataKuliah> courses;
    }
    internal class KuliahMahasiswa_103082430003
    {
        public void ReadJSON()
        {
            string filename = "tp7_2_103082430003.json";
            string json = File.ReadAllText(filename);
            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };

                List<MataKuliah> daftarMatkul = JsonSerializer.Deserialize<List<MataKuliah>>(json, options);
                Console.WriteLine("Daftar mata kuliah yang diambil : ");
                int i = 1;
                foreach (var mk in daftarMatkul) {
                    Console.WriteLine($"MK{i} {mk.kode_mata_kuliah} - {mk.nama_mata_kuliah}");
                    i++;
                }
                
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error JSON parsing : "+ex.Message);
            }
        }
    }
}
