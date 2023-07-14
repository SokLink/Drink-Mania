using System;
using UnityEngine;

public class AlcoholScoreEncreaser : MonoBehaviour
{
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;

    [NonSerialized] public int encreaseMagnitude = 1;

    public void Encreser()
    {
        alcoholScoreCounter.alcoholScore += encreaseMagnitude;
    }
}
