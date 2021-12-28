using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jy_ClickListener : MonoBehaviour
{

    Renderer sr;

    // 클릭하고 싶은 오브젝트
    public GameObject clickObject;

    // 세계지도에 사용
    public GameObject board, country, content;

    // 온실가스에 사용
    //public GameObject arros_before, arrow_safe, arrow_10ago, arrow_dangerous;
    public GameObject arrow;
    bool before, ago10, safe, dangerous = false;


    public void btnClick()
    {
        sr = clickObject.GetComponent<Renderer>();

        // 클릭하려는 오브젝트 이름
        string objectName = clickObject.name;

        Debug.Log(objectName);


        board = GameObject.Find("explain_board");

        if (objectName.Equals("jy_btn1"))
        {
            country.GetComponent<TextMesh>().text = "캐나다";
            content.GetComponent<TextMesh>().text = "- 1.17 ~ 18 : 동부 눈 폭, 적설량 최대 75cm, 최대풍속 150km/h";
        }
        else if (objectName.Equals("jy_btn2"))
        {
            country.GetComponent<TextMesh>().text = "미국";
            content.GetComponent<TextMesh>().text =
                "- 1.11 ~ 12 : 남부 겨울 폭풍, 최대풍속 130km/h, 11명 사망\n" +
                "- 2.16 : 홍수, 펄강 수위 11.75m (역대 3위로 높은 기록)\n" +
                "- 7 ~ 8월 캘리포니아 산불 620000ha 소실, 최소 7명 사망";
        }
        else if (objectName.Equals("jy_btn3"))
        {
            country.GetComponent<TextMesh>().text = "중미/대서양";
            content.GetComponent<TextMesh>().text = "- 11.3 ~ 6 : 최대풍속 225km/h, 허리케인 '에타', 홍수와 산사,\n최소 130여명 사망";
        }
        else if (objectName.Equals("jy_btn4"))
        {
            country.GetComponent<TextMesh>().text = "브라질";
            content.GetComponent<TextMesh>().text =
                "- 1.23 ~ 28 : 호, 65명 사, 강수량 942mm(110년 만에 최고 강수)\n" +
                "- 1.7 ~ 12 : 폭염, 최고기온 39도, 체감온도 54.8도\n" +
                "- 3.1 ~ 3: 집중호우, 18명 사망, 60여명 실종";
        }
        else if (objectName.Equals("jy_btn5"))
        {
            country.GetComponent<TextMesh>().text = "이집트";
            content.GetComponent<TextMesh>().text =
                "- 1월의 눈(알렉산드리아 100, 카이로 112년 만에 1월 눈 관측)";
        }
        else if (objectName.Equals("jy_btn6"))
        {
            country.GetComponent<TextMesh>().text = "수단";
            content.GetComponent<TextMesh>().text =
                "- 7월 중순 ~ 9.27 : 홍수, 120여명 사망";
        }
        else if (objectName.Equals("jy_btn7"))
        {
            country.GetComponent<TextMesh>().text = "케냐";
            content.GetComponent<TextMesh>().text =
                "- 4.23 ~ 5.6 : 홍수, 최소 194ㅁ명 사망, 작물 2237ha 소실";
        }
        else if (objectName.Equals("jy_btn8"))
        {
            country.GetComponent<TextMesh>().text = "콩코민주공화국";
            content.GetComponent<TextMesh>().text =
                "- 4.17 : 콩고 동부 홍수, 최소 25명 사망, 45명 부상\n" +
                "- 9.11 : 동부 폭우로 금광 붕괴, 50여 이상 사망\n";
        }
        else if (objectName.Equals("jy_btn9"))
        {
            country.GetComponent<TextMesh>().text = "노르웨이";
            content.GetComponent<TextMesh>().text =
                "- 1.2 : 이상고온, 최고기온 19도 (관측사상 최고 기록)\n" +
                "- 7.24 : 스발바르제도 최고기온 21.7도 (1979년 이후)\n";
        }
        else if (objectName.Equals("jy_btn10"))
        {
            country.GetComponent<TextMesh>().text = "영국";
            content.GetComponent<TextMesh>().text =
                "- 2.9 : 폭풍 '시에라' 156km/h 강풍, 250여 곳 홍수 경보\n" +
                "항공기 수 100편 결항\n" +
                "- 2.15 ~ 16 : 폭풍 '데니스' 146km/h 강풍, 600여 곳 홍수경보";
        }
        else if (objectName.Equals("jy_btn11"))
        {
            country.GetComponent<TextMesh>().text = "스페인";
            content.GetComponent<TextMesh>().text =
                "- 1.19 ~ 22 : 동부 겨울 폭풍 '글로리아', 9명 사망\n" +
                "최대 풍속 144km/h\n";
        }
        else if (objectName.Equals("jy_btn12"))
        {
            country.GetComponent<TextMesh>().text = "터키/그리스";
            content.GetComponent<TextMesh>().text =
                "- 2.4 : 터키 동부 눈사태, 최소 41명 사망, 84명 부상\n";
        }
        else if (objectName.Equals("jy_btn13"))
        {
            country.GetComponent<TextMesh>().text = "아랍에미레이트";
            content.GetComponent<TextMesh>().text =
                "- 1.9 ~ 12 : 홍수, 강수량 최고 190mm 기록 (연 강수량 75mm)\n";

        }
        else if (objectName.Equals("jy_btn14"))
        {
            country.GetComponent<TextMesh>().text = "러시아";
            content.GetComponent<TextMesh>().text =
                "- 6.30 : 북동부 헤르호얀스크, 최고기온 38도(북극 최고기온)\n";

        }
        else if (objectName.Equals("jy_btn15"))
        {
            country.GetComponent<TextMesh>().text = "일본";
            content.GetComponent<TextMesh>().text =
                "- 7.4 ~ 12 : 호우, 규슈 69명 사망, 13명 실종\n" +
                "- 8월 폭염 53명 사망, 시즈오카현 최고 기온 41.1도\n" +
                "- 12.16 : 중북부 24시간 동안 군마현 208cm, 니가타현 183cm의\n" +
                "기록적인 폭설, 1000여 대 차량 도로에 고립";
        }
        else if (objectName.Equals("jy_btn16"))
        {
            country.GetComponent<TextMesh>().text = "중국";
            content.GetComponent<TextMesh>().text =
                "- 4.2 : 북동부 폭설 (37년 만에 4월 최대 폭설)\n" +
                "- 6월 말 ~ 7.22 : 호우, 사망 및 실종 142명, 이재민 4552만여 명\n" +
                "- 11.11 : 북부 홍수로 인한 탄광 산사태, 13명 사망, 120명 구조";
        }
        else if (objectName.Equals("jy_btn17"))
        {
            country.GetComponent<TextMesh>().text = "태국/미얀마";
            content.GetComponent<TextMesh>().text =
                "- 1월 태국 이상저온, 최저기온 10도 기록, 10여명 저체온증 사망\n" +
                "- 7월 미얀마 폭우로 옥광산 산사태 172명 사망\n";
        }
        else if (objectName.Equals("jy_btn18"))
        {
            country.GetComponent<TextMesh>().text = "인도네시아";
            content.GetComponent<TextMesh>().text =
                "- 12.31 ~ 1.4 : 폭우, 60명 사망, 이재민 3만여 명 발생,\n" +
                "- 10.22 : 수마트라섬, 폭우로 인한 산사태, 11명 사망\n";
        }
        else if (objectName.Equals("jy_btn_before"))
        {
            if(before)
            {
                arrow.SetActive(false);
                before = false;
            } else
            {
                arrow.SetActive(true);
                before = true;
            }
            
        }
        else if (objectName.Equals("jy_btn_safe"))
        {
            if (safe)
            {
                arrow.SetActive(false);
                safe = false;
            } else
            {
                arrow.SetActive(true);
                safe = true;
            }
            
        }
        else if (objectName.Equals("jy_btn_10ago"))
        {
            if (ago10)
            {
                arrow.SetActive(false);
                ago10 = false;
            } else
            {
                arrow.SetActive(true);
                ago10 = true;
            }
                   
        }
        else if (objectName.Equals("jy_btn_dangerous"))
        {
            if(dangerous)
            {
                arrow.SetActive(false);
                dangerous = false;
            } else
            {
                arrow.SetActive(true);
                dangerous = true;
            }
            
        }
    }
}
