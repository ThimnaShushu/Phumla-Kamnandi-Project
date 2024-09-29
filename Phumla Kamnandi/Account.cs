using System;
using Phumla_Kamnandi;

namespace PhumlaKamnandiHotel
{
    public class Account
    {
        // Properties of the Account
        public int AccountId { get; set; }
        public Guest AccountHolder { get; set; }
        public Room AssignedRoom { get; set; }
        public double Balance { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public double DepositAmount { get; set; }

        // Constructor
        public Account(int accountId, Guest accountHolder, Room assignedRoom, double depositAmount)
        {
            AccountId = accountId;
            AccountHolder = accountHolder;
            AssignedRoom = assignedRoom;
            Balance = 0.0; // Initialize balance to zero
            LastPaymentDate = DateTime.MinValue; // No payment made yet
            DepositAmount = depositAmount;
        }

        // Method to add a payment to the account
        public void AddPayment(double amount, DateTime paymentDate)
        {
            Balance += amount;
            LastPaymentDate = paymentDate;
        }

        // Method to deduct an amount from the account
        public bool DeductAmount(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false; 
            }
        }

        // Method to calculate the total amount due based on room rate and number of nights
        public double CalculateTotalAmountDue(int numberOfNights)
        {
            double rate = AssignedRoom.CalculateRate(1); 
            return rate * numberOfNights;
        }

        // Method to check if the deposit amount is sufficient
        public bool IsDepositSufficient()
        {
            return DepositAmount >= CalculateTotalAmountDue(1); // Checks against 1 night for deposit sufficiency
        }

        // Method to generate a summary of the account
        public string GenerateAccountSummary()
        {
            return $"Account ID: {AccountId}\n" +
                   $"Account Holder: {AccountHolder.FullName}\n" +
                   $"Room Number: {AssignedRoom.RoomNumber}\n" +
                   $"Balance: {Balance:C}\n" +
                   $"Last Payment Date: {LastPaymentDate.ToShortDateString()}\n" +
                   $"Deposit Amount: {DepositAmount:C}\n";
        }
    }
}

