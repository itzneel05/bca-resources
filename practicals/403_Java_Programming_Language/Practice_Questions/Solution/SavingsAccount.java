/* Question:
 * Design a system where multiple subclasses (like SavingsAccount, CurrentAccount) inherit from a base class BankAccount and implement custom methods for each. */

// abstract class BankAccount
abstract class BankAccount {
    protected String accountNumber;
    protected String accountHolderName;
    protected double balance;

    // Constructor to initialize account details
    public BankAccount(String accountNumber, String accountHolderName, double balance) {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = balance;
    }

    // Method to deposit money into the account
    public void deposit(double amount) {
        if (amount > 0) {
            balance += amount;
            System.out.println("Deposited: " + amount + " To account: " + accountHolderName);
        }
        else // Negative amount : error message
            System.out.println("Deposit amount must be positive.");
    }

    public abstract void withdraw(double amount);  // must be implemented by subclasses

    public abstract void displayInfo();
}

// SavingsAccount class - inherits from BankAccount class (SavingsAccount IS-A BankAccount)
public class SavingsAccount extends BankAccount {
    private double interestRate; // Interest rate in percentage

    // Constructor to initialize savings account details
    public SavingsAccount(String accountNumber, String accountHolderName, double balance, double interestRate) {
        super(accountNumber, accountHolderName, balance);
        this.interestRate = interestRate;
    }

    // Method to add interest to the balance
    // This method calculates interest based on the current balance and adds it to the balance
    public void addInterest() {
        double interest = balance * interestRate / 100;
        balance += interest;
        System.out.println("Interest of " + interest + " added.");
    }

    // Overriding the withdraw method from the parent class
    // This method checks if the withdrawal amount is less than or equal to the balance
    // If so, it deducts the amount from the balance; otherwise, it prints an error message
    @Override
    public void withdraw(double amount) {
        if (amount <= balance) {
            balance -= amount;
        } else {
            System.out.println("Insufficient balance in Savings Account.");
        }
    }

    // Overriding the displayInfo method from the parent class
    @Override
    public void displayInfo() {
        System.out.println("Savings Account [" + accountNumber + "] - " + accountHolderName);
    }
}


// CurrentAccount class - inherits from BankAccount class (CurrentAccount IS-A BankAccount)
class CurrentAccount extends BankAccount {
    private double overdraftLimit; // Overdraft limit for the current account

    // Constructor to initialize current account details
    public CurrentAccount(String accountNumber, String accountHolderName, double balance, double overdraftLimit) {
        super(accountNumber, accountHolderName, balance);
        this.overdraftLimit = overdraftLimit;
    }


    // Overriding the withdraw method from the parent class
    // This method checks if the withdrawal amount is less than or equal to the balance plus overdraft limit
    // If so, it deducts the amount from the balance; otherwise, it prints an error message
    @Override
    public void withdraw(double amount) {
        if (amount <= balance + overdraftLimit) {
            balance -= amount;
            System.out.println("Withdrawn: " + amount + " from Current Account" + accountHolderName + " | New Balance: " + balance);
        } else {
            System.out.println("Withdrawal exceeds overdraft limit.");
        }
    }

    // Overriding the displayInfo method from the parent class
    @Override
    public void displayInfo() {
        System.out.println("Current Account [" + accountNumber + "] - " + accountHolderName + " | Balance: " + balance);
    }
}

// Main class
class BankSystem {

    // Main method
    public static void main(String[] args) {
        // Creating instances of SavingsAccount and CurrentAccount
        SavingsAccount savings = new SavingsAccount("1101101", "Neel", 1000.0, 4.0);
        CurrentAccount current = new CurrentAccount("1201202", "Ram", 500.0, 200.0);

        // Displaying saving account information
        System.out.println("\n===Saving Account Transactions===");
        savings.withdraw(2000); // insufficient balance
        savings.deposit(300);
        savings.withdraw(200);
        savings.addInterest();
        savings.displayInfo();

        // Displaying current account information
        System.out.println("\n===Current Account Transactions===");
        current.deposit(100);
        current.withdraw(700); // uses overdraft
        current.withdraw(1000); // exceeds overdraft limit
        current.displayInfo();
    }
}
