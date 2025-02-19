﻿using CashFlow.Communication.Enums;

namespace CashFlow.Communication.Requests
{
    public class RequestExpenseJson
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public DateTime Date { get; set; }
        public decimal Ammount { get; set; }
        public PaymentType Type { get; set; }
    }
}
