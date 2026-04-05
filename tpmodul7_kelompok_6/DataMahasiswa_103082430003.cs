using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_6
{
    public class DataMahasiswa
    {
        public string nama;
        public string nim;
        public string fakultas;
    }
    internal class DataMahasiswa_103082430003
    {
        public void ReadJSON()
        {
            string filename = "tp7_1_103082430003.json";
            string json = File.ReadAllText(filename);

            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };

                var mhs = JsonSerializer.Deserialize<DataMahasiswa>(json, options);

                Console.WriteLine($"Nama {mhs.nama} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error JSON parsing" + ex.Message );
            }

        }
    }
}
