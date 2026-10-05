using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    private int _n = 24;
    public int CalculateForN = 3;

    void Start()
    {
        _n = 4;
        CalculateForN = _n * 3;
        Debug.Log(CalculateForN);
    }

    void Update()
    {
        
    }
}