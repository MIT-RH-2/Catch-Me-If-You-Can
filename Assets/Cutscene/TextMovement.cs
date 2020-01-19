using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Text CutsceneText;
    //public bool buttonWasPressed = false;
    private IEnumerator coroutine;
    public int i = 0;
    public SpriteRenderer image;
    public List<Sprite> sprites;
    Sprite sprite;


    void Start()
    {
     string[] intro = { "This is Earth... The planet where Humans exist ...Or so you are told!",
            "Do you think Earth belongs to humans?",
            "It might look the same BUT we Kelpies also exist here!",
            "I am Kelp of the Kelpies and I'm going to kidnap you to my Universe!",
            "The only way to get back is by... using THIS!",
            "But YOU can't have it!!! Not until... You CATCH ME FIRST!" };
        
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = WaitAndPrint(intro);
            StartCoroutine(coroutine);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitAndPrint(string [] texts)
    {
        for (int j = 0; j < texts.Length; j++)
        {
            string newText = texts[j];
            Debug.Log(newText);
            image.sprite = sprites[j];
            for (int i = 0; i < newText.Length; i++)
            { 
                CutsceneText.text = newText.Substring(0, i);
                yield return new WaitForSeconds(0.05f);


            }
            
            yield return new WaitForSeconds(2f);
        }
    }

   
}
