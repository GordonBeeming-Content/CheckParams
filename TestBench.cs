using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
  static readonly EndpointRouteFormatter _endpointRouteFormatter = new EndpointRouteFormatter();
  const string EndpointUrlWithOne = "/api/v1/vars/{var1}";
  const string EndpointUrlWithTwo = "/api/v1/vars/{var1}/vars/{var2}";
  const string EndpointUrlWithThree = "/api/v1/vars/{var1}/vars/{var2}/vars/{var3}";
  const string EndpointUrlWithFour = "/api/v1/vars/{var1}/vars/{var2}/vars/{var3}/vars/{var4}";
  const string EndpointUrlWithFive = "/api/v1/vars/{var1}/vars/{var2}/vars/{var3}/vars/{var4}/vars/{var5}";
  const string EndpointUrlWithSix = "/api/v1/vars/{var1}/vars/{var2}/vars/{var3}/vars/{var4}/vars/{var5}/vars/{var6}";

  [Benchmark]
  public string SixRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithSix, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"),
            ("var5", "5"),
            ("var6", "6"));
  }

  [Benchmark]
  public string SixRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithSix, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"),
            ("var5", "5"),
            ("var6", "6"));
  }

  [Benchmark]
  public string FiveRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithFive, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"),
            ("var5", "5"));
  }

  [Benchmark]
  public string FiveRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithFive, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"),
            ("var5", "5"));
  }

  [Benchmark]
  public string FourRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithFour, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"));
  }

  [Benchmark]
  public string FourRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithFour, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"),
            ("var4", "4"));
  }

  [Benchmark]
  public string ThreeRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithThree, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"));
  }

  [Benchmark]
  public string ThreeRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithThree, ("var1", "1"),
            ("var2", "2"),
            ("var3", "3"));
  }

  [Benchmark]
  public string TwoRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithTwo, ("var1", "1"),
            ("var2", "2"));
  }


  [Benchmark]
  public string TwoRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithTwo, ("var1", "1"),
            ("var2", "2"));
  }

  [Benchmark]
  public string OneRouteVarExtended()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariables(EndpointUrlWithOne, ("var1", "1"));
  }

  [Benchmark]
  public string OneRouteVarParamsOnly()
  {
    return _endpointRouteFormatter.FormatEndpointWithRouteVariablesParamsOnly(EndpointUrlWithOne, ("var1", "1"));
  }

}
