using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollision : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.gameObject == player)
        {
            Debug.Log("collision detected");
            Vector3 force = new Vector3(0, 500, 0);
            this.GetComponent<Rigidbody>().AddForce(force); // to interact with the physics of the component (Rigidbody gives it its physics)
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
