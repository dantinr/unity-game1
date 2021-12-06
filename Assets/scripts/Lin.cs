using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lin : MonoBehaviour
{

    public float speed = 8f;
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp0;
    public Sprite sp3;

    public int shit_num = 0;     //shit����
    public int coin_num = 0;    // coin����

    public Text t1;
    public Text t2;

    public GameObject bullet;           //�ӵ�Ԥ����
    private float count = 0;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        float step = this.speed * Time.deltaTime;
        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);        //��ȡ��ǰ��Ļ����
        SpriteRenderer spr = GetComponent<SpriteRenderer>();


        if (Input.GetMouseButton(0)) {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
            //�����ӵ�
            count += Time.deltaTime;
            if (count >= 0.3)
            {
                Fire();
                count = 0;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer spr = this.GetComponent<SpriteRenderer>();

        if (collision.tag.Equals("shit")) {
            spr.sprite = sp1;
            Destroy(collision.gameObject);
            this.AddShitNum();
        }

        if (collision.tag.Equals("coin")) {
            spr.sprite = sp2;
            Destroy(collision.gameObject);
            Debug.Log("Oh, Coin");

            //��Ҹ���++
            this.AddCoinNum();
        }
    }


    // shit����++
    private void AddShitNum() {
        this.shit_num++;
        this.t2.text = "" + this.shit_num;
    }

    private void AddCoinNum() {
        this.coin_num++;
        this.t1.text = "" + this.coin_num;
    }

    private void SetDirection(Vector3 pos) {
        Vector3 face = transform.up;
        Vector3 direc = pos - transform.position;

        float angle = Vector3.SignedAngle(face,direc,Vector3.forward);
        transform.Rotate(0,0,angle);
    }


    //�����ӵ�
    private void Fire() {
        GameObject bullets = Instantiate(bullet);
        bullet.transform.position = transform.position + new Vector3(0, 1f, 0);
    }



}
