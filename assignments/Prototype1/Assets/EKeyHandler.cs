using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKeyHandler : MonoBehaviour
{
    Light It;

    // Start is called before the first frame update
    void Start()
    {
        It = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("pressed");
            It.color = new Color(0.9f, 0.2f, 0.2f, 0.8f);
        }
 
    }

}
