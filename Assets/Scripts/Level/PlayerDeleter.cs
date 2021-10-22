using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeleter : MonoBehaviour
{
    public GameObject EndLevelContainer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EndLevelContainer.SetActive(true);
    }
}
