public class Company {
    public Utility<ProductIF> utility;
}

public class Utility<T> {
    string sortName { get; set; }
    public Utility() { this.sortName = "bubblesort"; }
    public Utility(string sortName) { this.sortName = sortName; }
    public string getName() { /* simple code */ }
    public List<T> sort(List<T> data) {  /* bubblesort simple code */ }
}