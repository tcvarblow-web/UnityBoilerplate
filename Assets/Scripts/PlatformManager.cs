using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    int coins = 0;

    public void CollectCoin()
    {
        coins++;
    }
   public int getCoins()
    {
        return coins;
    }
}
