using UnityEngine;

public class EtatAttenteCommande : EtatClient
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
