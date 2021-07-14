﻿using Solução_sem_interface.Services;


namespace Interfaces.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else return amount * 0.15;
        }
    }
}