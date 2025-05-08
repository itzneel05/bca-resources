/* Question:
Create a multilevel class structure: Animal → Mammal → Dog and show behavior overriding. */

// Base class
class Animal { 
    public void makeSound() {
        System.out.println("Animal makes a sound");
    }
}

// Derived class
class Mammal extends Animal {
    @Override
    // This method overrides the makeSound method in the Animal class
    public void makeSound() {
        System.out.println("Mammal makes a sound");
    }
}

// Further derived class
class Dog extends Mammal {
    @Override
    // This method overrides the makeSound method in the Mammal class
    public void makeSound() {
        System.out.println("Dog barks");
    }
}

// Main class 
class Multilevel_Inheritance {

    // Main method
    public static void main(String[] args) {
        Animal animal = new Animal();
        animal.makeSound(); // Output: Animal makes a sound

        Mammal mammal = new Mammal();
        mammal.makeSound(); // Output: Mammal makes a sound

        Dog dog = new Dog();
        dog.makeSound(); // Output: Dog barks
    }
}
