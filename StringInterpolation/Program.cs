﻿/*
You need to create the code to print a receipt for the customer purchasing shares of an investment product. 
The shares are purchased automatically at the end of the year based on a series of payroll deductions, 
so the number of shares purchased usually contains a decimal amount. 
To print the receipt, you would likely need to combine data of different types, including fractional values, 
currency, and percentages in precise ways.
*/

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");