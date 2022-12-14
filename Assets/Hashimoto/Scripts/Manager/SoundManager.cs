using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    const string TITLE_SCENE_NAME = "TitleScene";
    const string GAME_SCENE_NAME = "GameScene";
    const string RESULT_SCENE_NAME = "ResultScene";

    AudioSource _audioSource;// 音を鳴らすためのもの

    [SerializeField]
    [Header("効果音系")]
    SoundSFX[] _soundSFX;

    [SerializeField]
    [Header("BGM系")]
    SoundBGM[] _soundBGM;


    protected override void Awake()
    {
        base.Awake();

        if (TryGetComponent(out _audioSource))
        {
            Debug.Log("オーディオソースが参照できた");
        }

        FirstBGM();
    }

    void FirstBGM()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case TITLE_SCENE_NAME:
                PlayBGM(BGMType.Title);
                break;

            case GAME_SCENE_NAME:
                PlayBGM(BGMType.Game);
                break;

            case RESULT_SCENE_NAME:
                PlayBGM(BGMType.Result);
                break;
        }

        _audioSource.Play();
    }

    /// <summary>シーンによってBGMを変える関数</summary>
    /// <param name="type">シーンタイプ</param>
    public void PlayBGM(BGMType type)
    {
        var s = Array.Find(_soundBGM, e => e.Type == type);
        if (s != null)
        {
            _audioSource.PlayOneShot(s.Clip);
        }
        else
        {
            Debug.LogError("AudioClipが無いです");
        }
    }

    /// <summary>効果音を鳴らすための関数</summary>
    /// <param name="type">効果音タイプ</param>
    public void PlaySFX(SFXType type)
    {
        var s = Array.Find(_soundSFX, e => e.Type == type);
        if (s != null)
        {
            _audioSource.PlayOneShot(s.Clip);
        }
        else
        {
            Debug.LogError("AudioClipがないです");
        }
    }

    public void StopBGM()
    {
        _audioSource.Stop();
    }

    [Serializable]
    public class SoundSFX
    {
        public AudioClip Clip => _clip;

        public SFXType Type => _type;

        [SerializeField]
        SFXType _type;

        [SerializeField]
        AudioClip _clip;

    }

    [Serializable]
    public class SoundBGM
    {
        public AudioClip Clip => _clip;

        public BGMType Type => _type;

        [SerializeField]
        BGMType _type;

        [SerializeField]
        AudioClip _clip;
    }
}