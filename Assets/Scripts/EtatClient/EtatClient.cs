using UnityEngine;

public class EtatClient : MonoBehaviour
{
    public virtual void OnEntrer(Client client)
    {

    }
    public virtual EtatClient OnExecuter(Client client)
    {
        return this;
    }

    public virtual void OnSortir(Client client)
    {

    }
}
