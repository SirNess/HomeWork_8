using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public record struct People
    {
        /*ФИО
        Улица
        Номер дома
        Номер квартиры
        Мобильный телефон
        Домашний телефон    
     */
        #region Свойства
        public string Name { get; set ; }
        public string Street { get; set; }
        public string Numberhome { get; set; }
        public string Numberflat { get; set; }
        public string Mobilephone { get; set; }
        public string Homephone { get; set; }
        #endregion
        #region Конструктор
        public People(string Name, string Street, string Numberhome, string Numberflat, string Mobilephone, string Homephone)
        {
            this.Name = Name;
            this.Street = Street;
            this.Numberhome = Numberhome;
            this.Numberflat = Numberflat;
            this.Mobilephone = Mobilephone;
            this.Homephone = Homephone;
        }
        #endregion
       

    }
}
