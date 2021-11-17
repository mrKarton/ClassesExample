using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartonClassesExample;

public class Knight : PlayerClass
{
    public override void FirstAbility()
    {
        base.FirstAbility();                    //вызовет дефолтную функцию 

        Debug.Log("Knights's first ability");   //и добавит своё
    }

    // отсутствие SecondAbility Тоже будет ссылкать на дефолтную функцию

    public override void ThirdAbility()
    {
        Debug.Log("Knights's third ability");   //Полностью другой код способности
    }
}
