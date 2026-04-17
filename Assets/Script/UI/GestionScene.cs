using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System;

public class jeu : MonoBehaviour
{
    public string introScene = "EcranTitre";
    public string sceneJeu = "Niveau1";
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
        SceneManager.LoadScene(sceneJeu);
    }
}
