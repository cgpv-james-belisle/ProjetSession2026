using UnityEngine;

public class EtatAttenteFile : EtatClient
{
    public override void OnEntrer(Client client)
    {

    }
    public override EtatClient OnExecuter(Client client)
    {
        return this;
    }

    public override void OnSortir(Client client)
    {

    }
}
