using System;
using UnityEngine;

namespace NinisanVjVfx
{
    public class AudioSpectrumOperator : UnityEngine.MonoBehaviour
    {
        [SerializeField] private AudioSpectrum spectrum;

        private void Start()
        {
            
        }

        private void Update()
        {
            Debug.Log(spectrum.Levels.Length);
        }
    }
}