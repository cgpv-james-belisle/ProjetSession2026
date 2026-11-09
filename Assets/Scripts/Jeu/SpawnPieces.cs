using UnityEngine;

public class SpawnPieces : MonoBehaviour
{
    [SerializeField]
    private GameObject PieceOr;
    [SerializeField]
    private GameObject PieceArgent;
    [SerializeField]
    private GameObject PieceBronze;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DeposerPieces();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeposerPieces()
    {
        //Déposer la pièce de façon complètement aléatoire
        Instantiate(PieceOr, 
            transform.position,
            new Quaternion(Random.Range(0,360), Random.Range(0,360), Random.Range(0,360), 0));
        Instantiate(PieceArgent,
            transform.position,
            new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0));
        Instantiate(PieceBronze,
            transform.position,
            new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0));
    }
}
