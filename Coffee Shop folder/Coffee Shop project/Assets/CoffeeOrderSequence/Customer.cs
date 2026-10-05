using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    //Variables
    public static string drinkType = "coffee";
    //This is a new keywoard for us
    //Static means that it is per class, and not per instance of a class

    public string exampleVariable = "Tea";

    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrink(drinkType);
    }

    public void RequestDrink(string drinkType)
    {
        Debug.Log(drinkType);
        //To Invoke something you need it to be: name?.Invoke()
        // ? checks if the variable behind is null
        raiseOrder?.Invoke();
        Debug.Log(exampleVariable);
    }
}
