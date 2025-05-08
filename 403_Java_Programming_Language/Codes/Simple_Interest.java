// Question:
// Write a Java Program to calculate simple interest using Command  line Arguments.
class Simple_Interest {
    public static void main(String[] args) {
        // Check if the user provided enough command line arguments
        if (args.length < 3) {
            System.out.println("Please Give Details In <principal> <rate> <time>");
            return;
        }

        // Parse the command line arguments to double values
        double principal = Double.parseDouble(args[0]);
        double rate = Double.parseDouble(args[1]);
        double time = Double.parseDouble(args[2]);

        // Calculate simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Display the result
        System.out.println("Simple Interest: " + simpleInterest);
    }
}
