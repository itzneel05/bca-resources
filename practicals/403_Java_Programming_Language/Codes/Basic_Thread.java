// Question:
// Create two threads using Runnable and display messages from each with a delay.


// First thread using Runnable
class Msg1 implements Runnable {
    public void run() {
        for (int i = 1; i <= 5; i++) {
            System.out.println("Thread 1: Message " + i);
            try {
                Thread.sleep(1000); // 1 sec delay
            } catch (InterruptedException e) {
                System.out.println("Thread 1 interrupted.");
            }
        }
    }
}

// Second thread using Runnable
class Msg2 implements Runnable {
    public void run() {
        for (int i = 1; i <= 5; i++) {
            System.out.println("Thread 2: Message " + i);
            try {
                Thread.sleep(2000); // 2 sec delay
            } catch (InterruptedException e) {
                System.out.println("Thread 2 interrupted.");
            }
        }
    }
}

// Main class
public class Basic_Thread {
    public static void main(String[] args) {
        Msg1 printer1 = new Msg1();
        Msg2 printer2 = new Msg2();

        Thread thread1 = new Thread(printer1);
        Thread thread2 = new Thread(printer2);

        thread1.start(); // Start the first thread
        thread2.start(); // Start the second thread
    }
}
