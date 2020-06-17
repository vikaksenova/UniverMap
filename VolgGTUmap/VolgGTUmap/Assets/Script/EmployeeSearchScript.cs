using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Scripts
{
    public class EmployeeSearchScript : MonoBehaviour
    {
        public InputField field;
        public GameObject textDisplay;

        public void GetResult()
        {
            var database1 = new DBConnection(".\\Assets\\Plugins\\VolgGTUunity.db");
            var employee = database1.GetResultSearch(field.text);
            textDisplay.GetComponent<Text>().text = $"{"ФИО:" + employee.FullName + "\n"} {"Должность: " + employee.Position + "\n"} {"Ссылка: " + employee.Link + "\n"} {"Аудитория: " + employee.Audience}";
        }
    }
}
