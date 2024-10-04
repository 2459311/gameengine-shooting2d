using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int hitCount = 0;  // �_���[�W���󂯂���
    public int maxHits = 3;    // �ő�q�b�g���i3��j

    // Update is called once per frame
    void Update()
    {
        // �����ɓG�̓����Ȃǂ̏���������ꍇ������܂��B
    }

    // �e�⑼�̃I�u�W�F�N�g�ɓ����������̏���
    void OnTriggerEnter2D(Collider2D other)
    {
        // �e�ɓ��������Ƃ��̏�����ǉ�
        if (other.gameObject.tag == "Bullet")
        {
            hitCount++;  // �_���[�W�J�E���g�𑝂₷

            // �q�b�g����3��ɒB������I�u�W�F�N�g��j��
            if (hitCount >= maxHits)
            {
                Destroy(gameObject);  // �G��j��
            }

            // �e���j��
            Destroy(other.gameObject);
        }
    }
}