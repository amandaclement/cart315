using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// need to fix this file

public class pickup : MonoBehaviour
{
    //public string pickuptag;
    public string pickuptag;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("initial collide");
        //if (collision.collider.gameObject.CompareTag(pickuptag))
        if (collision.collider.gameObject.CompareTag(pickuptag))
        {
            Debug.Log("collision detected wih pickup");
            Destroy(collision.collider.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
