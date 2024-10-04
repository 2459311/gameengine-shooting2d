using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthSlider;  // HPバー（Slider）をアタッチ
    public int maxHealth = 100;  // 最大HP
    private int currentHealth;   // 現在のHP

    void Start()
    {
        currentHealth = maxHealth;  // HPを最大値に設定
        healthSlider.maxValue = maxHealth;  // Sliderの最大値を最大HPに設定
        healthSlider.value = currentHealth;  // Sliderの初期値を現在のHPに設定
    }

    // ダメージを受けた時の処理
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;  // ダメージ分HPを減らす
        if (currentHealth < 0)
        {
            currentHealth = 0;  // HPが0を下回らないようにする
        }
        healthSlider.value = currentHealth;  // Sliderの値を現在のHPに反映
    }

    // HPを回復する処理（例）
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;  // 回復量分HPを増やす
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;  // HPが最大値を超えないようにする
        }
        healthSlider.value = currentHealth;  // Sliderの値を現在のHPに反映
    }
}
// 例：敵に当たった時にダメージを与える

