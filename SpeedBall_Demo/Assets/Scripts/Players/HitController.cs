using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
        else if (collision.gameObject.CompareTag("Win"))
        {
            GameManager.Instance.Win();
        }
    }
}
