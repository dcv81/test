using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjectScript : MonoBehaviour
{
    [SerializeField] GameObject[] maps;
    [SerializeField] GameObject[] assambleAreas;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateMap(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateMap(int numberMap)
    {
        Instantiate(maps[numberMap]);
    }

    public void IsntantiateObject(string letter , Vector3 position, Quaternion quaternion)
    {
        print(letter);
        if(letter == "S")
        {
            GameObject obj = Instantiate(assambleAreas[0], position, quaternion);
        }
        else if (letter == "E")
        {
            GameObject obj = Instantiate(assambleAreas[1], position, quaternion);
        }
        else if(letter == "P")
        {
            GameObject obj = Instantiate(assambleAreas[2], position, quaternion);
        }
        else if (letter == "C")
        {
            GameObject obj = Instantiate(assambleAreas[3], position, quaternion);
        }

        

    }
}
