using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("roket");
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[�����Ƃɓ����ŗ���������
        transform.Translate(0, -0.007f, 0);

        //��ʂɏo����I�u�W�F�N�g��j������
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1f;
        float r2 = 0.6f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}