
using System;

namespace Strategy.Services
{
  public class SmsService : IService
  {
    private SmsService(){}

    #region Métodos de instancia
    public void Enviar<T>(T obj)
    {
      Console.WriteLine($"Enviando SMS do tipo {obj.GetType().Name}");
    }
    public void Fechar()
    {
      entidadeSmsService = null;
    }
    #endregion

    private static SmsService entidadeSmsService;
    private static object entidadeDbService;

    public static SmsService Instancia()
    {
      if(entidadeSmsService == null) entidadeSmsService = new SmsService();
      return entidadeSmsService;
    }
  }
}