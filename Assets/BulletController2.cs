using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bulletPrefab;  // 弾のプレハブ
    private float bulletInterval = 3.0f;  // 3秒に1回弾を発射
    private float bulletTimer = 0.0f;  // タイマー

    void Update()
    {
        // ロケットの移動処理
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0, 0);
        }

        // タイマーを更新
        bulletTimer += Time.deltaTime;

        // タイマーが3秒を超えたら弾を発射する
        if (bulletTimer >= bulletInterval)
        {
            // 弾を発射する
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            // タイマーをリセット
            bulletTimer = 0.0f;
        }
    }
}
