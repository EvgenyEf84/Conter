using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Repeater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;
    [SerializeField] private float _repeatRate;

    void Start()
    {
        _text.text = "начинаем";
        InvokeRepeating(nameof(SetCurrentTime), _delay, _repeatRate);
    }

    private void SetCurrentTime()
    {
        _text.text = Time.time.ToString();
    }
}
