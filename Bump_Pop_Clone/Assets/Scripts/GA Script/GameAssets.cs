using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _instance;


    private void Awake() {
        if(_instance == null)
        {

            _instance = this;
            
        }
    }
    public static GameAssets instance
    {
        get
        {
            _instance = Instantiate(Resources.Load<GameAssets>("GameAssets")); //as GameObject).GetComponent<GameAssets>());
            return _instance;
        }
    }



    public SoundAudioClip[] soundAudioClipArray;
    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundEvents.Sound sound;
        public AudioClip audioClip;
    }
}
