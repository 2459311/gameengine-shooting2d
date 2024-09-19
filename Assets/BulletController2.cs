using UnityEngine;
using System.Collections;

public class BulletController2 : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, -0.02f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
}