using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] private float restoreAngle = 90f;
    [SerializeField] private float addIntensity = 1f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightManager>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightManager>().AddLightIntensity(addIntensity);
            Destroy(gameObject, 0.25f);
        }
    }

}
