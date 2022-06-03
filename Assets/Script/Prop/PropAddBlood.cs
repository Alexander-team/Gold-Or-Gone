using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prop
{
    /// <summary>
    /// ��Ѫ����
    /// </summary>
    public class PropAddBlood : PropBase
    {
        [SerializeField] int addBloodVal;           //Ҫ��Ѫ����ֵ��������ֶ����룩

        public override void onPlayerEnter(Player.PlayerAttribute playerAttribute)
        {
            if(playerAttribute.playerHealth.blood < playerAttribute.playerHealth.MaxBlood)
            {
                playerAttribute.playerHealth.addBlood(addBloodVal);
                Debug.Log("Player blood is add");
                Destroy(gameObject);
            }
        }
    }
}
