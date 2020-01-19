using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kel_init : MonoBehaviour
{
    public int numberOfObjects;
    public float radius = 5f;

    public GameObject kel;
    private List<GameObject> clones;

    private Renderer c_ObjectRenderer; 
    private float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    { 
    }

    void Update()
    {
    }

    void OnMouseDown()
    {
        Color color = gameObject.GetComponentInChildren<Renderer>().material.color;
        print(color);
        if (color == Color.black)
        {
            print("Found kelpie!"); 
            Manager.instance.found_kelpie = true;
        }
    }
    /*
    void OnMouseDown()
    {
        print("Clicked the mouse!");
        Debug.Log("Mouse CLicked");
        //create numberOfObjects clons of the base kel
        for (int i = 0; i < numberOfObjects; i++) {
           float angle = i * Mathf.PI * 2 / numberOfObjects;
           float x = Mathf.Cos(angle) * radius;
           float z = Mathf.Sin(angle) * radius;
           Vector3 pos = transform.position + new Vector3(x, 0, z);

           GameObject c = Instantiate(kel, pos, Quaternion.identity) as GameObject;
           Color c_color = c.GetComponentInChildren<Renderer>().material.color;
           c.GetComponentInChildren<Renderer>().material.color = Color.blue;

           foreach (var child in c.GetComponentsInChildren<Renderer>())
           {
              child.material.color = Color.blue;
              if(child.name.Equals("right_eye_p") || child.name.Equals("left_eye_p"))
                 child.material.color = Color.black;
              if(child.name.Equals("right_eye") || child.name.Equals("left_eye"))
                 child.material.color = new Color(1.0f,1.0f,1.0f,1.0f);
           }
        } 

        for (int i = 0; i < numberOfObjects; i++)
        {         
           float angle = i * Mathf.PI * 2 / numberOfObjects;
           float x = Mathf.Cos(angle) * (radius + 2);
           float z = Mathf.Sin(angle) * (radius + 2);
           Vector3 pos = transform.position + new Vector3(x, 0, z);

           GameObject c = Instantiate(kel, pos, Quaternion.identity) as GameObject;
           Color c_color = c.GetComponentInChildren<Renderer>().material.color;

           c.GetComponentInChildren<Renderer>().material.color = Color.magenta;
           foreach (var child in c.GetComponentsInChildren<Renderer>())
           {
              child.material.color = Color.magenta;
              if(child.name.Equals("right_eye_p") || child.name.Equals("left_eye_p"))
                 child.material.color = Color.black;
              if(child.name.Equals("right_eye") || child.name.Equals("left_eye"))
                 child.material.color = new Color(1.0f,1.0f,1.0f,1.0f);
           }
        } 

        for (int i = 0; i < numberOfObjects; i++)
        {         
           float angle = i * Mathf.PI * 2 / numberOfObjects;
           float x = Mathf.Cos(angle) * (radius + 4);
           float z = Mathf.Sin(angle) * (radius + 4);
           Vector3 pos = transform.position + new Vector3(x, 0, z);

           GameObject c = Instantiate(kel, pos, Quaternion.identity) as GameObject;
           Color c_color = c.GetComponentInChildren<Renderer>().material.color;

           Color Color_purple = new Color(0.6f, 0.2f, 0.8f);
           c.GetComponentInChildren<Renderer>().material.color = Color_purple;
           foreach (var child in c.GetComponentsInChildren<Renderer>())
           {
              child.material.color = Color_purple;
              if(child.name.Equals("right_eye_p") || child.name.Equals("left_eye_p"))
                 child.material.color = Color.black;
              if(child.name.Equals("right_eye") || child.name.Equals("left_eye"))
                 child.material.color = new Color(1.0f,1.0f,1.0f,1.0f);
           }
        } 

        for (int i = 0; i < numberOfObjects; i++)
        {         
           float angle = i * Mathf.PI * 2 / numberOfObjects;
           float x = Mathf.Cos(angle) * (radius + 6);
           float z = Mathf.Sin(angle) * (radius + 6);
           Vector3 pos = transform.position + new Vector3(x, 0, z);

           GameObject c = Instantiate(kel, pos, Quaternion.identity) as GameObject;
           Color c_color = c.GetComponentInChildren<Renderer>().material.color;


           c.GetComponentInChildren<Renderer>().material.color = Color.green;
           foreach (var child in c.GetComponentsInChildren<Renderer>())
           {
              child.material.color = Color.green;
              if(child.name.Equals("right_eye_p") || child.name.Equals("left_eye_p"))
                 child.material.color = Color.black;
              if(child.name.Equals("right_eye") || child.name.Equals("left_eye"))
                 child.material.color = new Color(1.0f,1.0f,1.0f,1.0f);
           }
        } 
    }
    */
}

