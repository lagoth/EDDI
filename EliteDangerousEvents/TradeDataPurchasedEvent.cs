﻿using EliteDangerousDataDefinitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousEvents
{
    public class TradeDataPurchasedEvent : Event
    {
        public const string NAME = "Trade data purchased";
        public const string DESCRIPTION = "Triggered when you purchase trade data";
        public const string SAMPLE = "{ \"timestamp\":\"2016-09-28T13:54:29Z\", \"event\":\"BuyTradeData\", \"System\":\"LFT 926\", \"Cost\":100 }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static TradeDataPurchasedEvent()
        {
            VARIABLES.Add("system", "The system for which trade data was purchased");
            VARIABLES.Add("cost", "The cost of the purchase");
        }

        public string system { get; private set; }

        public decimal cost { get; private set; }

        public TradeDataPurchasedEvent(DateTime timestamp, string system, decimal cost) : base(timestamp, NAME)
        {
            this.system = system;
            this.cost = cost;
        }
    }
}
