// Question:
// Implement a sorted linked list where new elements are inserted in sorted order automatically.

class Node {
    int data; // Data part of the node
    Node next; // Pointer to the next node

    // Constructor to create a new node with given data
    public Node(int data) {
        this.data = data;
        this.next = null; // Initialize next pointer to null
    }
}

class Basic_LinkedList_v3 {
    Node head = null; // Head of the linked list
    public void insertSorted(int data) {
        Node newNode = new Node(data); // Create a new node with given data

        // If the list is empty or the new node should be inserted at the head
        if (head == null || head.data >= newNode.data) {
            newNode.next = head; // Link the new node to the current head
            head = newNode; // Update head to point to the new node
            return; // Exit the method
        }

        // Traverse to find the correct position for the new node
        Node current = head;
        while (current.next != null && current.next.data < newNode.data) {
            current = current.next; // Move to the next node
        }

        // Insert the new node at the found position
        newNode.next = current.next; // Link the new node to the next node
        current.next = newNode; // Link the previous node to the new node
    }    
    public void display() {
        Node temp = head; // Start from the head of the list
        while (temp != null) { // Traverse until the end of the list
            System.out.print(temp.data + " -> "); // Print the data of the current node
            temp = temp.next; // Move to the next node
        }
        System.out.println("null"); // Indicate the end of the list
    }
    public static void main(String[] args) {
        Basic_LinkedList_v3 list = new Basic_LinkedList_v3(); // Create a new linked list

        // Insert some nodes in sorted order
        list.insertSorted(30);
        list.insertSorted(10);
        list.insertSorted(20);

        // Display the linked list
        list.display(); // Output: 10 -> 20 -> 30 -> null
    }
}
