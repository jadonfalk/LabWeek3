using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Inspector input
    public float coverPrice;
    public int numCopies;

    void Start()
    {
        if (coverPrice < 0 || numCopies <= 0)
        {
            Debug.Log("Invalid input values!");
            return;
        }

        // Declare totalCost variable and calculate totalCost 
        float totalCost = CalculateTotalCost(coverPrice, numCopies);
        float totalRevenue = coverPrice * numCopies;
        float profit = totalRevenue - totalCost;

        // Log Cover Price, Num Copies, Total Cost, and Profit, formatted to 2 decimal places for money related variables
        Debug.Log($"Cover Price: ${coverPrice:F2}, Copies: {numCopies}");
        Debug.Log($"Total Cost: ${totalCost:F2}, Profit: ${profit:F2}"); 
    }

    float CalculateTotalCost(float price, int copies)
    {
        float discountedPrice = price * 0.6f; // 40% discount
        float shipping = 3f + (copies - 1) * 0.75f; // shipping cost
        return discountedPrice * copies + shipping;
    }
}
