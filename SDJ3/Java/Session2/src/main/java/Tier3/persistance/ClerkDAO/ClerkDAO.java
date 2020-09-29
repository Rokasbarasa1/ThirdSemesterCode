package Tier3.persistance.ClerkDAO;


import Shared.Account;
import Shared.Clerk;
import Shared.Customer;

public interface ClerkDAO {
    Clerk getClerk(String ID);
    Customer getCustomer(String ID);
    Account Withdraw(Account account, double amount);
    Account addToAccount(Account account, double amount);
}
