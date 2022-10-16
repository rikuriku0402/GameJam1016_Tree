using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    [Header("�X�R�A�e�L�X�g")]
    Text _scoreText;


    void Start()
    {
        int score = PlayerPrefs.GetInt("SCORE");
        _scoreText.text = score.ToString();
    }
}
