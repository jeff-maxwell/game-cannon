using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngle : MonoBehaviour
{
    //public GameObject cannonball;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cannonball, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.eulerAngles.z < 90)
            && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 1);
        }

        if ((transform.eulerAngles.z > 0)
            && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
