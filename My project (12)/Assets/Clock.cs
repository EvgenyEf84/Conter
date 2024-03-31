using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 2f;

    private float _triggerTime;

    void Start()
    {
        _triggerTime = _delay;
        _text.text = "0";
    }

    void Update()
    {
        if (Time.time >= _triggerTime )
        {
            _text.text = Time.time.ToString("");
            _triggerTime += Time.deltaTime+_delay;
        }
    }
}
