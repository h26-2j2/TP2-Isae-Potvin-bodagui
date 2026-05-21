using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System;

public class jeu : MonoBehaviour
{
    public string introScene = "EcranTitre";
    public string niveau1 = "Niveau1";

    public string niveau2 = "Niveau2";

    public string niveau3 = "Niveau3";

    public string sceneVictoire = "EcranVictoire";
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            DemmarerJeu();
        }
    }
    public void DemmarerJeu()
    {
        SceneManager.LoadScene(niveau1);
    }

    public void RedemmarerJeu()
    {
        SceneManager.LoadScene(introScene);
    }
}
