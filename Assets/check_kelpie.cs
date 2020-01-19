using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_kelpie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print("Clicked on a kelpie");
                GameObject c = GameObject.Find( hit.collider.gameObject.name );
                print(hit.collider.gameObject.name);
                print(c.GetComponentInChildren<Renderer>().material.color);
            }
        }
    }
}
