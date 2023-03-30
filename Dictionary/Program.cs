internal class Program
{
    private static void Main(string[] args)
    {
         Dictionary<int,string> sinif1= new Dictionary<int,string>();
        sinif1.Add(110, "Ahmet");
        Console.WriteLine(sinif1.Count);

        MyDictionary<int,string> sinif2 = new MyDictionary<int,string>();
        sinif2.Add(120, "Aişe");
        sinif2.Add(122, "Ahmet");
        Console.WriteLine(sinif2.Count);
        for (int i = 0; i < sinif2.Count; i++)
        {
            int ogrenciNo = sinif2.keys[i];
            string ogrenciAdi= sinif2.values[i];    
            Console.WriteLine(" Okul no :" + ogrenciNo + "\n Öğrenci isim : " + ogrenciAdi);
        }
    
    }
}

class MyDictionary<T,U>
{
   
    public T[] keys;
    public U[] values;
   
    public MyDictionary()
    {
        keys = new T[0];
        values = new U[0];
    }
    public void Add(T key,U value)
    {
        T[] tempArray1 = keys;
        U[] tempArray2 = values;

        keys=new T[keys.Length+1];
        values=new U[values.Length+1];

        for(int i = 0; i < tempArray1.Length; i++)
        {
            keys[i] = tempArray1[i];
            values[i] = tempArray2[i];
        }
        keys[keys.Length-1] = key;
        values[values.Length-1] =value;

    }

    

    public int Count
    {
        get { return keys.Length; }
      
    }



}