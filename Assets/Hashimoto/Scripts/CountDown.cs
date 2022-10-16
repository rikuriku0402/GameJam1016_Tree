using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    [Header("カウントダウン")]
    float _countdown = 5.0f;

    [SerializeField]
    [Header("時間を表示するText型の変数")]
    public Text _timeText;

    void Update()
    {
        //時間をカウントダウンする
        _countdown -= Time.deltaTime;

        //時間を表示する
        _timeText.text = _countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (_countdown <= 0)
        {
            _timeText.text = "時間になりました！";
            SceneLoader.Instance.SceneChange("ResultScene");
        }
    }
}
