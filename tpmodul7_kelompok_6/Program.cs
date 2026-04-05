using tpmodul7_kelompok_6;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa_103082430003 data = new DataMahasiswa_103082430003();
        data.ReadJSON();

        KuliahMahasiswa_103082430003 mk = new KuliahMahasiswa_103082430003();
        mk.ReadJSON();
    }
}
