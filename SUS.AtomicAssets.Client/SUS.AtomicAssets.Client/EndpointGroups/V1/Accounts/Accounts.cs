namespace SUS.AtomicAssets.Client.EndpointGroups.V1.Accounts
{
    public class Accounts
{
    private string _endpoint;
    internal Accounts(string endpoint)
    {
        _endpoint = $"{endpoint}/v1/accounts";
    }
    public AllAccounts Get()
    {
        return new AllAccounts(_endpoint);
    }
    public SingleAccount Get(string wallet)
    {
        return new SingleAccount(_endpoint, wallet);
    }
}
}