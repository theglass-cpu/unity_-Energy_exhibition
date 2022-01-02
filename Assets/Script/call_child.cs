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

            //이름에 따라 전력사용량 받아옴
            getUseQty(adress);

            //전력사용량 기준에 따라 색 입히기
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
