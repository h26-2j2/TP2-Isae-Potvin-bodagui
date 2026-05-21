using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.SceneManagement;
using TMPro;

public class DeplacementJoueur : MonoBehaviour
{
    public InputAction mouvementHorizontal;
    public int points;
    public InputAction mouvementVertical;
    public float vitesse = 5f;
    public bool estMort = false;
    private float tempsRestant = 60f;
    public TMP_Text texteMinuteur;
    private int nombreTotalDechets;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        points = 0;
        nombreTotalDechets = GameObject.FindGameObjectsWithTag("Dechets").Length;
    }

    private void OnEnable()
    {
        mouvementHorizontal.Enable();
        mouvementVertical.Enable();
    }

    private void OnDisable()
    {
        mouvementHorizontal.Disable();
        mouvementVertical.Disable();
    }

    void Update()
    {
        Vector2 movement = new Vector2(mouvementHorizontal.ReadValue<float>(), mouvementVertical.ReadValue<float>());
        transform.Translate(movement * Time.deltaTime * vitesse);

        if (tempsRestant > 0)
        {
            tempsRestant -= Time.deltaTime; // Réduire le temps restant
            texteMinuteur.text = $"Temps restant: {Mathf.Ceil(tempsRestant)}s";
        }
        else
        {
            texteMinuteur.text = "Temps écoulé!";
        }

        if (tempsRestant <= 0)
        {
            Invoke("RedemarrerScene", 2f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dechets")
        {
            points++;
            collision.gameObject.GetComponent<Dechets>().Cacher();
            // Destroy(collision.gameObject);// Détruit le game object
            Debug.Log(points);
        }

        if (points == nombreTotalDechets)
        {
            int indexSceneActuelle = SceneManager.GetActiveScene().buildIndex;
            int indexSceneSuivante = indexSceneActuelle + 1;
            if (indexSceneSuivante < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(indexSceneSuivante);
            }
            else
            {
                SceneManager.LoadScene("EcranVictoire");
            }
        }
    }

    void RedemarrerScene()
    {
        SceneManager.LoadScene("EcranTitre");
    }
}