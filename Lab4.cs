public class Company {
    public Utility<ProductIF> utility;
}

public class T {
    private string id;
    public string name;
    public double price;

    public T() {
        this.id = "0";
        this.name = "generic";
        this.price = 0.00;
    }
    public T(string id, string name, double price) {
        this.id = id;
        this.name = name;
        this.price = price;
    }
}

public class Utility<T> {
    string sortName { get; set; }
    public Utility() { this.sortName = "bubblesort"; }
    public Utility(string sortName) { this.sortName = sortName; }
    public string getName() { /* simple code */ }
    public List<T> sort(List<T> data) {
        
    }
}