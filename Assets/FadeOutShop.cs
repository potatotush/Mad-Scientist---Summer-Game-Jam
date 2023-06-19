using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutShop : MonoBehaviour
{
    public GameObject shop;
    public Animator shopAnim;

    public void FadeOutShopFunction()
    {
        if (shop.activeInHierarchy)
        {
            shopAnim.SetTrigger("FadeOut");
        }
    }
}
