using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileExplosion : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
