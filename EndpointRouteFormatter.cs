using System.Text;

public class EndpointRouteFormatter
{
  public string FormatEndpointWithRouteVariables(string endpointUrl, Dictionary<string, string> routeVariables)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    foreach (var routeVariable in routeVariables)
    {
      formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariable.Key}}}", routeVariable.Value);
    }

    return formattedEndpoint.ToString();
  }

  public string FormatEndpointWithRouteVariablesConvertToDictionary(string endpointUrl, params (string Key, object Value)[] routeVariables)
  {
    var routeVariablesDictionary = routeVariables.ToDictionary(
            routeVariable => routeVariable.Key,
            routeVariable => routeVariable.Value.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));

    return FormatEndpointWithRouteVariables(endpointUrl, routeVariablesDictionary);
  }

  public string FormatEndpointWithRouteVariables(string endpointUrl, (string Key, object Value) routeVariables1)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables1.Key}}}",
        routeVariables1.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));

    return formattedEndpoint.ToString();
  }

  public string FormatEndpointWithRouteVariables(string endpointUrl, (string Key, object Value) routeVariables1, (string Key, object Value) routeVariables2)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables1.Key}}}",
        routeVariables1.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables2.Key}}}",
        routeVariables2.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));

    return formattedEndpoint.ToString();
  }

  public string FormatEndpointWithRouteVariables(string endpointUrl, (string Key, object Value) routeVariables1, (string Key, object Value) routeVariables2,
      (string Key, object Value) routeVariables3)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables1.Key}}}",
        routeVariables1.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables2.Key}}}",
        routeVariables2.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables3.Key}}}",
        routeVariables3.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));

    return formattedEndpoint.ToString();
  }

  public string FormatEndpointWithRouteVariables(string endpointUrl, (string Key, object Value) routeVariables1, (string Key, object Value) routeVariables2,
      (string Key, object Value) routeVariables3, params (string Key, object Value)[] routeVariables)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables1.Key}}}",
        routeVariables1.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables2.Key}}}",
        routeVariables2.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariables3.Key}}}",
        routeVariables3.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    foreach (var routeVariable in routeVariables)
    {
      formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariable.Key}}}",
          routeVariable.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    }

    return formattedEndpoint.ToString();
  }

  public string FormatEndpointWithRouteVariablesParamsOnly(string endpointUrl, params (string Key, object Value)[] routeVariables)
  {
    var formattedEndpoint = new StringBuilder(endpointUrl);
    foreach (var routeVariable in routeVariables)
    {
      formattedEndpoint = formattedEndpoint.Replace($"{{{routeVariable.Key}}}",
          routeVariable.Value?.ToString() ?? throw new ArgumentException("Route parameter cannot be null"));
    }

    return formattedEndpoint.ToString();
  }
}
