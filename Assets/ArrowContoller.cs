using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowContoller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下させる
        transform.Translate(0, -0.1f, 0);

        //画面外にでたらオブジェクトを破壊する
        if (transform.position.y < -7.0f)
        {
            Destroy(gameObject);  //破壊処理しないと、どこまでも落下していく
        }

        //当たり判定
        Vector2 p1 = transform.position;                //矢の中心座標
        Vector2 p2 = this.player.transform.position;    //プレイヤの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;    //矢の半径
        float r2 = 2.0f;    //プレイヤの半径

        if (d < r1 + r2)
        {
            Debug.Log("ok");
            //監督スクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //衝突した場合は矢を消す
            Destroy(gameObject);
        }

    }
}
