using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour

{
    public string tag;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "PickUp")
        {
            Debug.Log("COLLISION");
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
