using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bulletPrefab;  // �e�̃v���n�u
    private float bulletInterval = 3.0f;  // 3�b��1��e�𔭎�
    private float bulletTimer = 0.0f;  // �^�C�}�[

    void Update()
    {
        // ���P�b�g�̈ړ�����
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0, 0);
        }

        // �^�C�}�[���X�V
        bulletTimer += Time.deltaTime;

        // �^�C�}�[��3�b�𒴂�����e�𔭎˂���
        if (bulletTimer >= bulletInterval)
        {
            // �e�𔭎˂���
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            // �^�C�}�[�����Z�b�g
            bulletTimer = 0.0f;
        }
    }
}
