using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKeyAudio : MonoBehaviour
{
    public AudioSource TakePill;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("pressed");
            if (!TakePill.isPlaying)
            {
                TakePill.Play();
            }

        }
 
    }

}
