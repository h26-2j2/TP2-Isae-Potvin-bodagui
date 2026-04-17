using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class DeplacementJoueur : MonoBehaviour
{
    public InputAction mouvementHorizontal;
    public InputAction mouvementVertical;
    public float vitesse = 5f;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
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
    }
}