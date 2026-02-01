using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Inspector input
    public int amountToPay;

    void Start()
    {
        // Validate input
        if (amountToPay < 0)
        {
            Debug.Log("Amount cannot be negative!");
            return;
        }

        CalculateBills(amountToPay);
    }

    void CalculateBills(int amount)
    {
        int remaining = amount; // Start with full amount of $

        // Calculate # of hundred dollar bills
        int hundreds = remaining / 100; 

        // Use modulus (%) to get the leftover amount after taking the $100 bills
        remaining %= 100;

        // Repeat the same process for smaller bills
        int fifties = remaining / 50;
        remaining %= 50;

        int twenties = remaining / 20;
        remaining %= 20;

        int tens = remaining / 10;
        remaining %= 10;

        int fives = remaining / 5;
        remaining %= 5;

        int ones = remaining;

        // Display amount and number of bills
        Debug.Log($"Amount: ${amount}");
        Debug.Log($"Hundreds: {hundreds}, Fifties: {fifties}, Twenties: {twenties}, Tens: {tens}, Fives: {fives}, Ones: {ones}");
    }
}
