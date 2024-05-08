using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ArrowContoller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下させる
        transform.Translate(0, -0.1f, 0);

        //画面外にでたらオブジェクトを破壊する
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        // Vector2 p1 = transform.position;
        // Vector2 p2 = this.player.transform.position;
        // Vector2 dir = p1 - p2;
        // float d = dir.

    }
}
