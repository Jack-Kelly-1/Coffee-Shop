using UnityEngine;
using System.Collections.Generic;

public class Arrays : MonoBehaviour
{
    public GameObject[] gameObject;
    public List<GameObject> gameObjectList = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject obj in gameObjectList)
        {
            Debug.Log("GameObject in List: " + obj.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
