// Question:
// Create a calculator application that accepts operands and operator (+, -, *, /) from the command line and displays the result.

class CalcCommandLine {
    public static void main(String[] args) {
        // Check if the user provided enough command line arguments
        if (args.length < 3) {
            System.out.println("Please Give Details In <operand1> <operator> <operand2>");
            return;
        }

        // Parse the operands and operator from command line arguments
        double operand1 = Double.parseDouble(args[0]);
        String operator = args[1];
        double operand2 = Double.parseDouble(args[2]);
        double result = 0;

        // Perform the calculation based on the operator
        switch (operator) {
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                result = operand1 / operand2;
                break;
            default:
                System.out.println("Error: Invalid operator. Use +, -, *, or /.");
                return;
        }

        // Display the result of the calculation
        System.out.println("Result: " + result);
    }
}
