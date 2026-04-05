using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace tpmodul7_kelompok_6
{
    public class MataKuliah103082400002
    {
        public string kode_mata_kuliah;
        public string nama_mata_kuliah;
    }

    internal class KuliahMahasiswa_103082400002
    {
        public void ReadJSON()
        {
            string filename = "tp7_2_103082400002.json";
            string json = File.ReadAllText(filename);

            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };

                List<MataKuliah103082400002> daftarMatkul =
                    JsonSerializer.Deserialize<List<MataKuliah103082400002>>(json, options);

                Console.WriteLine("Daftar mata kuliah yang diambil : ");

                int i = 1;
                foreach (var mk in daftarMatkul)
                {
                    Console.WriteLine($"MK{i} {mk.kode_mata_kuliah} - {mk.nama_mata_kuliah}");
                    i++;
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error JSON parsing : " + ex.Message);
            }
        }
    }
}