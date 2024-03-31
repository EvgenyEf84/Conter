using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;
    private Coroutine _coroutine;
    private int _number = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(CountUp());
            }
            else
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }

    private IEnumerator CountUp()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            _number++;
            DisplayCountUp();

            yield return wait;
        }
    }

    private void DisplayCountUp()
    {
        _text.text = _number.ToString();
    }

}
