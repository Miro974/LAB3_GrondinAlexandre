using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    // Attributs
    private bool _finJeu = false;
    private GestionJeu _gestionJeu;

    //Méthodes privées
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_finJeu)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            _finJeu = true;

            //Récupérer index de la scène
            int numScene = SceneManager.GetActiveScene().buildIndex;
            if (numScene == (SceneManager.sceneCountInBuildSettings - 3))
            {
                _gestionJeu.SetTpsFinal(Time.time);
                SceneManager.LoadScene(numScene + 1);
            }
            else
            {
                // Charger la scène suivante
                
                    _gestionJeu.SetNiv1(_gestionJeu.GetPointage(), Time.time);


                    _gestionJeu.SetNiv2(_gestionJeu.GetContactNiv2(), Time.time);


                SceneManager.LoadScene(numScene + 1);
            }
            
        }

    }
}
