using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotaY = 1f;

    // M�thodes priv�es 
    private void Update()
    {
        transform.Rotate(0f, _vitesseRotaY, 0f);
    }
}
