using System;

public class soma
{

  int[] dindin = new int[20];
  int soma1;

  public void valor(int v1, int cont)
  {
   dindin[cont] = v1;
  }

  public void somatorio(int v1)
  {
    soma1 += v1;
  }

  public int getDindin(int cont)
  {
    return dindin[cont];
  }

  public int getSoma()
  {
    return soma1;
  }
}