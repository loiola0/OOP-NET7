using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{
    /// <summary>
    ///  Create a new Url
    /// </summary>
    /// <param name="address">Address of Url</param>

    public Url(string address)
    {
        Address = address;

        InvalidUrlException.ThrowIfInvalid(address);        
    }

    /// <summary>
    /// Address of the url (web site link)
    /// </summary>
    /// /// 
    public string Address { get;}
}
