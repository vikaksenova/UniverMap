namespace Assets.Scripts
{
    /// <summary>
    /// Класс программного объекта кафедры для хранения данных о нем
    /// </summary>
    public class Kafedra 
    {
        /// <summary>
        /// ID кафедры
        /// </summary>
        //public int Id_kafedra { get; set; }

        /// <summary>
        /// Наименование кафедры
        /// </summary>
        public string Name_kafedra { get; set; }

        /// <summary>
        /// Заведующий кафедры
        /// </summary>
        public string HeadOf { get; set; }

        /// <summary>
        /// Ссылка на кафедру
        /// </summary>
       // public string Link_kafedra { get; set; }

        /// <summary>
        /// ID факультета
        /// </summary>
       // public string Faculty_ { get; set; }

        /// <summary>
        /// Создать новый объект кафедры и заполнить его данные
        /// </summary>
        /// <param name="id_kafedra"></param>
        /// <param name="name_kafedra"></param>
        /// <param name="headOf"></param>
        /// <param name="link_kafedra"></param>
        /// <param name="id_faculty_"></param>
        public Kafedra(string name_kafedra, string headOf)
        {
           // Id_kafedra = id_kafedra;
            Name_kafedra = name_kafedra;
            HeadOf = headOf;
           // Link_kafedra = link_kafedra;
           // Faculty_ = faculty_;
        }
    }
}
