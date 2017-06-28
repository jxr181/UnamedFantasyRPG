using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RPG.CameraUI;

namespace RPG.Characters
{
	public class Energy : MonoBehaviour 
	{
        [SerializeField] RawImage energyBar;
        [SerializeField] float maxEnergyPoints = 100f;
        [SerializeField] float pointsPerHit = 10f;

        float currentEnergyPoints;
        CameraUI.CameraRaycaster cameraRaycaster;

	    // Use this for initialization
	    void Start ()
        {
            currentEnergyPoints = maxEnergyPoints;
            cameraRaycaster.notifyRightClickObservers += ProcessRightClick;
            cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        }
			
			
        void ProcessRightClick(RaycastHit raycastHit, int layerHit)
        {
            float newEnergyPoints = currentEnergyPoints - pointsPerHit;
            currentEnergyPoints = Mathf.Clamp(newEnergyPoints, 0, maxEnergyPoints);
            UpdateEnergyBar();
        }

        private void UpdateEnergyBar()
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