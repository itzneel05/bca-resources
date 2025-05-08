/*Question:
* Override a method in the child class and call both base and overridden versions */


class Vehicle {
    // Attributes common to all vehicles
    private String brand;
    private String color;

    public Vehicle(String brand, String color) {
        this.brand = brand;
        this.color = color;
    }
    
    public void display() {
        System.out.println("Vehicle Information:");
        System.out.println("Brand: " + brand);
        System.out.println("Color: " + color);
    }
}

// Car class - inherits from Vehicle class (Car IS-A Vehicle)
// This class demonstrates method overriding and calling both base and overridden versions
class Car extends Vehicle {
    // Additional attributes specific to Car
    private int airBags;
    
    public Car(String brand, String color, int airBags ) {
        // Call parent constructor to set the brand and color
        super(brand, color);
        
        // Set Car-specific attributes
        this.airBags = airBags;
    }
    

     // Override the display method from the parent class
     // This method demonstrates how to override a method and call the parent version

    @Override
    public void display() {
        // Call the parent class version of the method
        System.out.println("Base + Override Info:");
        super.display();
        
        // Add Car-specific information
        System.out.println("Number of AirBags: " + airBags);
    }
    
    
    // Calling only the base version from within a child class method
    
    public void displayBaseInfoOnly() {
        System.out.println("\nBase Info Only:");
        super.display();  // Call only the parent version of the method
    }
    
    /**
     * Demonstrate calling only the overridden version from within another method
     */
    public void displayFullInfo() {
        System.out.println("\nCalling the overridden display method:");
        this.display();  // Call the overridden method (equivalent to just display())
    }
}

// Main class
public class Overriden {
    public static void main(String[] args) {
        // Create a Car object
        Car myCar = new Car("Toyota", "Blue", 4);
        
        // Call the overridden method (which internally calls both versions)
        myCar.displayFullInfo();
        
        // Call the parent method directly from child object
        myCar.displayBaseInfoOnly();
    }
}
