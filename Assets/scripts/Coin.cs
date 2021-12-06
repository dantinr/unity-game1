using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ½ð±Ò
public class Coin : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(1f, 9f);
        float dy = speed * Time.deltaTime;
        transform.Translate(0, -dy, 0);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
