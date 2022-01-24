using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float horizontalSpeed = 100f;
    public float verticalSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(verticalSpeed * Input.GetAxis("Mouse Y"), horizontalSpeed * Input.GetAxis("Mouse X"), 0);
    }
}
