/* Question:
 * Design a class Cricketer having data member name and number of matches and appropriate member function to set the values. 
 * Derive two classes Batsman and Bowler from Cricketer class with data member total number of runs and wickets respectively. 
 * Batsman class is having a method to calculate average run rate and Bowler class is having method to calculate average wicket. 
 * Write a program to create two objects and displays information of one batsman and bowler along with average run and wicket.
 */

// Base class
class Cricketer {
    // Attributes common to all cricketers
    protected String name;
    protected int numberOfMatches;

    // This Method to initialize cricketer details
    public void setCricketerInfo(String name, int numberOfMatches) {
        this.name = name;
        this.numberOfMatches = numberOfMatches;
    }

    // This Method to display cricketer details
    public void displayCricketerInfo() {
        System.out.println("Name: " + name);
        System.out.println("Matches Played: " + numberOfMatches);
    }
}

// Derived class
class Batsman extends Cricketer {
    private int totalRuns; // Total runs scored by the batsman

    // This Method to initialize batsman details
    public void setBatsmanInfo(String name, int matches, int totalRuns) {
        setCricketerInfo(name, matches);
        this.totalRuns = totalRuns;
    }

    // This Method to calculate average run rate
    public double calculateAverageRunRate() {
        if (numberOfMatches == 0) {
            return 0;
        }
        return (double) totalRuns / numberOfMatches;
    }

    // This Method to display batsman details
    public void displayBatsmanInfo() {
        displayCricketerInfo();
        double averageRunRate = calculateAverageRunRate();
        System.out.println("Total Runs: " + totalRuns);
        System.out.printf("Average Run Rate: " + averageRunRate);
    }
}

// Derived class
class Bowler extends Cricketer {
    private int totalWickets; // Total wickets taken by the bowler

    // This Method to initialize bowler details
    public void setBowlerInfo(String name, int matches, int totalWickets) {
        setCricketerInfo(name, matches);
        this.totalWickets = totalWickets;
    }

    // This Method to calculate average wickets per match
    public double calculateAverageWicket() {
        if (numberOfMatches == 0) {
            return 0;
        }
        return (double) totalWickets / numberOfMatches;
    }

    // This Method to display bowler details
    public void displayBowlerInfo() {
        displayCricketerInfo();
        double averageWicket = calculateAverageWicket();
        System.out.println("Total Wickets: " + totalWickets);
        System.out.printf("Average Wickets per Match: " + averageWicket);
    }
}

// Main class
class Cricket_Match {

    // Main method
    public static void main(String[] args) {
        // Creating instances of Batsman and Bowler classes
        Batsman batsman = new Batsman();
        Bowler bowler = new Bowler();

        // Setting details for batsman and bowler
        batsman.setBatsmanInfo("Virat Kohli", 25, 1200);
        bowler.setBowlerInfo("Jasprit Bumrah", 10, 18);

        // Displaying details for batsman and bowler
        System.out.println("\n---- Batsman Info ----");
        batsman.displayBatsmanInfo();

        System.out.println("\n---- Bowler Info ----");
        bowler.displayBowlerInfo();
    }
}
