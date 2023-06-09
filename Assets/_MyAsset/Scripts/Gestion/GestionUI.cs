using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class GestionUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
    private bool _enPause;
    private GestionJeu _gestionJeu;


    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtAccrochages.text = "Accrochages: " + _gestionJeu.GetPointage();
        Time.timeScale = 1;
        _enPause = false;
    }

   
    private void Update()
    {
        Timer();
        GestionPause();
    }

    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
        
    }

    //M�thodes publiques

    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = "Accrochages: " + p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }

    public void Timer()
    {
        float temps = Time.time - _gestionJeu.GetTpsDepart();
        _txtTemps.text = "Temps: " + temps.ToString("f2");
    }
}
