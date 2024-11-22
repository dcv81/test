using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InstantiateObjectScript : MonoBehaviour
{
    [SerializeField] GameObject[] maps;
    [SerializeField] GameObject[] assambleAreas;
    [SerializeField] GameObject card;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }



    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateMap(int numberMap)
    {
        Instantiate(maps[numberMap]);
    }

    public void InstantiateCard(string text, Vector3 position)
    {
        GameObject obj = Instantiate(card, position, Quaternion.identity);
        GameObject.Find("InfoCard").GetComponent<TextMeshProUGUI>().text = text;
    }

    public void IsntantiateObject(string letter, Vector3 position, Quaternion quaternion)
    {
        print(letter);
        if (letter == "S")
        {
            GameObject obj = Instantiate(assambleAreas[0], position, quaternion);
        }
        else if (letter == "E")
        {
            GameObject obj = Instantiate(assambleAreas[1], position, quaternion);
        }
        else if (letter == "P")
        {
            GameObject obj = Instantiate(assambleAreas[2], position, quaternion);
        }
        else if (letter == "C")
        {
            GameObject obj = Instantiate(assambleAreas[3], position, quaternion);
        }
    }
}
