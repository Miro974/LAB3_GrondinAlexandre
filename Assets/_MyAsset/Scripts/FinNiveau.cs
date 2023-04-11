using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    // Attributs
    private bool _finJeu = false;
    private GestionJeu _gestionJeu;
    private Player _player;

    //M�thodes priv�es
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_finJeu)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            _finJeu = true;

            //R�cup�rer index de la sc�ne
            int numScene = SceneManager.GetActiveScene().buildIndex;
            if (numScene == (SceneManager.sceneCountInBuildSettings - 3))
            {
                _gestionJeu.SetTpsFinal(Time.time);
                SceneManager.LoadScene(numScene + 1);
            }
            else
            {
                // Charger la sc�ne suivante
                
                    _gestionJeu.SetNiv1(_gestionJeu.GetPointage(), Time.time);
                   
                
                    _gestionJeu.SetNiv2(_gestionJeu.GetContactNiv2(), _gestionJeu.GetTpsNiv2());


                SceneManager.LoadScene(numScene + 1);
            }
            
        }

    }
}
