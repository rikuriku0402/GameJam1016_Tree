using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    [Header("スコアテキスト")]
    Text _scoreText;


    void Start()
    {
        int score = PlayerPrefs.GetInt("SCORE");
        _scoreText.text = score.ToString();
    }
}
