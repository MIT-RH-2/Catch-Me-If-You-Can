using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterGenerator : MonoBehaviour
{     

    public Sprite sprite;
    public GameObject characterPrefab;
    private List<GameObject> characters;
    public GameObject Monster_Bat_Prefab;

    public Texture myTexture;
    Renderer c_ObjectRenderer; 
    Renderer b_ObjectRenderer; 

    void Start()
    {
        //Debug.Log("Lets the Fun Begin!");
        characters = new List<GameObject>();
    }

    void Update()
    { 
    	//AddSprite(); 
    }

   PrimitiveType shapeSelector() { 
         var random = new Random();
         var shapeList = new List<PrimitiveType>{PrimitiveType.Cube, PrimitiveType.Sphere, PrimitiveType.Capsule, PrimitiveType.Cylinder};
         int index = Random.Range(0, 4);
         return shapeList[index];
      }


   Color colorSelector() { 
         var random = new Random();
         var colorList = new List<Color>{Color.black, Color.blue, Color.clear, Color.cyan, Color.gray, Color.green, Color.grey, Color.magenta, Color.red, Color.white, Color.yellow};
         int index = Random.Range(0, 11);
         return colorList[index];
      }

	 public void AddSprite() {
	 		float x = Random.Range(-10.0f, 10.0f);
	 		float y = Random.Range(-10.0f, 10.0f);

        	GameObject character = GameObject.CreatePrimitive(shapeSelector()); 
        	character.transform.position = new Vector3(x, y, 0);
        	character.transform.localScale = new Vector3(1, 1, 1);

          c_ObjectRenderer = character.GetComponent<Renderer>();
          c_ObjectRenderer.material.color = colorSelector();
        	// SpriteRenderer renderer = character.AddComponent<SpriteRenderer>();
        	// renderer.sprite = sprite;

        	Debug.Log( "Character Generated!");
          characters.Add(character);
     }

   //   public void createBat()
   //   {
   //   	float x = Random.Range(-10.0f, 10.0f);
	 	// float y = Random.Range(-10.0f, 10.0f);

   //   	//we will need it later to clone the base object
   //      GameObject bat = Instantiate(Monster_Bat_Prefab, Vector3.zero, Quaternion.identity) as GameObject;
   //      bat.transform.position = new Vector3(x, y, 0);
   //      bat.transform.localScale = new Vector3(1, 1, 1);
   //      b_ObjectRenderer = bat.GetComponent<Renderer>();
   //      b_ObjectRenderer.material.color = colorSelector();

   //      Debug.Log( "Bat Generated!");
   //   }

    void OnMouseDown() 
    {
    	// createBar();
    	AddSprite();
    }


}
