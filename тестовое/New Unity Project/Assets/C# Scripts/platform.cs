using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public GameObject enemiePrefab;
    
    public void OnCollisionExit2D(Collision2D collision)
    {
        
        Vector3 SpawnEnemie = new Vector3();
        if (collision.collider.name=="deathzone")
        {
            float valuex = 0.049f;
            float valuey = transform.position.y + 21.822f;
            transform.position = new Vector3(valuex, valuey, 0);
            int place = Random.Range(1, 3);
            if (place == 1)
            {
                SpawnEnemie.x = 1.68f;
               
            }
            else { SpawnEnemie.x = -1.68f;  }
            SpawnEnemie.y = valuey + 1.5f;

            Instantiate(enemiePrefab, SpawnEnemie, Quaternion.identity);
            
        }
    }
}
