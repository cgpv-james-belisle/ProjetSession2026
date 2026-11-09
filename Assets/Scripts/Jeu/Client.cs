using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class Client : MonoBehaviour
{
    private NavMeshAgent agent;
    private bool place = false;

    private Animator animateurModele;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //Puisque le modèle a besoin d'avoir l'animateur, on obtient l'animateur de l'enfant
        if (transform.GetChild(0) != null)
        {
            animateurModele = transform.GetChild(0).GetComponent<Animator>();
        }
        else
        {
            Debug.LogError($"L'enfant de {gameObject.name} doit avoir un animateur.");
        }
            TestDeplacement();
    }
    private void TestDeplacement()
    {
        agent.destination = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
