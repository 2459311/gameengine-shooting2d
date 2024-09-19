using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour
{

    float fallSpeed;
    float rotSpeed;

    void Start()
    {
        this.fallSpeed = 0.002f ;
        this.rotSpeed = 0.5f ;
    }

    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
