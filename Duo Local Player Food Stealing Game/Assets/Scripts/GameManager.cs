using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private float maxTime;

    private void Start()
    {
        StartTimer();
    }

    private void StartTimer()
    {
        for (float i = maxTime; i >= 0; i--)
        {
            Debug.Log(i);
            Thread.Sleep(100);
        }
    }
}
