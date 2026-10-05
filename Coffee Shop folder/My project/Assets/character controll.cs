using UnityEngine;

public class charactercontroll : MonoBehaviour
{
        [Header("Movement Controls")]
        [SerializeField]
        private charactercontroll controller;

    void Start()
    {
        Debug.LogWarning("No PlayerController found in parent");
        Debug.LogError("No PlayerController found in parent");
    }

    void Update()
    {
        
    }
}
