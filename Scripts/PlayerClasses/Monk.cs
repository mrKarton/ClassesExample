using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartonClassesExample;

public class Monk : PlayerClass
{
    public override void FirstAbility()
    {
        Debug.Log("Monk's first ability");//Полностью другой код способности
    }

    public override void SecondAbility()
    {
        Debug.Log("Monk's second ability");//Полностью другой код способности
    }

    public override void ThirdAbility()
    {
        Debug.Log("Monk's third ability");//Полностью другой код способности
    }
}
