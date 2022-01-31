﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medium
{
    // Issue: 2043

    //You have been tasked with writing a program for a popular bank that will automate all its incoming transactions(transfer, deposit, and withdraw). The bank has n accounts numbered from 1 to n.
    //The initial balance of each account is stored in a 0-indexed integer array balance, with the (i + 1)th account having an initial balance of balance[i].

    //Execute all the valid transactions.A transaction is valid if:

    //The given account number(s) are between 1 and n, and
    //The amount of money withdrawn or transferred from is less than or equal to the balance of the account.
    //Implement the Bank class:

    //Bank(long[] balance) Initializes the object with the 0-indexed integer array balance.
    //boolean transfer(int account1, int account2, long money) Transfers money dollars from the account numbered account1 to the account numbered account2.Return true if the transaction was successful, false otherwise.
    //boolean deposit(int account, long money) Deposit money dollars into the account numbered account.Return true if the transaction was successful, false otherwise.
    //boolean withdraw(int account, long money) Withdraw money dollars from the account numbered account.Return true if the transaction was successful, false otherwise.
    
    class SimpleBankSystem
    {
        readonly Dictionary<int, long> _usersBalance;
        public SimpleBankSystem(long[] balance)
        {
            _usersBalance = new Dictionary<int, long>();
            var userId = 1;
            foreach (var item in balance)
            {
                _usersBalance.Add(userId, item);
                userId++;
            }
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if (!_usersBalance.TryGetValue(account1, out var val1) || !_usersBalance.TryGetValue(account2, out _))
                return false;

            if (val1 < money || money < 0)
                return false;

            _usersBalance[account1] -= money;
            _usersBalance[account2] += money;
            return true;
        }

        public bool Deposit(int account, long money)
        {
            if (money < 0)
                return false;

            if (!_usersBalance.TryGetValue(account, out _))
                return false;

            _usersBalance[account] += money;
            return true;
        }

        public bool Withdraw(int account, long money)
        {
            if (!_usersBalance.TryGetValue(account, out var val))
                return false;

            if (val < money || money < 0)
                return false;

            _usersBalance[account] = val - money;
            return true;
        }
    }
}
