using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call_child : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject game;

        int count = transform.childCount;
        for (int i = 0; i< count; i++)
        {
           
            string adress = transform.GetChild(i).name;
            game = GameObject.Find(adress);

            //�̸��� ���� ���»�뷮 �޾ƿ�
            getUseQty(adress);

            //���»�뷮 ���ؿ� ���� �� ������
            setColor(game, 10f) ;
        }
    }

    void setColor(GameObject gameobj , float useQty)
    {

    }

    void getUseQty(string adress)
    {

    }

}
