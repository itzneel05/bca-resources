// Question:
// Write a program to create interface area. Create three classes called rectangle, triangle, and square calculate areas respectively

interface area {
    double calculateArea(); // Method to calculate area
}

class Rectangle implements area {
    private double length; // Length of the rectangle
    private double width; // Width of the rectangle

    public Rectangle(double length, double width) {
        this.length = length; // Constructor to initialize length
        this.width = width; // Constructor to initialize width
    }

    @Override
    public double calculateArea() {
        return length * width; // Calculate area of the rectangle
    }
}

class Triangle implements area {
    private double base; // Base of the triangle
    private double height; // Height of the triangle

    public Triangle(double base, double height) {
        this.base = base; // Constructor to initialize base
        this.height = height; // Constructor to initialize height
    }

    @Override
    public double calculateArea() {
        return 0.5 * base * height; // Calculate area of the triangle
    }
}

class Square implements area {
    private double side; // Side of the square

    public Square(double side) {
        this.side = side; // Constructor to initialize side
    }

    @Override
    public double calculateArea() {
        return side * side; // Calculate area of the square
    }
}

class ShapesInterface {
    public static void main(String[] args) {
        area rectangle = new Rectangle(5, 10); // Create a rectangle object
        area triangle = new Triangle(4, 8); // Create a triangle object
        area square = new Square(6); // Create a square object

        System.out.println("Area of Rectangle: " + rectangle.calculateArea()); // Display area of rectangle
        System.out.println("Area of Triangle: " + triangle.calculateArea()); // Display area of triangle
        System.out.println("Area of Square: " + square.calculateArea()); // Display area of square
    }
}
