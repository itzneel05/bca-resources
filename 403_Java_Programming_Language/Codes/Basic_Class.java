/*Question : Create Class And Data Member + Method + Contructor*/

class Basic_Class {
    // Instance variable
    int x;

    // Constructor
    Basic_Class(int x) {
        this.x = x;
    }

    // Method to display the value of x
    void display() {
        System.out.println("Value of x: " + x);
    }

    public static void main(String[] args) {
        // Creating an object of Basic_Class
        Basic_Class obj = new Basic_Class(10);
        obj.display(); // Output: Value of x: 10
    }
}