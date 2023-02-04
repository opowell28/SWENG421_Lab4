using Lab4;

public class Program {
    static void Main(string[] args) {
        T t1 = new T(12.25, "001", "One");
        T t2 = new T(31.32, "002", "Two");
        T t3 = new T(13.19, "003", "Three");

        List<T> list = new List<T>();

        list.Add(t1);
        list.Add(t2);
        list.Add(t3);

        Utility<T> util = new Utility<T>();
        util.sort(list);
    }
}