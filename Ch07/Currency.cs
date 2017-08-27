﻿using System;

namespace ProCSharp.Ch07
{
    public struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return String.Format("${0}.{1, -2:00}", Dollars, Cents);
        }

        public static implicit operator float(Currency value)
        {
            return value.Dollars + (value.Cents / 100.0f);
        }

        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint) value;
                ushort cents = Convert.ToUInt16((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        // SimpleCurrency2
        public static implicit operator Currency(uint value)
        {
            return new Currency(value, 0);
        }

        public static implicit operator uint(Currency value)
        {
            return value.Dollars;
        }
        
        // Ch08
        public static string GetCurrencyUnit()
        {
            return "Dollar";
        }
    }
}