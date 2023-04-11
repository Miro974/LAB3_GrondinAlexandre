using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    public void ChargerSceneSuivante()
    {
        // R�cup�rer l'index de la sc�ne en cours
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene + 1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    public void ChargerSceneTuto()
    {
        SceneManager.LoadScene(5);
    }
}
