// Question:
// Implement a singly linked list with insert, display operations.


class Node {
    int data; // Data part of the node
    Node next; // Pointer to the next node

    // Constructor to create a new node with given data
    public Node(int data) {
        this.data = data;
        this.next = null; // Initialize next pointer to null
    }
}


class Basic_LinkedList {
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

    // Main method to test the linked list implementation
    public static void main(String[] args) {
        Basic_LinkedList list = new Basic_LinkedList();

        // Insert some nodes
        list.insert(10);
        list.insert(20);
        list.insert(30);

        // Display the linked list
        list.display();
    }
}
