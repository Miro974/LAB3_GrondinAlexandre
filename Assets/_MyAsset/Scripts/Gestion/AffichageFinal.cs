using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AffichageFinal : MonoBehaviour
{

    [SerializeField] private TMP_Text _txtTpsTotal = default;
    [SerializeField] private TMP_Text _txtAccrochagesTotal = default;
    [SerializeField] private TMP_Text _txtPointageTotal = default;
    private GestionJeu _gestionJeu;
 
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtTpsTotal.text = "Temps total: " + _gestionJeu.GetTpsFinal().ToString("f2") + "sec";
        _txtAccrochagesTotal.text = "Nombre d'accrochages: " + _gestionJeu.GetPointage().ToString();
        float pointageTotal = _gestionJeu.GetTpsFinal() + _gestionJeu.GetPointage();
        _txtPointageTotal.text = "Pointage Final: " + pointageTotal.ToString("f2") + "sec";

        Debug.Log(_txtTpsTotal.text.ToString());
        Debug.Log(_txtAccrochagesTotal.text.ToString());
        Debug.Log(_txtPointageTotal.text.ToString());
    }




}
