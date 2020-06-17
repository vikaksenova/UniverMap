using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    CharacterController MyPownBody;
    public float speed = 6.0F;
    Vector3 moveDirection = Vector3.zero;           // пустой вектор направления персонажа (0,0,0)
    // Start is called before the first frame update
    void Start()
    {
        MyPownBody = this.GetComponent<CharacterController>();     //получение компонента, отвечающего за движение
    }

    // Update is called once per frame
    void Update()
    {
        // если есть компонент, то будем что-то делать, иначе ничего не делаем
        if (MyPownBody != null)
        {
            float AD = Input.GetAxis("Horizontal");     // команды по горизонтали
            float WS = Input.GetAxis("Vertical");       // команды по вертикали

            moveDirection = new Vector3(AD, 0, WS);     // задаем новое направление, куда можно двинаться
            moveDirection = transform.TransformDirection(moveDirection);    //преобразуем вектор движения в направление движения
            moveDirection *= speed;                     // задаем скорость движения 

            MyPownBody.Move(moveDirection * Time.deltaTime);    //двигаем тело в указанном направлении
        }

    }
}
