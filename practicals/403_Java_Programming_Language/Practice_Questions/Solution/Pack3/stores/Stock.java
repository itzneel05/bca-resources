package stores;

public class Stock {
    public int item_no;
    public String item_name;
    public int stock_available;
    public double cost;

    public Stock(int item_no, String item_name, int stock_available, double cost) {
        this.item_no = item_no;
        this.item_name = item_name;
        this.stock_available = stock_available;
        this.cost = cost;
    }

    public void displayStock() {
        System.out.println("Item No: " + item_no +
                           ", Name: " + item_name +
                           ", Available: " + stock_available +
                           ", Cost: " + cost);
    }

    public void addStock(int qty) {
        stock_available += qty;
    }
}
