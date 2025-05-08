// Question:
// Write a program that shows multiple interface implementation in a single class.


// interface 1
interface Hello {
    void printHello(); // Method to be implemented by classes that implement this interface
}

// interface 2
interface world {
    void printWorld(); // Method to be implemented by classes that implement this interface
} 

// This class implements both Hello and world interfaces
class demo implements Hello, world {
    @Override
    public void printHello() {
        System.out.print("Hello ");
    }

    @Override
    public void printWorld() {
        System.out.print("World!");
    }
}
    
// Main class
class Basic_Interface_v2 {
    public static void main(String[] args) {
        demo d = new demo(); // Create an instance of demo class
        d.printHello(); // Call the printHello method
        d.printWorld(); // Call the printWorld method
    }
}
