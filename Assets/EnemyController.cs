using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int hitCount = 0;  // ダメージを受けた回数
    public int maxHits = 3;    // 最大ヒット数（3回）

    // Update is called once per frame
    void Update()
    {
        // ここに敵の動きなどの処理が入る場合もあります。
    }

    // 弾や他のオブジェクトに当たった時の処理
    void OnTriggerEnter2D(Collider2D other)
    {
        // 弾に当たったときの処理を追加
        if (other.gameObject.tag == "Bullet")
        {
            hitCount++;  // ダメージカウントを増やす

            // ヒット数が3回に達したらオブジェクトを破棄
            if (hitCount >= maxHits)
            {
                Destroy(gameObject);  // 敵を破棄
            }

            // 弾も破棄
            Destroy(other.gameObject);
        }
    }
}