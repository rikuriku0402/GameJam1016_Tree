using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    [Header("�J�E���g�_�E��")]
    float _countdown = 5.0f;

    [SerializeField]
    [Header("���Ԃ�\������Text�^�̕ϐ�")]
    public Text _timeText;

    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        _countdown -= Time.deltaTime;

        //���Ԃ�\������
        _timeText.text = _countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (_countdown <= 0)
        {
            _timeText.text = "���ԂɂȂ�܂����I";
            SceneLoader.Instance.SceneChange("ResultScene");
        }
    }
}
