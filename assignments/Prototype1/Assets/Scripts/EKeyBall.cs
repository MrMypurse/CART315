using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKeyBall : MonoBehaviour
{
    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("ballactive");
            mr.material.EnableKeyword("_EMISSION");
        }
 
    }

}
