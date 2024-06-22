using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public float speed = 3.0f; // Скорость преследования
    private Transform target;
    private bool isChasing = false;
    private float chaseTime;
    private float chaseStartTime;

    void Update()
    {
        if (isChasing)
        {
            ChaseTarget();
            
            if (Time.time - chaseStartTime >= chaseTime || Vector3.Distance(new Vector3(transform.position.x, 0, transform.position.z), new Vector3(target.position.x, 0, target.position.z)) <= 1.0f)
            {
                StopChase();
            }
        }
    }

    public void StartChase(Transform newTarget, float duration)
    {
        target = newTarget;
        chaseTime = duration;
        chaseStartTime = Time.time;
        isChasing = true;
        gameObject.SetActive(true); // Делаем монстра видимым
    }

    private void ChaseTarget()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            direction.y = 0; // Игнорируем направление по оси Y
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    private void StopChase()
    {
        isChasing = false;
        gameObject.SetActive(false); // Скрываем монстра
        // или
        // Destroy(gameObject); // Если нужно уничтожить монстра
    }
}