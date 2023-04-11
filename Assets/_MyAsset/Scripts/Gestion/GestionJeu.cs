using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{
    // Attributs
    private int _pointage = 0;
    private float _tpsDepart = 0;
    private float _tpsFinal = 0;
    private int _contactNiv1 = 0;
    private int _contactNiv2 = 0;
    private float _tpsNiv1 = 0.0f;
    private float _tpsNiv2 = 0.0f;


    // Métodes privées
    private void Start()
    {
      _tpsDepart = Time.time;  
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;  // Fonction qui détermine si l'on garde ou non les inforamtions d'une scène
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }



    // Méthodes publiques

    // Fonctions pour récupérer divers informations liées à chacun des niveaux
    public void AugmenterPointage()
    {
        _pointage++;
        GestionUI gestionUi = FindObjectOfType<GestionUI>();
        gestionUi.ChangerPointage(_pointage);
    }

    public int GetPointage()
    { 
        return _pointage;
    }

    public float GetTpsDepart()
    {
        return _tpsDepart;
    }

    public void SetTpsFinal(float p_tpsFinal)
    {
        _tpsFinal = p_tpsFinal - _tpsDepart;
    }

    public float GetTpsFinal()
    {
        return _tpsFinal;
    }
    public int GetContactNiv1()
    {
        return _contactNiv1;
    }

    public float GetTpsNiv1()
    { 
        return _tpsNiv1;
    }

    public int GetContactNiv2()
    {
        return _contactNiv2;
    }

    public float GetTpsNiv2()
    {
        return _tpsNiv2;
    }

    public void SetNiv1(int contacts, float tpsNiv1)
    { 
        _contactNiv1 = contacts;
        _tpsNiv1 = tpsNiv1; 
    }

    public void SetNiv2(int contacts2, float tpsNiv2)
    {
        _contactNiv2 = contacts2;
        _tpsNiv2 = tpsNiv2;
    }
}
