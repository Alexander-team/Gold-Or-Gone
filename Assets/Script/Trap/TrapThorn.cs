using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trap
{
    /// <summary>
    /// �ش�����
    /// </summary>
    public class TrapThorn : TrapBase
    {
        [SerializeField] int damage;            //�˺���ֵ���������ֶ����룩
        private void Awake()
        {
            if(damage == 0)
            {
                damage = 1;                     //Ĭ�ϳ�ʼ��
            }
        }
        public override void onPlayerEnter(Player.PlayerAttribute playerAttribute)
        {
            if(playerAttribute.playerHealth.blood > 0)      //�������Ѫ��ʱ
            {
                playerAttribute.playerHealth.damageAction(damage);      //���������˺�
                Debug.Log("Player is gets damage");
            }
        }
    }


}