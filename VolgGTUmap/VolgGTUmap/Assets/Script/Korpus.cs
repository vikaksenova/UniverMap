namespace Assets.Scripts
{
    /// <summary>
    /// Класс программного объекта корпуса для хранения данных о нем.
    /// </summary>
    public class Korpus
    {
        /// <summary>
        /// Id корпуса.
        /// </summary>
        
        //public int Id { get; set; }

        /// <summary>
        /// Наименование корпуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес корпуса.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефон корпуса.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Создать новый объект корпуса и заполнить его данные.
        /// </summary>
        /// <param name="id">Id корпуса.</param>
        /// <param name="name">Наименование корпуса</param>
        /// <param name="address">Адрес корпуса.</param>
        /// <param name="phone">Телефон корпуса.</param>
        public Korpus(string name, string address, string phone)
        {
           // Id = id;
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
