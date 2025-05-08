package studentops;

import studentdata.Student;

public class Operations {
    // Search student by roll number
    public static Student searchByRoll(Student[] students, int rollNo) {
        for (Student s : students) {
            if (s.rollNo == rollNo) {
                return s;
            }
        }
        return null;
    }

    // Sort students by roll number (ascending)
    public static void sortByRoll(Student[] students) {
        for (int i = 0; i < students.length - 1; i++) { // Outer loop for passes
            for (int j = i + 1; j < students.length; j++) { // Compare roll numbers
                if (students[i].rollNo > students[j].rollNo) { // Swap if out of order
                    // Swap the students
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
    }
}
