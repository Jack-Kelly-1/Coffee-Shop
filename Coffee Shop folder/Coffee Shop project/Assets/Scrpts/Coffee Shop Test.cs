using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;

    public int amountOrdered = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello");
        Debug.Log("Coffees sold: " + coffeesSold);
        Debug.Log("I have Ordered");
        Debug.Log(amountOrdered + "coffees");
        amountOrdered++;
        Debug.Log("Oops, I actually ordered" + amountOrdered + "coffees");
    }

    // Update is called once per frame
    void AddCoffee()
    {
        coffeesSold =+ 1;
    }
}
