using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIleSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentTile;
    public GameObject[] tilesPrefab;
     
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            int k = Random.Range(0, 2);
            currentTile = Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
        }
        
    }

    
    

}
