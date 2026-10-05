using UnityEngine;

public class Torch : MonoBehaviour
{
    bool torchOn = false;

    void Start()
    {
        //GameObject myExampleGO = new GameObject("myExampleGO", typeof(AudioSource));
    }

    void Update()
    {
        if (torchOn == false)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("Pressed");
                GameObject lightGameObject = new GameObject("The Light");
                Light lightComp = lightGameObject.AddComponent<Light>();
                lightGameObject.transform.position = new Vector3(0, 0, 0);
            }
        }
        else
        {
            if (torchOn == true)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    Destroy(The Light);
                }
        }
    }
}