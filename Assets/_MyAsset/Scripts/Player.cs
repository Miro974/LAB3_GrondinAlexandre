using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs
    [SerializeField] private float _vitesse = 850f;
    private Rigidbody _rb;
    

    //M�thodes priv�es
    private void Start()
    {
        //Position initiale du joueur
        transform.position = new Vector3(0f, 0.70f, -45f);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        mouvementJoueur();
    }

    private void mouvementJoueur()
    {
        float posX = Input.GetAxis("Horizontal");
        float posZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(posX, 0f, posZ);
        direction.Normalize();
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;


    }

    //M�thodes publiques
    public void finJoueur()     // Fonction qui termine le jeu en faisant dispara�tre le joueur � la fin du dernier niveau
    {
        gameObject.SetActive(false);
    }


}