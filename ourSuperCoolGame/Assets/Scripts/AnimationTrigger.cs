using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // Переменная для хранения Animator персонажа
    public Animator characterAnimator;
    // Название параметра анимации, который будет запускаться
    public string animationParameter = "IsWalking";

    // Метод, который срабатывает, когда другой объект входит в триггер
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Предполагается, что объект игрока имеет тег "Player"
        {
            characterAnimator.SetBool(animationParameter, true);
        }
    }

    // Метод, который срабатывает, когда другой объект выходит из триггера
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterAnimator.SetBool(animationParameter, false);
        }
    }
}