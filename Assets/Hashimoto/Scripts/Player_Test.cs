using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Test : MonoBehaviour
{
    /// <summary>
    /// マイナスポイント
    /// </summary>
    int _minusPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IEnemy enemy))
        {
            enemy.GetMinusPoint(_minusPoint);
            Destroy(other.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Death);
        }

        if (other.TryGetComponent(out ITree tree))
        {
            tree.TreeCut(other.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Cut);
        }
        PlayerPrefs.SetInt("SCORE", ScoreManager.Instance.AllScorePoint);
        PlayerPrefs.Save();
    }
}
