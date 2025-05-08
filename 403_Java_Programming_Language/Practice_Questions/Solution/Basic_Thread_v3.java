// Question:
// Write a program that accept Book information like Title, Author, Publication and Price for the N book from the user and display books in descending order with interval of 1 second using thread

import java.util.Scanner;

class Book {
    String title;
    String author;
    String publication;
    double price;

    public Book(String title, String author, String publication, double price) {
        this.title = title;
        this.author = author;
        this.publication = publication;
        this.price = price;
    }
}

class BookThread extends Thread {
    Book[] books;

    public BookThread(Book[] books) {
        this.books = books;
    }

    public void run() {
        // Sort books in descending order based on price
        for (int i = 0; i < books.length - 1; i++) {
            for (int j = 0; j < books.length - i - 1; j++) { // Bubble sort
                // Compare prices in descending order
                if (books[j].price < books[j + 1].price) {
                    // Swap
                    Book temp = books[j];
                    books[j] = books[j + 1];
                    books[j + 1] = temp;
                }
            }
        }

        // Display sorted book information with a delay of 1 second
        for (Book book : books) {
            System.out.println("Title: " + book.title + ", Author: " + book.author +
                               ", Publication: " + book.publication + ", Price: " + book.price);
            try {
                Thread.sleep(1000); // 1 sec delay
            } catch (InterruptedException e) {
                System.out.println("Thread interrupted.");
            }
        }
    }
}

class Basic_Thread_v3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter the number of books: ");
        int n = scanner.nextInt();
        scanner.nextLine(); // Consume newline

        Book[] books = new Book[n];

        for (int i = 0; i < n; i++) {
            System.out.print("Enter title of book " + (i + 1) + ": ");
            String title = scanner.nextLine();
            System.out.print("Enter author of book " + (i + 1) + ": ");
            String author = scanner.nextLine();
            System.out.print("Enter publication of book " + (i + 1) + ": ");
            String publication = scanner.nextLine();
            System.out.print("Enter price of book " + (i + 1) + ": ");
            double price = scanner.nextDouble();
            scanner.nextLine(); // Consume newline

            books[i] = new Book(title, author, publication, price);
        }

        BookThread bookThread = new BookThread(books);
        bookThread.start(); // Start the thread to display books
        scanner.close(); // Close the scanner to prevent resource leak
    }
}
