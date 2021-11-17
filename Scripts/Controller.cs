using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartonClassesExample
{
    public class Controller : MonoBehaviour
    {
        private PlayerClass playerClass;    // !!!ТИП КОРНЕВОГО КЛАССА!!! 
        public SelectedClass selectedClass;

        public GameObject player;

        private void Awake() // Вызывается как только сцена загрузилась. До Start и Update.
        {                       // Сейчас нужна чисто теоретически что бы в других скриптах в Start() можно было получить класс игрока
            switch (selectedClass)
            {
                case SelectedClass.Knight:
                    playerClass = player.GetComponent<Knight>(); //Так как Knight наследуется от PlayerClass. Мы можем это записать в PlayerClass
                    break;                                             //И после так же вызывать функции и т.д.

                case SelectedClass.Wizzard:
                    playerClass = player.GetComponent<Wizzard>();//далее так же
                    break;

                default:
                    playerClass = player.GetComponent<Monk>();
                    break;
            }

            Debug.Log($"Selected {playerClass.GetType()}");
        }

        //далее - функции для кнопок. Вызывают классовые способности в зависимости от класса, который мы указали в инспекторе
        public void UseFirstAbility()
        {
            playerClass.FirstAbility(); //как видим, можно так же использовать. При этом выполнится код, который мы просписали в Wizzart/Knight/Monk
        }

        public void UseSecondAbility()
        {
            playerClass.SecondAbility();
        }

        public void UseThirdAbility()
        {
            playerClass.ThirdAbility();
        }
    }

    public enum SelectedClass //просто список для легкого выбора класса в инспекторе ¯\_(ツ)_/¯
    {
        Wizzard, Knight, Monk
    }
}