using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    // create vector then initialize it
    public Vector3 rotation = new Vector3(0, 0.2f, 0); // this is a constructor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate() // FixdUpdate() instead of Update() to have more consistent behaviour across machines
    {
        if(Input.GetKey(KeyCode.R)) {
            this.GetComponent<Transform>().Rotate(rotation);
        }
    }
}