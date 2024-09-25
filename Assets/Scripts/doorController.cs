using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject door;
    public ArrayList blocosFileira;
    void Start()
    {
        blocosFileira = new ArrayList();
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
    }

    void Update()
    {
        if (blocosFileira[0].Equals(1) && blocosFileira[1].Equals(1) && blocosFileira[2].Equals(1) && blocosFileira[3].Equals(1) && blocosFileira[4].Equals(1) && blocosFileira[5].Equals(1) && blocosFileira[6].Equals(1) && blocosFileira[7].Equals(1) && blocosFileira[8].Equals(1))
        {
            door.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}
