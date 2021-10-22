using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthJetReward : MonoBehaviour
{
    public GameObject HealthJet;
    public GameObject SpeedBoost;
    public void DropReward()
    {
        Instantiate(SpeedBoost, HealthJet.transform.position, Quaternion.identity);
    }
}
