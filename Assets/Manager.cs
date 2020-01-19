using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;


    public Vector3[] points;
    public int N_points = 100;
    public int N_spawn = 100;

    int xmin = -10; int xmax = 10;
    int ymin = -10; int ymax = 10;

    System.Random rand = new System.Random();
    public GameObject myPrefab;
    public GameObject kelp;
    public bool found_kelpie = false;

    void Awake() {
        MakeSingleton(); 
        points = new Vector3[N_points];

        for (int i = 0; i < N_points; i++)
        {
            points[i] = new Vector3(rand.Next(xmin, xmax), 0, rand.Next(ymin, ymax));
        }
    }

    void Update()
    {
        if (found_kelpie)
        {
            print("I'm supposed to quit now...");
            Application.Quit();
        }
    }


    void Start()
    {
        SpawnSwarm();
    }

    private void SpawnSwarm()
    {
        Color Color_purple = new Color(0.89f, 0.43f, 0.99f);
        Color Color_green = new Color(0.8f, 0.99f, 0.32f);
        Color Color_blue = new Color(0.37f, 0.97f, 1f);
        Color Color_magenta = new Color(1.0f, 0.39f, 0.82f);

        var colorList = new List<Color> { Color_blue, Color_green, Color_magenta, Color_purple };

        int j;
        for (int i = 0; i < N_spawn; i++) {
            //Instantiate(myPrefab, GetRandomPoint(), Quaternion.identity);

            j = rand.Next(points.Length);
            GameObject c = Instantiate(myPrefab, points[j], Quaternion.identity) as GameObject;
            Color c_color = c.GetComponentInChildren<Renderer>().material.color;

            Color my_color = colorList[j % colorList.Count];

            c.GetComponentInChildren<Renderer>().material.color = my_color;

            foreach (var child in c.GetComponentsInChildren<Renderer>())
            {
                child.material.color = my_color;
                if (child.name.Equals("right_eye_p") || child.name.Equals("left_eye_p"))
                    child.material.color = Color.black;
                if (child.name.Equals("right_eye") || child.name.Equals("left_eye"))
                    child.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
    }

    Color colorSelector()
    {
        var random = new Random();
        // var colorList = new List<Color>{Color.black, Color.blue, Color.clear, Color.cyan, Color.gray, Color.green, Color.grey, Color.magenta, Color.red, Color.white, Color.yellow};
        Color Color_purple = new Color(0.6f, 0.2f, 0.8f);
        var colorList = new List<Color> { Color.blue, Color.green, Color.magenta, Color_purple };
        int index = Random.Range(0, 4);
        return colorList[index];
    }

    private void MakeSingleton() {
        if (instance != null) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public Vector3 GetRandomPoint()
    {
        return points[rand.Next(0,N_points-1)];
    }
}
