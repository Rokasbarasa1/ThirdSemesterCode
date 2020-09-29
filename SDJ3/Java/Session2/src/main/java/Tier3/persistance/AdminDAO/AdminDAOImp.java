package Tier3.persistance.AdminDAO;


import Shared.Account;
import Shared.Clerk;
import Shared.Customer;
import Tier3.DatabaseConnection;

import java.sql.ResultSet;
import java.sql.SQLException;

public class AdminDAOImp implements AdminDAO {
    private DatabaseConnection database;

    public AdminDAOImp(DatabaseConnection database) {
        this.database = database;
    }


    @Override
    public void createdCustomer(Customer customer, Account account) {
        try {
            database.getStatement().execute(
                    "Insert into \"Exercise2\".Clerk(CustomerID, name, lastname, Birthday) " +
                            "VALUES ('" + customer.getID() + "', '" + customer.getName() + "', '" + customer.getLastname() + "', '" + customer.getBirthday() + "';" );
            database.getStatement().execute(
                    "Insert into \"Exercise2\".Account(AccountID, balance) " +
                            "VALUES ('" + account.getID() + "', '" + account.getBalance() + "';" );
            database.getStatement().execute(
                    "Insert into \"Exercise2\".CustomerAccount(CustomerID, AccountID) " +
                            "VALUES ('" + customer.getID() + "', '" + account.getID() + "';" );

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void createdClerk(Clerk clerk, Account account) {
        try {
            database.getStatement().execute(
                    "Insert into \"Exercise2\".Clerk(ClerkID, name, lastname, accesslevel) " +
                            "VALUES ('" + clerk.getID() + "', '" + clerk.getName() + "', '" + clerk.getLastName() + "', '" + clerk.getAccessLevel() + "';" );
            database.getStatement().execute(
                    "Insert into \"Exercise2\".Account(AccountID, balance) " +
                            "VALUES ('" + account.getID() + "', '" + account.getBalance() + "';" );
            database.getStatement().execute(
                    "Insert into \"Exercise2\".ClerkAccount(ClerkID, AccountID) " +
                            "VALUES ('" + clerk.getID() + "', '" + account.getID() + "';" );

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
