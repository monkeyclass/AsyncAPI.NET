using LEGO.AsyncAPI.Any;
using LEGO.AsyncAPI.Models.Interfaces;
using Newtonsoft.Json.Linq;

namespace LEGO.AsyncAPI;

public class ExtensionDataSetter
{
    public void Setter(object o, string key, object value)
    {
        if (!o.GetType().IsAssignableTo(typeof(IExtensible)))
        {
            return;
        }

        var extensible = o as IExtensible;
        extensible.Extensions ??= new Dictionary<string, IAny>();
        extensible.Extensions.Add(key, IAnyFromJToken.Map(RawObjectToJToken(value)));
    }

    private static JToken RawObjectToJToken(object o)
    {
        if (o == null)
        {
            return JToken.Parse("null");
        }

        if (o.GetType().IsAssignableFrom(typeof(JToken)))
        {
            return (JToken)o;
        }

        if (o.GetType().IsAssignableTo(typeof(string)))
        {
            return JToken.Parse("\"" + o + "\"");
        }

        return JToken.Parse((string.Empty + o).ToLower());
    }
}