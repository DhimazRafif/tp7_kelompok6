using tpmodul7_kelompok_6;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa_103082430003 data = new DataMahasiswa_103082430003();
        data.ReadJSON();

        KuliahMahasiswa_103082430003 mk = new KuliahMahasiswa_103082430003();
        mk.ReadJSON();

        DataMahasiswa_103082400030 data2 = new DataMahasiswa_103082400030();
        data2.ReadJSON();

        KuliahMahasiswa_103082400030 mk2 = new KuliahMahasiswa_103082400030();
        mk2.ReadJSON();
    }
}
