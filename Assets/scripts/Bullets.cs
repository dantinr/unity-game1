using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = 3.5f * Time.deltaTime;
        transform.Translate(0,step,0,Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y > 3000)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("shit"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.tag.Equals("coin"))
        {
            Destroy(collision.gameObject);
        }
    }


}
