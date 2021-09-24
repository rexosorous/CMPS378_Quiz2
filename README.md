# CMPS378 Quiz #2: Baldi's Kitchen
### Submitted By: J-Zach Loke

# Description
This program calculates the cost of an order put at the restaraunt Baldi's Kitchen

This program is intended to be integrated into POS (point of sale) machines in Baldi's Kitchen.

# Features
Takes into account which menu item was ordered, how many people are in the party, and whether or not they want the cheesecake dessert.

# How to Run
Compile `main.cs` using a C# compiler (preferrably Visual Studio's compiler). I specificually used `Microsoft (R) Visual C# Compiler version 2.6.0.62329`.

# Test Inputs & Outputs

### Given test case
```
---------Welcome to Baldi's Kitchen-----------
Chicken         Pizza           Spaghetti       Steak
$20             $25             $15             $35
Select your meal (C - Chicken, P - Pizza, S - Spaghetti, T- Steak): C
How many people in your party: 4
Would you like to try out Baldi's Homemade Cheesecake for $10 per party: Y

Your total is $120
Your order was Chicken for the party of 4. Cheesecake Included: Y
```

### Pizza order
```
---------Welcome to Baldi's Kitchen-----------
Chicken         Pizza           Spaghetti       Steak
$20             $25             $15             $35
Select your meal (C - Chicken, P - Pizza, S - Spaghetti, T- Steak): P
How many people in your party: 10
Would you like to try out Baldi's Homemade Cheesecake for $10 per party: N

Your total is $250
Your order was Pizza for the party of 10. Cheesecake Included: N
```

### Spaghetti Order
```
---------Welcome to Baldi's Kitchen-----------
Chicken         Pizza           Spaghetti       Steak
$20             $25             $15             $35
Select your meal (C - Chicken, P - Pizza, S - Spaghetti, T- Steak): S
How many people in your party: 10
Would you like to try out Baldi's Homemade Cheesecake for $10 per party: Y

Your total is $250
Your order was Spaghetti for the party of 10. Cheesecake Included: Y
```

### Steak Order
```
---------Welcome to Baldi's Kitchen-----------
Chicken         Pizza           Spaghetti       Steak
$20             $25             $15             $35
Select your meal (C - Chicken, P - Pizza, S - Spaghetti, T- Steak): T
How many people in your party: 100
Would you like to try out Baldi's Homemade Cheesecake for $10 per party: N

Your total is $3500
Your order was Steak for the party of 100. Cheesecake Included: N
```