using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ½ð±Ò¿ØÖÆ
public class Coins : MonoBehaviour
{

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        float t1 = Random.Range(1f, 4f);
        InvokeRepeating("GetCoins",0.5f,t1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetCoins() {
        float x = Random.Range(-3f, 3f);
        float y = 5;
        GameObject co = Instantiate(coin);
        co.transform.position = new Vector3(x, y, 0);
    }

}
