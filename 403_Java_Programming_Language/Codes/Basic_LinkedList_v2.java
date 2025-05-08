// Question:
// Add delete and search functionality to the singly linked list.

class Node {
    int data; // Data part of the node
    Node next; // Pointer to the next node

    // Constructor to create a new node with given data
    public Node(int data) {
        this.data = data;
        this.next = null; // Initialize next pointer to null
    }
}

class Basic_LinkedList_v2 {
    Node head = null; // Head of the linked list
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
    public void display() {
        Node temp = head;
        while (temp != null) {
            System.out.print(temp.data + " -> ");
            temp = temp.next;
        }
        System.out.println("null");
    }
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
    public boolean search(int key) {
        Node temp = head;
        while (temp != null) {
            if (temp.data == key) {
                return true; // Key found
            }
            temp = temp.next;
        }
        return false; // Key not found
    }
    public static void main(String[] args) {
        Basic_LinkedList_v2 list = new Basic_LinkedList_v2();

        // Insert some nodes
        list.insert(10);
        list.insert(20);
        list.insert(30);

        // Display the linked list
        System.out.println("Linked List:");
        list.display();

        // Delete a node
        System.out.println("Deleting 20 from the linked list.");
        list.delete(20);
        System.out.println("Linked List after deletion:");
        list.display();

        // Search for a node
        int key = 30;
        if (list.search(key)) {
            System.out.println(key + " found in the linked list.");
        } else {
            System.out.println(key + " not found in the linked list.");
        }
    }
}
