using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //左右が押された時
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -20)
        {
            transform.Translate(-6 * Time.deltaTime, 0, 0);//左に3動かす
        }

        //右が押された時
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 20)
        {
            transform.Translate(6 * Time.deltaTime, 0, 0);//右に3動かす
        }

    }

    public void LButtonDown()
    {
        transform.Translate(-6, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(6, 0, 0);
    }


}
