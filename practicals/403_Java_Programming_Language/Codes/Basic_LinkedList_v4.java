// Question:
// Create a Menu driven program to implement Singly Linked list and perform operation like create, traverse, insert and delete node.

class Node {
    int data; // Data part of the node
    Node next; // Pointer to the next node

    // Constructor to create a new node with given data
    public Node(int data) {
        this.data = data;
        this.next = null; // Initialize next pointer to null
    }
}

class Basic_LinkedList_v4 {
    Node head = null; // Head of the linked list
        
        // Method to insert a new node at the end of the linked list
        public void insert(int data) {
            Node newNode = new Node(data); // Create a new node with given data
    
            // If the list is empty, make the new node the head
            if (head == null) {
                head = newNode;
                return; // Exit the method
            }
    
            // Traverse to the end of the list
            Node temp = head;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = newNode; // Link the last node to the new node
        }

        // Method to display the linked list
        public void display() {
            Node temp = head;
            while (temp != null) {
                System.out.print(temp.data + " -> ");
                temp = temp.next;
            }
            System.out.println("null");
        }

        // Method to delete a node with a specific key
        public void delete(int key) {
            Node temp = head, prev = null;
    
            // If the head node itself holds the key to be deleted
            if (temp != null && temp.data == key) {
                head = temp.next; // Changed head
                return;
            }
    
            // Search for the key to be deleted, keep track of the previous node
            while (temp != null && temp.data != key) {
                prev = temp;
                temp = temp.next;
            }
    
            // If the key was not present in the linked list
            if (temp == null) return;
    
            // Unlink the node from linked list
            prev.next = temp.next;
        }

        public static void main(String[] args) {
            Basic_LinkedList_v4 list = new Basic_LinkedList_v4(); // Create a new linked list
    
            java.util.Scanner scanner = new java.util.Scanner(System.in); // Scanner for user input
    
            while (true) { // Infinite loop for menu-driven program
                System.out.println("Menu:");
                System.out.println("1. Insert Node");
                System.out.println("2. Display List");
                System.out.println("3. Delete Node");
                System.out.println("4. Exit");
                System.out.print("Choose an option: ");
                
                int choice = scanner.nextInt(); // Read user choice   
                switch (choice) {
                    case 1: // Insert Node
                        System.out.print("Enter data to insert: ");
                        int data = scanner.nextInt(); // Read data to insert
                        list.insert(data); // Insert the node
                        break;
                    case 2: // Display List
                        System.out.println("Linked List:");
                        list.display(); // Display the linked list
                        break;
                    case 3: // Delete Node
                        System.out.print("Enter data to delete: ");
                        int key = scanner.nextInt(); // Read data to delete
                        list.delete(key); // Delete the node
                        break;
                    case 4: // Exit
                        System.out.println("Exiting...");
                        scanner.close(); // Close the scanner
                        return; // Exit the program
                    default:
                        System.out.println("Invalid choice. Please try again."); // Invalid choice message
                }
            }
        }
    }
