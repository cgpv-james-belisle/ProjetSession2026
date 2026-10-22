using System.Collections;
using UnityEngine;
[RequireComponent (typeof(Animator), typeof(AudioSource))]
public class PorteRestaurant : MonoBehaviour
{
    [SerializeField]
    private GameObject porte;

    [SerializeField]
    private AudioClip audioFermeture;
    [SerializeField]
    private AudioClip audioOuverture;

    private Animator animator;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();
    }

    //private IEnumerator CoroutineAnimation(string nomAnimation)
    //{

    //    animator.Play(nomAnimation);
    //    yield return new WaitForEndOfFrame(); //60 frames puisque c'est la longueur de l'animation
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CameraDepart camera)) //TODO: ajouter une réaction pour lorsque l'objet est un monstre client ou le joueur
        {
            animator.Play("OuvrirPorte");
            audioSource.clip = audioOuverture;
            audioSource.Play();
            //À la fin de l'animation, on laisse la porte à son angle de fin
            //porte.transform.Rotate(0, 150, 0);
           // Debug.Log("Script d'ouverture de porte déclenché");
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Camera")) //TODO: ajouter une réaction pour lorsque l'objet est un monstre client ou le joueur
        {
            audioSource.clip = audioFermeture;
            audioSource.Play();
            animator.Play("FermerPorte");
            //À la fin de l'animation, on laisse la porte à son angle de fin
            //porte.transform.Rotate(Vector3.zero);
            //Debug.Log("Script de fermeture");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
