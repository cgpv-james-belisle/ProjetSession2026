using UnityEngine;

public class CameraDepart : MonoBehaviour
{
    [SerializeField, Tooltip("Position où la camera cesse de bouger")]
    private GameObject positionFin;
    [SerializeField]
    private float vitesseCamera = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void DeplacementGuide()
    {
        transform.position = Vector3.MoveTowards(transform.position, positionFin.transform.position, vitesseCamera*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        DeplacementGuide();
    }
}
