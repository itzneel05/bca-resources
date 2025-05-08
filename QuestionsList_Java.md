# Questions For Repo

## Java Programming Lanugage

### Inheritance
- Write a program that demonstrates single inheritance with one parent and one child class.
- Create a **Person** class and extend it into **Student** and **Teacher** classes. Show inheritance of methods.
- Override a method in the child class and call both base and overridden versions
- Create a multilevel class structure: Animal → Mammal → Dog and show behavior overriding.
- Design a system where multiple subclasses (like SavingsAccount, CurrentAccount) inherit from a base class BankAccount and implement custom methods for each.
- Design a class Cricketer having data member name and number of matches and appropriate member function to set the values. Derive two classes Batsman and Bowler from Cricketer class with data member total number of runs and wickets respectively. Batsman class is having a method to calculate average run rate and Bowler class is having method to calculate average wicket. Write a program to create two objects and displays information of one batsman and bowler along with average run and wicket.
- Create two class one is College and another is Course, College class has data member like name, address and contact no, Course class inherit the properties of College class and it has data member like course name, duration, and intake and do the following operation.
. Create constructor for base and derived class.
. Insert data through derived class parameterized constructor.
. Illustrate the use of this reference and Super.
. Display all the information through parent class reference variable.
- 

### Interfaces
- Create an interface **Printable** with a method print(). Implement it in two classes with different outputs.
- Write a program that shows multiple interface implementation in a single class.
- Implement an interface that accepts input from the user and processes it in the implementing class.
- Create a real-world simulation using interfaces: e.g., an interface RemoteControl with implementations for TV, AC, and Fan.
- Write a program to create interface area. Create three classes called rectangle, triangle, and square calculate areas respectively

### Command Line Arguments
- Write a program to accept a name and age from command line and display it.
- Accept multiple numbers from command line and print the largest number.
- Create a calculator application that accepts operands and operator (+, -, *, /) from the command line and displays the result.
- Write a Java Program to calculate simple interest using Command -- line Arguments.
- Write a java program that accepts string from command line and display each character in capital at the delay of one second.

### Exception Handling & Custom Exception
- Create a program that handles ArithmeticException for divide-by-zero.
- Write a program that throws a custom InvalidAgeException if age is less than 18.
- Create a banking app that throws custom exceptions: LowBalanceException, InvalidAccountException during withdrawal and deposit operations.
- Write a program that will accept a number from command line and raise a user defined exception if the number consists of odd number of digits.
- Write a Java program that takes two numbers as input and performs division. Handle exceptions for division by zero and invalid input
- Write a Java program that prompts the user to input the base and height of a triangle. Accordingly calculates and displays the area of a triangle using the formula (base*height) / 2, and handles any input errors such as non-numeric inputs or negative values for base or height. Additionally, include error messages for invalid input and provide the user with the option to input another set of values or exit the program.
- Write a Java code that handles the custom exception like when a user gives input as Floating point number then it raises exception with appropriate message.


### String Methods
- Take a string from the user and print it in uppercase and lowercase.
- Write a program that counts the number of vowels, consonants, digits, and special characters in a given string.
- Develop a program to remove duplicate characters from a string and return the cleaned version.
- Write a program that accepts string data. Extract either All Vowels or All Non-Vowels from given Data According to Options Selection. Also Provide an Option to Display Output in Uppercase or Lowercase.
- Write a program a menu driven program which will do following operations. Declare a String object named str containing String "We are Full Stack Java Developer”. | Display length of the String. | Display the first character of each word of the String. | Count total number of white spaces in the given string. | Display the first word in the String.
- Write a Java program to input a string from the user and perform the following operations: Convert it to uppercase. | Find the length of the string | Reverse the string | Count the number of vowels in the string
- Write a java application which accepts two strings. Merge both the strings using alternate characters of each one. For example: If String1 is: "Very", and String2 is: "Good". Then result should be: "VGeoroyd"
- Write a Java program to display string with capital letters which are inputted through command line. Display those string(s) which starts with "B".

### StringBuffer
- Use StringBuffer to reverse a string entered by the user.
- Accept a sentence and use StringBuffer to delete all spaces and print the result.
- Create a menu-based program to perform multiple string operations (append, insert, reverse, delete) using StringBuffer.
- Write a Java Program which will read a string and rewrite it in the alphabetical Order eg. The word "STRING" should be written a "GINRST".

### Threads
- Create two threads using Runnable and display messages from each with a delay.
- Create a program where one thread prints even numbers and another prints odd numbers up to 100.
- Simulate a printing queue where multiple threads (representing users) send print requests, and the printer thread processes them sequentially using synchronization.
- Write a program that accept Book information like Title, Author, Publication and Price for the N book from the user and display books in descending order with interval of 1 second using thread
- Write an application that creates and start three threads, each thread is instantiated from the same class. It executes a loop with 5 iterations.First thread display "BEST", second thread display "OF" and last thread display "LUCK". All threads sleep for 1000 ms. The application waits for all threads to complete and display a message.

### Packages
- Create a package mathutils with a class Calculator. Use it in another class to perform arithmetic operations.
- Make multiple packages: one for student details, another for operations (search, sort) and integrate them.
- Create a modular mini project using packages like user, data, and ui to manage a small student registration system.
- Create package stores. Under it create a class called stock with member variable (item_no, item_name, stock_availible, and cost). Under the default package create a class called sales with field name (qty_sold) and it is the child class of stores class. Write a program to print the current stock of each item and perform addition.

### LinkedList
- Implement a singly linked list with insert, display operations.
- Add delete and search functionality to the singly linked list.
- Implement a sorted linked list where new elements are inserted in sorted order automatically.
- Create a Menu driven program to implement Singly Linked list and perform operation like create, traverse, insert and delete node.
- Write a java program that creates Singly Link List to perform create, insert, delete and display node using menu driven program.

### Others
- Write a java program to implement matrix addition operation
- Write a program which will display information of a particular product. Product class have following properties:
Data Members: [ Pr no | Pr_name | Quanity | Price per unit ]
Methods: constructor () - for insertion of a product information. | search ()- which will search information of product, search will be done by product name given by user. | display ()- which will display information of a product.
- Create a Student Class with Attributes : name, rollNo and marks. Implement a method display() to show student details. Create two student objects and display their details.
- Create class EMPLOYEE in java with id, name and salary as data-members. Again create 5 different employee objects by taking input from user. Display all the information of an employee which is having maximum salary.
