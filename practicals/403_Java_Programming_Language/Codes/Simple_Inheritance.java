
/* Question:
Write a program that demonstrates single inheritance with one parent and one child class. */

class classA { // Parent class
    // Method in parent class
    void display() {
        System.out.println("This is class A");
    }
}
class classB extends classA { // Child class
    // Method in child class
    void show() {
        System.out.println("This is class B");
    }
}

class Single_Inheritance {
    public static void main(String[] args) {
        // Creating objects of parent and child classes
        classA objA = new classA();
        classB objB = new classB();

        objA.display(); // Calling method from class A
        objB.display(); // Calling inherited method from class A
        objB.show();    // Calling method from class B
}
}