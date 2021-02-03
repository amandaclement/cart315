using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public string pickuptag;
    //public string tag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(pickuptag))
        // if (collision.collider.gameObject.tag == "pickup")
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
