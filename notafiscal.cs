using System;

public class notafiscal
{
  string[] nota1 = new string[20];

  public void nome(string i1, int cont)
  {
    nota1[cont] = i1;
  }

  public string getNota(int cont)
  {
    return nota1[cont];
  }
}