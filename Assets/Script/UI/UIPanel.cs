using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI���ű�
/// </summary>
public class UIPanel : MonoBehaviour
{
    public Image panelImage;
    public AnimationCurve showCurve;            //������������
    public AnimationCurve hideCurve;            //�رն�������
    public float animationSpeed;                //��������
    [SerializeField] private bool isShow = false;       //�ж��Ƿ��Ѿ���ʾUI

    private void Awake()
    {
        panelImage = gameObject.GetComponent<Image>();      //��ȡͼƬ���
    }
    IEnumerator ShowPanel()
    {
        float timer = 0;                //��ʼ����ʱ��
        while (panelImage.color.a < 1)
        {
            panelImage.color = new Vector4(1, 1, 1, showCurve.Evaluate(timer));
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }

    IEnumerator HidePanel()
    {
        float timer = 0;                //��ʼ����ʱ��
        while (panelImage.color.a > 0) 
        {
            panelImage.color = new Vector4(1, 1, 1, hideCurve.Evaluate(timer));
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if(isShow == false)
        //    {
        //        StopAllCoroutines();            //ֹͣ��ǰ����
        //        StartCoroutine(ShowPanel());    //��ʼ��������
        //    }
        //    else if (isShow == true)
        //    {
        //        StopAllCoroutines();            //ֹͣ��ǰ����
        //        StartCoroutine(HidePanel());    //��ʼ�رն���
        //    }
        //}
    }
}
