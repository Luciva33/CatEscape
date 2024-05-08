using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // GameObject hpGauge;
    public Image hpGauge;
    void Start()
    {
        // this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        // Debug.Log("dc");
        // this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        this.hpGauge.fillAmount -= 0.1f;
        if (this.hpGauge.fillAmount <= 0)
        {
            Debug.Log("gameover");
            Time.timeScale = 0f;  //タイムスケールを止める
        }

    }
}
