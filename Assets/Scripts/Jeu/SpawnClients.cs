using UnityEngine;

public class SpawnClients : MonoBehaviour
{
    [SerializeField]
    private Client[] prefabClients;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ApparaitreClient();
    }

    private void ApparaitreClient()
    {
        Instantiate(prefabClients[0].gameObject, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
