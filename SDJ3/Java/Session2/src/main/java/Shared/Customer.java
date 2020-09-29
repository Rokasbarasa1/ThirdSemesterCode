package Shared;

import java.util.Date;

public class Customer {
    private String customerID;
    private String name;
    private String lastname;
    private Date birthday;

    public Customer(String customerIDB, String nameDB, String lastnameDB, Date birthDay) {
    }

    public String getID() {
        return customerID;
    }

    public String getName() {
        return name;
    }

    public String getLastname() {
        return lastname;
    }

    public Date getBirthday() {
        return birthday;
    }
}
