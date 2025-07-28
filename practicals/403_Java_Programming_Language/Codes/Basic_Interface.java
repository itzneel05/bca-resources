// Question:
// Create an interface Printable with a method print(). Implement it in two classes with different outputs.

// Interface definition
interface Printable {
    void print(); // Method to be implemented by classes that implement this interface
}

// Class implementing the Printable interface
class classA implements Printable {
    @Override
    public void print() {
        System.out.println("Class A: Hello from Class A!");
    }
}
class classB implements Printable {
    @Override
    public void print() {
        System.out.println("Class B: Hello from Class B!");
    }
}
    
// Main class
class Basic_Interface {
    // This is the main method where the program execution
    public static void main(String[] args) {

        classA a = new classA(); // Create an instance of classA
        classB b = new classB(); // Create an instance of classB    

        a.print(); // Call the print method of classA
        b.print(); // Call the print method of classB
    }
}
