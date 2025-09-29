//   Transportation on Vacation
// -------------------------------------------
// Problem:
//  - Car rental costs $40 per day.
//  - If you rent for 7 or more days → subtract $50 from the total.
//  - If you rent for 3 or more days (but less than 7) → subtract $20.
//  - Otherwise → no discount.
//
// Solution:
//  - Multiply days * 40 to get base cost.
//  - Apply discount in one line using the ternary operator (? :).

public static class RentalCar
{

    public static int RentalCarCost(int days) =>
    
        days * 40 - (days >= 7 ? 50 : days >= 3 ? 20 : 0);
}

