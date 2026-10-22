using UnityEngine;

public class MontrerMenuTaverne : MonoBehaviour
{
    [SerializeField, Tooltip("La section qui désigne l'interface du jeu")]
    private GameObject interfaceJeu;


    private GameObject enfantADesactiver;
    private void Awake()
    {
        enfantADesactiver = interfaceJeu.transform.GetChild(0).gameObject;
        enfantADesactiver.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CameraDepart camera))
        {
            enfantADesactiver.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
