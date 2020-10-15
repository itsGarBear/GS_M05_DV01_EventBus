﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pineapple : MonoBehaviour
{
    private bool m_IsQuitting;

    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Pineapple", Pineappled);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Pineapple", Pineappled);
        }
    }
    void Pineappled()
    {
        text.text = "Received a launch event : cutting a pineapple!";
    }
}
