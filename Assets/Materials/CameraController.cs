using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject target; // The target/variabel
    public float xOffset, yOffset, zOffset; //offset variabler som gör att vi kan ändra positionen på kameran

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position); // Detta gör att kameran fokuserar på bollens position
    }
}
