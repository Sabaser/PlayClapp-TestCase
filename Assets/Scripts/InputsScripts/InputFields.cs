using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InputFields : MonoBehaviour
{
    public TMP_InputField InputField;

    [SerializeField]
    string key;

    void Start()
    {
        InputField.onValueChanged.AddListener(delegate { onValueChanged(); });
        CubeState.settings[key] = float.Parse(InputField.text);
    }

    void onValueChanged()
    {
        CubeState.settings[key] = float.Parse(InputField.text);
    }

}
