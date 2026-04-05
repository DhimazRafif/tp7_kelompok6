uusing System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace tpmodul7_kelompok_6
{
    public class DataMahasiswa103082400002
    {
        public string nama;
        public string nim;
        public string fakultas;
    }

    internal class DataMahasiswa_103082400002
    {
        public void ReadJSON()
        {
            string filename = "tp7_1_103082400002.json";
            string json = File.ReadAllText(filename);

            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };

                var mhs = JsonSerializer.Deserialize<DataMahasiswa103082400030>(json, options);

                Console.WriteLine($"Nama {mhs.nama} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error JSON parsing " + ex.Message);
            }
        }
    }
}