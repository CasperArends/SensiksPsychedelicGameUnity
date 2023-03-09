using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sensiks.SDK.UnityLibrary;
using Sensiks.SDK.Shared.SensiksDataTypes;

public class FurnaceTrigger : MonoBehaviour
{
    private FurnaceManager furnaceManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coal")
        {
            Debug.Log("Coal in fire");
            
            //SensiksManager.SetHeaterIntensity(HeaterPosition.FRONT, 0.5f);
            SensiksManager.SetActiveScent(Scent.SMOKE, 0.1f);
            
        }
    }
}