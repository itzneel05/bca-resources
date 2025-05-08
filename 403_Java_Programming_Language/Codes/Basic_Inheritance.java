/*Question :
* Create a Person class and extend it into Student and Teacher classes. Show inheritance of methods. */


// Person class - the parent/base class that contains common attributes and behaviors 
class Person {
    // Common attributes for all persons
    String name;
    int age;

    Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    void display() {
        System.out.println("Name: " + name + ", Age: " + age);
    }
}

// Student class - inherits from Person class (Student IS-A Person)
class Student extends Person {
    // Additional attribute specific to Student
    String studentID;

    Student(String name, int age, String studentID) {
        super(name, age); // Call the constructor of the parent class to set name and age
        this.studentID = studentID;
    }

    void display() {
        super.display(); // Call the display method of the parent class to print name and age
        System.out.println("Student ID: " + studentID);
    }
}

// Teacher class - also inherits from Person class (Teacher IS-A Person)
class Teacher extends Person {
    // Additional attribute specific to Teacher
    String subject;

    Teacher(String name, int age, String subject) {
        super(name, age); // Call the constructor of the parent class
        this.subject = subject;
    }

    void display() {
        super.display(); // Call the display method of the parent class
        System.out.println("Subject: " + subject);
    }
}

// Main class to demonstrate inheritance
class Basic_Inheritance {
    public static void main(String[] args) {
        // Creating objects of Student and Teacher classes
        Student student = new Student("Neel", 19, "1101");
        Teacher teacher = new Teacher("Priya", 35, "Java");

        // Displaying information
        System.out.println("Student Information:");
        student.display();
        System.out.println("\nTeacher Information:");
        teacher.display();
    }
}
