using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(0.005f,0,0));
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-0.005f,0,0));
        }
    }
}
