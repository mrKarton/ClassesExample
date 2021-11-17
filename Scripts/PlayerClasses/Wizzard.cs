using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartonClassesExample;

public class Wizzard : PlayerClass //класс наследуется от корневого
{
    public override void FirstAbility()
    {
        base.FirstAbility();       //вызовет дефолтную функцию 
    }

    // отсутствие SecondAbility Тоже будет ссылкать на дефолтную функцию

    public override void ThirdAbility()
    {
        Debug.Log("Wizzard's third ability");//Полностью другой код способности
    }
}
