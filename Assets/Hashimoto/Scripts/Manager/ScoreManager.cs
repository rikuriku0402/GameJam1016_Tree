using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public int AllScorePoint => _allScore;

    /// <summary>
    /// ���Z�X�R�A
    /// </summary>
    int _allScore;

    public int AllScore(int score) => _allScore = score;

}
