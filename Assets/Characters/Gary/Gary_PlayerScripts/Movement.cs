using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HoriMovement = Input.GetAxis("Horizontal");
        float VertiMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(HoriMovement, 0f, VertiMovement);

        transform.position += movement * Time.deltaTime * 25f;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * 100, ForceMode.Impulse);
            
        }
    }
}
