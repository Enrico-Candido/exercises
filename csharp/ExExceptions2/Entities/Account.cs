﻿using ExExceptions2.Entities.Exceptions;

namespace ExExceptions2.Entities {
    class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
        public void WithDraw(double amount) {
            if  (amount > WithdrawLimit) {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance) {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }
        override public string ToString() {
            return "New balance: " + Balance.ToString("F2");
        }
    }
}
