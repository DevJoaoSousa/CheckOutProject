using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    internal static class RepositoryCommands
    {
        internal static string GetAllPayments = "SELECT * FROM PaymentsProcess";
        internal static string ProcessPayment =
            "INSERT INTO[PaymentsProcess]" +
                "([CardNumber]" +
                ",[ExpiryDate]" +
                ",[Amount]" +
                ",[Currency]" +
                ",[CVV]) " +
            "VALUES " +
                "(@CardNum " +
                ",@ExpiryDat " +
                ",@AmountPay " +
                ",@Cur " +
                ",@Cvv)";
    }
}
