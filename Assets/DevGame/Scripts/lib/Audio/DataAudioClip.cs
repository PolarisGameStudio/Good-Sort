using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAudioClip : Singleton<DataAudioClip>
{
    [Header("Sound FX")]
    [SerializeField] public List<string> DatasFX = null;

    [Header("Sound BG")]
    [SerializeField] public List<string> DatasBG = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
