// Question:
// Create a program where one thread prints even numbers and another prints odd numbers up to 100.

class EvenPrinter extends Thread {
    public void run() {
        for (int i = 0; i <= 100; i += 2) {
            System.out.println("Even: " + i);
            try {
                Thread.sleep(500); // 0.5 sec delay
            } catch (InterruptedException e) {
                System.out.println("Even thread interrupted.");
            }
        }
    }
}
class OddPrinter extends Thread {
    public void run() {
        for (int i = 1; i < 100; i += 2) {
            System.out.println("Odd: " + i);
            try {
                Thread.sleep(500); // 0.5 sec delay
            } catch (InterruptedException e) {
                System.out.println("Odd thread interrupted.");
            }
        }
    }
}

class Basic_Thread_v2 {
    public static void main(String[] args) {
        EvenPrinter evenThread = new EvenPrinter();
        OddPrinter oddThread = new OddPrinter();

        evenThread.start(); // Start the even number thread
        oddThread.start(); // Start the odd number thread
    }
}
