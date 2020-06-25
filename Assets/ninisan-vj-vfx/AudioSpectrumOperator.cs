using System;
using UnityEngine;

namespace NinisanVjVfx
{
    public class AudioSpectrumOperator : UnityEngine.MonoBehaviour
    {
        [SerializeField] private AudioSpectrum spectrum;
        [SerializeField] private GameObject cube;
        [SerializeField] private float scaleBias;
        [SerializeField] private float rotationBias;


        private void Start()
        {
        }

        private void Update()
        {
            Debug.Log(spectrum.Levels.Length);

            cube.transform.localScale = spectrum.Levels[1] * scaleBias * Vector3.one;
            cube.transform.rotation *= Quaternion.AngleAxis(spectrum.Levels[5] *spectrum.Levels[5] * rotationBias, new Vector3(1, 1, 0));
            cube.transform.rotation *= Quaternion.AngleAxis(1, Vector3.up);
        }
    }
}