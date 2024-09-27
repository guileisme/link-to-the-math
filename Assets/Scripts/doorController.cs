using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject portaAberta;
    int contadorPuzzle = 0;
    public GameObject enemySpawner;
    public GameObject door;
    public List<int> blocosFileira;
    public List<int> blocosCorretos;
    void Start()
    {
        portaAberta.SetActive(false);
        blocosFileira = new List<int>();
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);
        blocosFileira.Add(0);

        blocosCorretos = new List<int>();
        blocosCorretos.Add(1);
        blocosCorretos.Add(1);
        blocosCorretos.Add(1);
        blocosCorretos.Add(1);
        blocosCorretos.Add(1);
        blocosCorretos.Add(1);
        
    }

    void Update()
    {
        // if (blocosFileira[0].Equals(1) && blocosFileira[1].Equals(1) && blocosFileira[2].Equals(1) && blocosFileira[3].Equals(1) && blocosFileira[4].Equals(1) && blocosFileira[5].Equals(1) && blocosFileira[6].Equals(1) && blocosFileira[7].Equals(1) && blocosFileira[8].Equals(1))
        // {
        // }
        if (blocosFileira.SequenceEqual(blocosCorretos))
        {
            contadorPuzzle = 1;
            if (contadorPuzzle == 1)
            {
                portaAberta.SetActive(true);    
            }
        }
    }

    public void SpawnEnemy()
    {
        enemySpawner.SetActive(true);
    }
}
