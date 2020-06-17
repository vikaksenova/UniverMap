using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    public class CenterScript : MonoBehaviour
    {
        public TextMeshPro CubeText;

        public int CenterId;

        public void OnMouseDown()
        {
            Debug.Log("TEST");
            // Создаем объект БД
            var database = new DBConnection(".\\Assets\\Plugins\\VolgGTUunity.db");

            var center = database.GetCenter(CenterId);  // Получаем объект центра, идентификатор которого задан кубу

            // Задаем текстовуму полю данные из объекта полученного корпуса
            CubeText.text = $"{center.Name_center + "\n"} {"Ответственный: " + center.HeadOf_center}";
        }
    }
}
