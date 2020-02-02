using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,0), Vector3.up, xSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.right, ySpeed * Time.deltaTime);
    }
}
