using UnityEngine;
using UnityEngine.UI;
using System;

namespace RPG.Characters
{
	public class Energy : MonoBehaviour 
	{
        [SerializeField] RawImage energyBar = null;
        [SerializeField] float maxEnergyPoints = 100f;

        public float currentEnergyPoints;
        CameraUI.CameraRaycaster cameraRaycaster;
        
		// Use this for initialization
		void Start ()
        {
            currentEnergyPoints = maxEnergyPoints;
        }

        public bool IsEnergyAvailable(float amt)
        {
            return amt < currentEnergyPoints;
        }

        public void ConsumeEnergy(float amount)
        {
            float newEnergyPoints = currentEnergyPoints - amount;
            currentEnergyPoints = Mathf.Clamp(newEnergyPoints, 0f, maxEnergyPoints);
            UpdateEnergyBar();
        }

        void UpdateEnergyBar()
        {
            float xValue = -(EnergyAsPercent() / 2f) - 0.5f;
            energyBar.uvRect = new Rect(xValue, 0f, 0.5f, 1f);
        }

        float EnergyAsPercent()
        {
            return currentEnergyPoints / maxEnergyPoints;
        }
	}
}