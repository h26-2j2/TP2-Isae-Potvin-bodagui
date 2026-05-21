using UnityEngine;

public class Dechets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Cacher()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        //Invoke("Reapparaitre", 2f);
    }

    void Reapparaitre()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }

}
