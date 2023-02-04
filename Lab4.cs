namespace Lab4 {
    public interface ProductIF {
        double Price { get; set; }
        string Id { get; set; }
        string Name { get; set; }
    }

    public class T : ProductIF {
        public double Price { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public T() {
            this.Price = 0.00;
            this.Id = "000";
            this.Name = "generic";
        }

        public T(double price, string id, string name) {
            this.Price = price;
            this.Id = id;
            this.Name = name;
        }
    }

    public class Company {
        public Utility<ProductIF> utility;
    }

    public class Utility<T> where T : ProductIF {
        string sortName { get; set; }
        public Utility() { this.sortName = "bubblesort"; }
        public Utility(string sortName) { this.sortName = sortName; }
        public string getName() { return sortName; }
        public List<T> sort(List<T> data) {
            T temp;
            for (int j = 0; j <= data.Count - 2; j++) {
                for (int i = 0; i <= data.Count - 2; i++) {
                    if (data[i].Price > data[i + 1].Price) {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (T p in data)
                Console.Write(p.Id + ", " + p.Name + ", " + p.Price + " | ");
            Console.Read();
            return data;
        }
    }
}