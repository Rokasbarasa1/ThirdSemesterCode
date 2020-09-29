package Tier3.persistance.CustomerDAO;


import Shared.Account;

public interface CustomerDAO {
    Account getAccount(String ID);
    Account withdraw(Account account, double amount);
}
