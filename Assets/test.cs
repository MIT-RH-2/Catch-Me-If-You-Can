using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MagicLeapTools.Pointer pointer = gameObject.GetComponent<MagicLeapTools.Pointer>();
        if (pointer.Target != null)
        {
            if (pointer.Target.tag == "Win")
            {
                SceneManager.LoadScene(1); 
            }
            else
            {
                Debug.Log(message: "blah");
            }
        } else
        {
            Debug.Log(message: "No target detected");
        }

    }
}
