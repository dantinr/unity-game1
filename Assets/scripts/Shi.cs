using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shi : MonoBehaviour
{
    public GameObject s;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        InvokeRepeating("GetShit",0.1f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void GetShit() {
        float x = Random.Range(-2.5f,2.5f);
        float y = 5;
        GameObject shit = Instantiate(s);
        shit.transform.position = new Vector3(x,y,0);
    }
}
