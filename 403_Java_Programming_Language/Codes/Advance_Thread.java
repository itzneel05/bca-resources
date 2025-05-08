// Question:
// Simulate a printing queue where multiple threads (representing users) send print requests, and the printer thread processes them sequentially using synchronization.

class PrintQueue {
    // This method simulates the printing process
    // It is synchronized to ensure that only one thread can access it at a time
    public synchronized void print(String document) {
        System.out.println("Printing: " + document);
        try {
            Thread.sleep(2000); // Simulate time taken to print
        } catch (InterruptedException e) {
            System.out.println("Print interrupted.");
        }
        System.out.println("Finished printing: " + document);
    }
}
class UserThread extends Thread {
    // Each user thread will have a reference to the shared print queue and the document to be printed
    PrintQueue printQueue;
    String document;

    // Constructor to initialize the print queue and document to be printed
    public UserThread(PrintQueue printQueue, String document) {
        this.printQueue = printQueue;
        this.document = document;
    }

    public void run() {
        printQueue.print(document);
    }
}

class Advance_Thread {
    public static void main(String[] args) {
        // Create a shared print queue
        PrintQueue printQueue = new PrintQueue();

        // Create multiple user threads representing print requests
        // Each thread will print a different document
        UserThread user1 = new UserThread(printQueue, "Document1.pdf");
        UserThread user2 = new UserThread(printQueue, "Document2.pdf");
        UserThread user3 = new UserThread(printQueue, "Document3.pdf");

        // Start the threads
        // Each thread will request to print its document
        user1.start();
        user2.start();
        user3.start();
    }
}
