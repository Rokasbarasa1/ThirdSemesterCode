package Shared;

import java.util.Date;

public class Clerk {

    private String ID;
    private String name;
    private String lastname;
    private int accessLevel;

    public Clerk(String clerkID, String name, String lastname, int accesslevel) {
    }

    public String getID() {
        return ID;
    }

    public String getName() {
        return name;
    }

    public int getAccessLevel() {
        return accessLevel;
    }

    public String getLastName() {
        return lastname;
    }
}
