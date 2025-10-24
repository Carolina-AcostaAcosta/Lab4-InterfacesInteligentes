using System;
using UnityEngine;

public static class EventManager
{
  public static event Action OnCuboTocaTipo1;
  public static event Action OnCuboTocaTipo2;

  public static void CuboTocoTipo1() => OnCuboTocaTipo1?.Invoke();
  public static void CuboTocoTipo2() => OnCuboTocaTipo2?.Invoke();
}
