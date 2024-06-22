using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject monster; // Ссылка на монстра
    public Transform player;   // Ссылка на игрока
    public float chaseDuration = 5f; // Время, в течение которого монстр будет преследовать игрока

    private MonsterAI monsterAI;

    void Start()
    {
        monsterAI = monster.GetComponent<MonsterAI>();
        if (monsterAI == null)
        {
            Debug.LogError("MonsterAI скрипт не найден на монстре");
        }
        monster.SetActive(false); // Скрываем монстра в начале
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            monsterAI.StartChase(player, chaseDuration);
        }
    }
}