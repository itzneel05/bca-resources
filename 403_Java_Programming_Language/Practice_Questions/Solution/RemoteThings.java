// Question:
// Create a real-world simulation using interfaces: e.g., an interface RemoteControl with implementations for TV, AC, and Fan.

// Interface declaration
interface RemoteControl {
    void turnOn();
    void turnOff();
}

// TV class implementing RemoteControl
class TV implements RemoteControl {
    @Override
    public void turnOn() {
        System.out.println("TV is now ON. Enjoy your show!");
    }

    @Override
    public void turnOff() {
        System.out.println("TV is now OFF. Goodbye!");
    }
}

// AC class implementing RemoteControl
class AC implements RemoteControl {
    @Override
    public void turnOn() {
        System.out.println("AC is now ON. Cooling the room...");
    }

    @Override
    public void turnOff() {
        System.out.println("AC is now OFF. Temperature rising...");
    }
}

// Fan class implementing RemoteControl
class Fan implements RemoteControl {
    @Override
    public void turnOn() {
        System.out.println("Fan is now ON. Blowing air...");
    }

    @Override
    public void turnOff() {
        System.out.println("Fan is now OFF. No air Blowing...");
    }
}

// Main class to test
public class RemoteThings {
    public static void main(String[] args) {
        RemoteControl tv = new TV();
        RemoteControl ac = new AC();
        RemoteControl fan = new Fan();

        System.out.println("=== Remote Control Simulation ===");
        
        tv.turnOn();
        tv.turnOff();

        ac.turnOn();
        ac.turnOff();

        fan.turnOn();
        fan.turnOff();
    }
}
