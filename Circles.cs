using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circles : MonoBehaviour
{
    DisplayController displayController;
    SpriteRenderer spriteRendere;
    public GameObject gameobject;
    public GameObject text;

    private bool flag = false;

    private void Start()
    {
        spriteRendere = GetComponent<SpriteRenderer>();
        displayController = text.GetComponent<DisplayController>();
    }

    public void FlagCheck()
    {

        Vector3 circleTrans = this.transform.position; //サークル自身の座標を取得

        Vector3 playerTrans = gameobject.transform.position;    //プレイヤーの座標を取得
        Debug.Log("circleTransは" + circleTrans);
        Debug.Log("playerTransは"+playerTrans);
        {
            if (circleTrans.x == playerTrans.x) //もしサークルとプレイヤーのX座標が同じで
            {
                if (circleTrans.y == playerTrans.y) //サークルとプレイヤーのY座標が同じなら
                {
                    if (!flag)  //"!"はtrueならfalseに、falseならtrueにする演算子。
                    {
                        this.spriteRendere.color = Color.blue;
                        flag = true;
                    }
                    if (flag == true)
                    {
                        this.spriteRendere.color = Color.black;
                    }




                }
            }
        }
    }

    

    
}
