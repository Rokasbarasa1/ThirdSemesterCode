package Tier3.persistance.AdminDAO;


import Shared.Account;
import Shared.Clerk;
import Shared.Customer;

public interface AdminDAO {
    void createdCustomer(Customer customer, Account account);
    void createdClerk(Clerk clerk, Account account);
}
