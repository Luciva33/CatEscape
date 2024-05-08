using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    // float span = 1.0f; //1病間隔で矢を生成
    float span = 0.3f;
    float delta = 0; //

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-20, 20);  //　以上、未満
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
