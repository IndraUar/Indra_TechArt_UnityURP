using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform PivotObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // commented because it shows error in Unity
        // Used for Plexus Effect

        //if (Input.GetKey(KeyCode.A))
        //    transform.RotateAround(PivotObject.position, Vector3.up, 50 * Time.deltaTime);

        //if (Input.GetKey(KeyCode.D))
        //    transform.RotateAround(PivotObject.position, Vector3.down, 50 * Time.deltaTime);

    }
}
