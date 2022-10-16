using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Test : MonoBehaviour
{
    /// <summary>
    /// マイナスポイント
    /// </summary>
    int _minusPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IEnemy enemy))
        {
            enemy.GetMinusPoint(_minusPoint);
            Destroy(collision.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Death);
        }
    }
}
