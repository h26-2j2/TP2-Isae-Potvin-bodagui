using UnityEngine;
using UnityEngine.SceneManagement;

public class jeu : MonoBehaviour
{
    public string introScene = "EcranTitre";
    public string sceneJeu = "Niveau1";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DemmarerJeu()
    {
        SceneManager.LoadScene(sceneJeu);
    }
}
