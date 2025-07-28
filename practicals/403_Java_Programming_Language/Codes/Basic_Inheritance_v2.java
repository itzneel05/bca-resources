// Question:
// Create two class one is College and another is Course, College class has data member like name, address and contact no, Course class inherit the properties of College class and it has data member like course name, duration, and intake and do the following operation.
// Create constructor for base and derived class.
// Insert data through derived class parameterized constructor.
// Illustrate the use of this reference and Super.
// Display all the information through parent class reference variable.

// College class - the parent/base class that contains common attributes and behaviors
class College {
    String name;
    String address;
    String contactNo;

    // Constructor for College class
    College(String name, String address, String contactNo) {
        this.name = name;
        this.address = address;
        this.contactNo = contactNo;
    }

    // Method to display college information
    void displayInfo() {
        System.out.println("College Name: " + name);
        System.out.println("Address: " + address);
        System.out.println("Contact No: " + contactNo);
    }
}

class Course extends College {
    String courseName;
    int duration; // in years
    int intake; // number of students

    // Constructor for Course class
    Course(String collegeName, String collegeAddress, String collegeContactNo,
           String courseName, int duration, int intake) {
        // Call the constructor of the parent class (College)
        super(collegeName, collegeAddress, collegeContactNo);
        this.courseName = courseName;
        this.duration = duration;
        this.intake = intake;
    }
    
        // Method to display course information
        @Override
        void displayInfo() {
            // Call the displayInfo method of the parent class (College)
            super.displayInfo();
            System.out.println("Course Name: " + courseName);
            System.out.println("Duration: " + duration + " years");
            System.out.println("Intake: " + intake + " students");
        }
    }

// Main Class
class Basic_Inheritance_v2 {
    public static void main(String[] args) {
        // Creating an object of Course class
        Course course1 = new Course("ABC College", "123 Main St", "1234567890", "Computer Science", 4, 60);
        
        // Displaying information using parent class reference variable
        course1.displayInfo();
    }
}
