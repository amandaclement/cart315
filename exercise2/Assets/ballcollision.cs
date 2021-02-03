using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollision : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected");
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
