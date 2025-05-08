import stores.Stock;

public class Sales extends Stock {
    public int qty_sold;

    public Sales(int item_no, String item_name, int stock_available, double cost, int qty_sold) {
        super(item_no, item_name, stock_available, cost);
        this.qty_sold = qty_sold;
    }

    public void sell() {
        if (qty_sold <= stock_available) {
            stock_available -= qty_sold;
            System.out.println(qty_sold + " units sold of item: " + item_name);
        } else {
            System.out.println("Not enough stock to sell " + qty_sold + " units of " + item_name);
        }
    }

    public static void main(String[] args) {
        Sales item1 = new Sales(101, "Pen", 50, 10.5, 10);
        Sales item2 = new Sales(102, "Notebook", 30, 25.0, 5);

        System.out.println("=== Initial Stock ===");
        item1.displayStock();
        item2.displayStock();

        System.out.println("\n=== Processing Sales ===");
        item1.sell();
        item2.sell();

        System.out.println("\n=== Stock After Sale ===");
        item1.displayStock();
        item2.displayStock();

        System.out.println("\n=== Adding New Stock ===");
        item1.addStock(20);
        item2.addStock(10);

        System.out.println("\n=== Final Stock ===");
        item1.displayStock();
        item2.displayStock();
    }
}
