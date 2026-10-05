using UnityEngine;

public class coffeeMachine : MonoBehaviour
{

    bool coffeeMachineOn = true;

    void Start()
    {
        if (!coffeeMachineOn)
        {
            Debug.Log("Brewing Coffee .....");
        }
        else
        {
            Debug.Log("Out of Coffee Beans!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
