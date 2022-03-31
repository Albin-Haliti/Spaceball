using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb; // Detta är en referens till Rigidbodyn som finns i Unity
    public float moveSpeed = 10f; // bollens Hastighet

    private float xInput; // Variabler 
    private float zInput;


    // Awake kallas på när spelet loadar istället för när spelet startar
    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Denna hämtar referensen som finns däruppe
    }

    // Update is called once per frame
    // Koden som finns kallas på under varje frame 
    void Update()
    {
        ProcessInputs(); 
    }

    private void FixedUpdate()
    {
        Move();  // Rörelsen 
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal"); 
        zInput = Input.GetAxis("Vertical");
    }

    private void Move() //Detta gör så att bollen rör sig när man trycker på tangentbordet
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
