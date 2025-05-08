import mathutils.Calculator;

public class CalculatorTest {
    public static void main(String[] args) {
        Calculator calc = new Calculator();

        int a = 20, b = 5;

        System.out.println("Addition: " + calc.add(a, b));
        System.out.println("Subtraction: " + calc.subtract(a, b));
        System.out.println("Multiplication: " + calc.multiply(a, b));
        System.out.println("Division: " + calc.divide(a, b));
    }
}
