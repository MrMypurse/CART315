using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public GameObject prefab;

    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Ray clickray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit result;
        if (Physics.Raycast(clickray, out result))
        {
            GameObject.Instantiate(prefab, result.point, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GotMouseButtonDown(0))
        {

        }
    }
}
