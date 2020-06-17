using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    /// <summary>
    /// Скрипт для вывода информации о кафедре - кубе
    /// </summary>
    public class KafedraScript : MonoBehaviour
    {
        /// <summary>
        /// Ссылка на объект текстового поля на сцене.
        /// </summary>
        public TextMeshPro Cube_Text;

        /// <summary>
        /// Идентификатор кафедры в БД, которому соответствует данный куб
        /// </summary>
        public int KafedraId;

        public void OnMouseDown()
        {
            Debug.Log("TEST");
            // Создаем объект БД
            var database = new DBConnection(".\\Assets\\Plugins\\VolgGTUunity.db");

            var kafedra = database.GetKafedra(KafedraId);  // Получаем объект кафедры, идентификатор которого задан кубу

            // Задаем текстовуму полю данные из объекта полученной кафедры
            Cube_Text.text = $"{kafedra.Name_kafedra + "\n"} {"Заведующий: " + kafedra.HeadOf}";
        }
    }
}
