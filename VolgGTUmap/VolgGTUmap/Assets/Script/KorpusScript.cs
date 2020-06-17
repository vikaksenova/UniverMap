using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    /// <summary>
    /// Скрипт для вывода информации о корпусе - кубе
    /// </summary>
    public class KorpusScript : MonoBehaviour
    {
        /// <summary>
        /// Ссылка на объект текстового поля на сцене.
        /// </summary>
        public TextMeshPro CubeText;

        /// <summary>
        /// Идентификатор корпуса в БД, которому соответствует данный куб
        /// </summary>
        public int KorpusId;

        /// <summary>
        /// Функция, вызываемая при запуске сцены
        /// </summary>
        public void OnMouseDown()
        {
            Debug.Log("TEST");
                // Создаем объект БД
            var database = new DBConnection(".\\Assets\\Plugins\\VolgGTUunity.db");

            var korpus = database.GetKorpus(KorpusId);  // Получаем объект корпуса, идентификатор которого задан кубу

            // Задаем текстовуму полю данные из объекта полученного корпуса
            CubeText.text = $"{korpus.Name + "\n"} {"Адрес: " + korpus.Address} {"Телефон: " + korpus.Phone}";
        }
    }
}
