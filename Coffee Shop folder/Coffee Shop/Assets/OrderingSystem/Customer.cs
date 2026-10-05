using UnityEngine;

public class Customer : MonoBehaviour
{
    //Variables

    private int drinkType1 = 0;
    //public static string[] drinkType1 = {"Cappuccino", "Latte", "Espresso", "Tea" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        drinkType1 = random.Range(1, 6);
        DecideOrder
    }

    // Update is called once per frame
    void DecideOrder()
    {
        if (drinkType1 == 1);
        {
            drinkType1 = "Cappuccino";
        }
        else if (drinkType1 == 2);
        {
            drinkType1 = "Latte";
        }        
        else if (drinkType1 == 3);
        {
            drinkType1 = "Espresso";
        }
        else if (drinkType1 == 4);
        {
            drinkType1 = "Tea";
        }
        else if (drinkType1 == 5);
        {
            drinkType1 = "Tea";
        }
        else
        {
            Debug.Log("We don't sell that one here");
        }
    }

}
