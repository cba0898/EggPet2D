using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public Animator petAnimator;

    void Awake()
    {

    }

    public void Happy()
    {
        petAnimator.SetTrigger("Happy");
    }
    public void Hungry()
    {
        petAnimator.SetTrigger("Hungry");
    }
    public void Sad()
    {
        petAnimator.SetTrigger("Sad");
    }
    public void Tired()
    {
        petAnimator.SetTrigger("Tired");
    }
    public void Eat()
    {
        petAnimator.SetTrigger("Eat");
    }
}
