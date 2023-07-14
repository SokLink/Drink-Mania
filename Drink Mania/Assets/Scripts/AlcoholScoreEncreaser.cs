using System;
using UnityEngine;

public class AlcoholScoreEncreaser : MonoBehaviour
{
    [SerializeField] private AlcoholScoreCounter alcoholScoreCounter;

    [NonSerialized] public int _encreaseMagnitude = 1;

    public void Encreser()
    {
        alcoholScoreCounter.alcoholScore += _encreaseMagnitude;
    }
}
