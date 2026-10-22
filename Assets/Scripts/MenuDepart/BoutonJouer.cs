using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonJouer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Appuye()
    {
        SceneManager.LoadScene("JeuPrincipal");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
