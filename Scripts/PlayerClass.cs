using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartonClassesExample
{
    public class PlayerClass : MonoBehaviour // Корневой файл
    {
        public float exampleFloat = 3f;      // Пример объявленной переменной. она будет так же отображаться в инспекторе для всех других классов

        //Примеры объявления дефолтного кода способностей для классов. Они могут быть переписаны 
        public virtual void FirstAbility()
        {
            Debug.Log("Player default first ability");
        }

        public virtual void SecondAbility()
        {
            Debug.Log("Player default second ability");
        }

        public virtual void ThirdAbility()
        {
            Debug.Log("Player default third ability");
        }




    }
}