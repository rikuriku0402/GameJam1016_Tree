using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ITree tree))
        {
            tree.TreeCut(other.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Cut);
        }
        PlayerPrefs.SetInt("SCORE", ScoreManager.Instance.AllScorePoint);
        PlayerPrefs.Save();
    }
}
