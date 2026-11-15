
# Product Profit Analyzer

A simple C# console application that calculates the profit or loss of a product.

I created this project to practice C# basics and improve my problem-solving skills.

## Features

- Enter product information
- Calculate total product costs
- Calculate platform fees
- Calculate net profit or loss
- Calculate profit margin
- Check if a product is profitable, unprofitable, or break-even
- Handle invalid inputs
- Display a financial report

## Technologies Used

- C#
- .NET
- Console Application

## How It Works

The program asks the user to enter:

1. Product name
2. Purchase price
3. Packaging cost
4. Shipping cost
5. Selling price
6. Platform fee percentage

After entering the information, the program calculates the costs and shows the final profit or loss.

All prices are in Toman.

## Calculations

**Platform Fee**

Platform Fee = Selling Price × Fee Percentage / 100

**Total Cost**

Total Cost = Purchase Price + Packaging Cost + Shipping Cost + Platform Fee

**Net Profit**

Net Profit = Selling Price - Total Cost

**Profit Margin**

Profit Margin = (Net Profit / Selling Price) × 100

## Example Output

```text
----- Product Report -----

Product: Wireless Mouse
Purchase price: 250000
Packaging cost: 15000
Shipping cost: 30000
Selling price: 400000
Platform fee: 40000

Total cost: 335000
Net profit: 65000
Profit margin: 16.25%
Status: Profitable

--------------------------
```

## How to Run

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Build and run the application.
4. Enter the requested product information.
5. View the financial report.

## Project Limitations

- Only one product can be analyzed at a time.
- Product information is not saved.
- No database is used.
- The application runs in the console.

## What I Learned

During this project, I practiced:

- Variables and data types
- If/else statements
- Loops
- User input
- Exception handling
- Basic calculations
- Console output formatting


