using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour,ITree
{
    [SerializeField]
    [Header("���Z�X�R�A")]
    int _addScore;
    public void TreeCut(GameObject obj)
    {
        Destroy(obj);
        ScoreManager.Instance.AllScore(_addScore);
    }
}
