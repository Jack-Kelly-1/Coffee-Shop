using UnityEngine;

public class sugarlevel : MonoBehaviour
{

    int sugarLevel = 2;

    void Start()
    {
        if (sugarLevel == 1)
        {
            Debug.Log("Coffee with 1 spoon of sugar.");
        }
        else if (sugarLevel == 2)
        {
            Debug.Log("Coffee with 2 spoons of sugar.");
        }
        else if (sugarLevel == 3)
        {
            Debug.Log("Coffee with 2 spoons of sugar.");
        }
        else
        {
            Debug.Log("Black Coffee.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
