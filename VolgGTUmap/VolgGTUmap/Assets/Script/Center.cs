
namespace Assets.Scripts
{
    public class Center
    {
        //public int ID_center { get; set; }

        /// <summary>
        /// Название центра
        /// </summary>
        public string Name_center { get; set; }

        /// <summary>
        /// Ответственный за работу центра
        /// </summary>
        public string HeadOf_center { get; set; }

        /// <summary>
        /// Ссылка на сайт, где можно подробнее узнать о центра
        /// </summary>
      //  public string Link_center { get; set; }

        public Center(string name_center, string headOf_center)
        {
            // Id = id;
            Name_center = name_center;
            HeadOf_center = headOf_center;
        //    Link_center = link_center;
        }
    }
}
