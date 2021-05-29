using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public int cena;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        money_player.money += cena;
        GameObject.FindGameObjectWithTag("Player").GetComponent<money_player>().textMoney.text = money_player .money.ToString();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
