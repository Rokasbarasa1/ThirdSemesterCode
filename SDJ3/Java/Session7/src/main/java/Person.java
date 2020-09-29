

import java.io.Serializable;

public class Person implements Serializable {
    private String name;
    private String Position;
    private int age;
    private boolean  happy;

    public Person(String name, String position, int age, boolean happy) {
        this.name = name;
        Position = position;
        this.age = age;
        this.happy = happy;
    }

    public String getName() {
        return name;
    }

    public String getPosition() {
        return Position;
    }

    public int getAge() {
        return age;
    }

    public boolean isHappy() {
        return happy;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setPosition(String position) {
        Position = position;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setHappy(boolean happy) {
        this.happy = happy;
    }
}
