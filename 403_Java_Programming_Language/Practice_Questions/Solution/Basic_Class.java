// Question:
// Write a program which will display information of a particular product. Product class have following properties:
// Data Members: [ Pr no | Pr_name | Quanity | Price per unit ]
// Methods: constructor () - for insertion of a product information. | search ()- which will search information of product, search will be done by product name given by user. | display ()- which will display information of a product.

class Product {
    private int prNo;
    private String prName;
    private int quantity;
    private double pricePerUnit;

    // Constructor for inserting product information
    public Product(int prNo, String prName, int quantity, double pricePerUnit) {
        this.prNo = prNo;
        this.prName = prName;
        this.quantity = quantity;
        this.pricePerUnit = pricePerUnit;
    }

    // Method to search for a product by name
    public boolean search(String name) {
        return this.prName.equalsIgnoreCase(name);
    }

    // Method to display product information
    public void display() {
        System.out.println("Product No: " + prNo);
        System.out.println("Product Name: " + prName);
        System.out.println("Quantity: " + quantity);
        System.out.println("Price per Unit: " + pricePerUnit);
    }
}

class Basic_Class {
    public static void main(String[] args) {
        // Create a product object with sample data
        Product product = new Product(101, "Laptop", 50, 750.00);
        Product product2 = new Product(102, "Smartphone", 100, 500.00);
        Product product3 = new Product(103, "Tablet", 75, 300.00);

        // Search for the product by name
        String searchName = "Laptop";
        if (product.search(searchName)) {
            System.out.println("Product found:");
            product.display(); // Display product information if found
        } else {
            System.out.println("Product not found.");
        }
    }
}
