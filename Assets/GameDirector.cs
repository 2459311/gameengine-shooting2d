using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthSlider;  // HP�o�[�iSlider�j���A�^�b�`
    public int maxHealth = 100;  // �ő�HP
    private int currentHealth;   // ���݂�HP

    void Start()
    {
        currentHealth = maxHealth;  // HP���ő�l�ɐݒ�
        healthSlider.maxValue = maxHealth;  // Slider�̍ő�l���ő�HP�ɐݒ�
        healthSlider.value = currentHealth;  // Slider�̏����l�����݂�HP�ɐݒ�
    }

    // �_���[�W���󂯂����̏���
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;  // �_���[�W��HP�����炷
        if (currentHealth < 0)
        {
            currentHealth = 0;  // HP��0�������Ȃ��悤�ɂ���
        }
        healthSlider.value = currentHealth;  // Slider�̒l�����݂�HP�ɔ��f
    }

    // HP���񕜂��鏈���i��j
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;  // �񕜗ʕ�HP�𑝂₷
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;  // HP���ő�l�𒴂��Ȃ��悤�ɂ���
        }
        healthSlider.value = currentHealth;  // Slider�̒l�����݂�HP�ɔ��f
    }
}
// ��F�G�ɓ����������Ƀ_���[�W��^����

