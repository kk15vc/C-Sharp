using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccountDemo
{
    class MyAccount
    {

        public int Id;

        private string p_Name;
        
        private decimal p_Balance;

        //Constructors
        //Default 
        public MyAccount()
        {
            // I will set the initial values to the instance fields 
            p_Name = "From default Constructor";
            Id = 1000;
        }
        //Parametrized 
        public MyAccount(int c_id, string c_name, decimal c_balance)
        {
            this.Id = c_id;
            this.p_Name = c_name;
            this.p_Balance = c_balance;
        }
        //copy
        //public Class_Name(Class_Name instance_of_class)
        // it's a copy of the above class we don't have set the fields value
        //public MyAccount(MyAccount k)
        public MyAccount(MyAccount k):this (k.Id,k.p_Name,k.p_Balance)
        {
            //this.Id = k.Id;
            //this.Name = k.Name;
            //this.Balance = k.Balance;
        }

        // I have changed access modifier for p_Name to private
        // Now, this will stop any changes to this field from outside the class
        // in order to allow changes I will use the property 
        public string Namek
        {
            get
            {
                return p_Name;
            }
            set
            {
                p_Name = value;
            }
        }

        // I have changed access modifier for p_Balance to private
        // Now, this will stop any changes to this field from outside the class
        // in order to allow changes I will use the property 
        public Decimal BalanceGetSet
        {
            get
            {
                return p_Balance;
            }
            set
            {
                p_Balance = value;
            }
        }
        /* I have made balalnce field disabled and now the balance will updated
         * using deposit/withdraw buttons
         */
        public void Deposit(decimal dep_amt)
        {
            p_Balance += dep_amt; 
        }

        //Withdrawal amount
        public void Withdraw(decimal draw_amt)
        {
            p_Balance -= draw_amt;
        }
    }
}
