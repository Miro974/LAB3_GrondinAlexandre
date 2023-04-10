using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // Attributs
    private bool _touche;
    private GestionJeu _gestionJeu;

    //M�thodes priv�es
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _touche = false;
    }

    // Fonctionne qui change la couleur des obstacles et augmeente le pointage lors d�ne collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche && gameObject.tag != "FinNiveau")
            {
                _touche = true;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
            }
        }
        
    }
}
