using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionBarriere : MonoBehaviour
{
    // Fonction qui d�truit les barri�res du troisi�me niveau
    public void BarriereDestroy()
    { 
        gameObject.SetActive(false);
    }
}
