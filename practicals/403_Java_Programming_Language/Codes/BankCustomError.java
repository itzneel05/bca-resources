// Question:
// Create a banking app that throws custom exceptions: LowBalanceException, InvalidAccountException during withdrawal and deposit operations.

class LowBalanceException extends Exception {
    // Constructor to initialize the exception message
    public LowBalanceException(String message) {
        super(message); // Call the constructor of the parent class (Exception)
    }
}
class InvalidAccountException extends Exception {
    // Constructor to initialize the exception message
    public InvalidAccountException(String message) {
        super(message); // Call the constructor of the parent class (Exception)
    }
}
class BankCustomError {
    public static void main(String[] args) {
        double balance = 1000.0; // Initial balance
        double withdrawalAmount = 1200.0; // Amount to withdraw
        String accountNumber = "123456"; // Valid account number

        try {
            // Check if the account number is valid (for demonstration, we assume "123456" is valid)
            if (!accountNumber.equals("123456")) {
                throw new InvalidAccountException("Invalid account number: " + accountNumber);
            }

            // Check if the balance is sufficient for withdrawal
            if (withdrawalAmount > balance) {
                throw new LowBalanceException("Insufficient balance for withdrawal. Current balance: " + balance);
            } else {
                balance -= withdrawalAmount; // Deduct the amount from the balance
                System.out.println("Withdrawal successful. New balance: " + balance);
            }
        } catch (LowBalanceException | InvalidAccountException e) { // Catch both exceptions
            System.out.println("Error: " + e.getMessage()); // Print exception message
        }

    }    
}

