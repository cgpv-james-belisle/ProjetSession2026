using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(TMP_Dropdown))]
public class SelecteurDifficulte : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    private void Awake()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }
    //Méthode changée puisqu'au début de la boucle de jeu, l'objet dropdown est null (désactivé)
    private void OnEnable()
    {
        //Cet appel d'événement est inspiré grandement par la documentation d'Unity: https://docs.unity3d.com/2019.1/Documentation/ScriptReference/UI.Dropdown-onValueChanged.html
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.onValueChanged.AddListener(delegate
        {
            ChangementDifficulte(dropdown);
        });
    }
    /// <summary>
    /// Méthode appelée lorsqu'on change le choix dans la sélection de difficulté
    /// </summary>
    /// <param name="changement">La nouvelle valeur choisie du sélecteur</param>
    public void ChangementDifficulte(TMP_Dropdown changement)
    {
        //PlayerPrefs peut se conserver entre parties comme entre scènes. C'est donc une façon idéale d'informer le jeu de la difficulté choisie
        //Référence: https://docs.unity3d.com/6000.6/Documentation/ScriptReference/PlayerPrefs.html
        //Référence SetInt: https://docs.unity3d.com/6000.6/Documentation/ScriptReference/PlayerPrefs.SetInt.html
        PlayerPrefs.SetInt("IndexDifficulte", changement.value);
        Debug.Log(changement.value);
    }
}
