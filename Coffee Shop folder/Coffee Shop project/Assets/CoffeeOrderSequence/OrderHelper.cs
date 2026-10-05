using UnityEngine;

public class OrderHelper : MonoBehaviour
{

    //This is our interface
    //It acts as a socket between two different bits of code
 
    public interface IOrderHelper
    {
        void RequestDrinkType(string drinkType);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
