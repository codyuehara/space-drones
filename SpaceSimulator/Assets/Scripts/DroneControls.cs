using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControls : MonoBehaviour
{
    public float speed = 50f;
    public float rotationDegree = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, speed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W)) {
            this.GetComponent<Rigidbody>().transform.Rotate(new Vector3(rotationDegree, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space)) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed) * Time.deltaTime);
        }
    }


}
