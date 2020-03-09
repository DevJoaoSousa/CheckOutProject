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
                "([MaskedNumber]" +
                ",[ExpiryDate]" +
                ",[Amount]" +
                ",[Currency]" +
                ",[CVV] " +
                ",[Guid]" +
                ",[Status]) " +
            "VALUES " +
                "(@MaskedNumb " +
                ",@ExpiryDat " +
                ",@AmountPay " +
                ",@Cur " +
                ",@Cvv" +
                ",@GeneratedId" +
                ",@Stat)";
    }
}
