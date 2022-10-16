using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    [SerializeField]
    [Header("ÉXÉRÉAUI")]
    Text _scoreText;

    private void Update()
    {
        _scoreText.text = ScoreManager.Instance.AllScorePoint.ToString();
    }
}
