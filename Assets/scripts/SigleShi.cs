using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigleShi : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(1f,3f);
        float dy = speed * Time.deltaTime;
        transform.Translate(0,-dy,0);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0) {
            Destroy(this.gameObject);
        }
    }

}
