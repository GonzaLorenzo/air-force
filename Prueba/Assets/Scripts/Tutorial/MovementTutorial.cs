using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTutorial : MonoBehaviour
{
    public KeyCode          CloseKey = KeyCode.Space;
    public GameObject       MTutorialContainer;
    public GameObject       STutorialContainer;
    public PlayerMovement   myPlayerMovement;
    public PlayerAttack     myPlayerAttack;
    public float            DelayBeforeTutorial;

    private void Update()
    {
        if (Input.GetKeyDown(CloseKey))
        {
            if (MTutorialContainer != null && MTutorialContainer.activeSelf == true)
            {
                MTutorialContainer.SetActive(false);

                myPlayerMovement.CanMove = true;

                StartCoroutine(ShowShootTutorial());

            }
        }

        IEnumerator ShowShootTutorial()
        {
            yield return new WaitForSeconds(DelayBeforeTutorial);

            if (STutorialContainer != null)
            {
                myPlayerAttack.CanAttack = true;

                STutorialContainer.SetActive(true);
                
                myPlayerMovement.CanMove = false;
            }
        }
    }




}

