using UnityEngine;

public class FileAttente : MonoBehaviour
{
    [SerializeField]
    private GameObject[] positionsFile;

    private Client[] clientsFile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Client>(out Client client))
        {
            AjouterClientListe(client);
        }
    }
    private void AjouterClientListe(Client client)
    {
        for (int i = 0; i < positionsFile.Length; i++) {
            if (clientsFile[i] == null)
            {
                clientsFile[i] = client;
                return;
            }
        }

        //TODO: événement pour activer la barre de patience du client
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
