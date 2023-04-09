using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField, Range(1f, 20f)] int _scoreSpeed;

    float _score;

    private void Update()
    {
        _score += Time.deltaTime * _scoreSpeed;
        _scoreText.text = _score.ToString("0");
    }
}
