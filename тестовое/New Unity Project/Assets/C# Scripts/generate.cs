using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject enemiePrefab;
    public GameObject gem;
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        Vector3 SpawnEnemie = new Vector3();
        Vector3 SpawnGem = new Vector3();
        int[] mas = new int[3];
        int prev=1;
        for (int i = 0; i < 3; i++)
        {
            mas[i]= Random.Range(1, 10);
        }
        for (int i = 0; i < 10; i++)
        {
            int place = Random.Range(1, 3);
            SpawnerPosition.x = 0.049f;
            SpawnerPosition.y += 1.822f;
            if (place == 1 && prev != 1)
            {
                SpawnEnemie.x = 1.68f;
                SpawnGem.x = -1.68f;
                prev = place;
            }
            else { SpawnEnemie.x = -1.68f; SpawnGem.x = +1.68f; prev = place; }
            SpawnEnemie.y = SpawnerPosition.y + 1.5f;
            SpawnGem.y= SpawnerPosition.y + 1.5f;

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
            foreach (var item in mas)
            {
                if (item==i)
                { 
                    Instantiate(enemiePrefab, SpawnEnemie, Quaternion.identity);
                    
                }
            }
            foreach (var item in mas)
            {
                if (item == i)
                {
                    Instantiate(gem, SpawnGem, Quaternion.identity);
                }
            }

        }
        
    }
   
    void Update()
    {
        
    }
}
