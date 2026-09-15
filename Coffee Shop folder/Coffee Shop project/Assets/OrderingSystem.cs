using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    private float _costOfCoffee = 4;

    public int coffeeAmountOrdered;

    public float totalOrderAmount;

    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
        Debug.Log("Your order amount today is" + " £ " + totalOrderAmount);
    }
}
