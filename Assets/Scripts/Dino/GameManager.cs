using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        int defaultSpeed = -5;
        int increSpeeed = (score * -1) / 100;
        if (increSpeeed < -5)
        {
            increSpeeed = -5;
        }

        return defaultSpeed + increSpeeed;
    }
}
