﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Prilozhenie
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Док план за на Д.
    /// </summary>
    // *** Start programmer edit section *** (ДокПланЗаНаД CustomAttributes)

    // *** End programmer edit section *** (ДокПланЗаНаД CustomAttributes)
    [AutoAltered()]
    [Caption("Документ плановая заявка на день")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокПланЗаНаДE", new string[] {
            "Номер as \'Номер\'",
            "Дата as \'Дата\'",
            "Время as \'Время\'",
            "СпрКонтрАг as \'Организация\'",
            "СпрКонтрАг.Наименование as \'Организация\'",
            "СпрОбъектСтр as \'Объект строительства\'",
            "СпрОбъектСтр.Наименование as \'Объект строительства\'",
            "СпрПользов as \'Автор\'",
            "СпрПользов.ФИО as \'Автор\'"})]
    [View("ДокПланЗаНаДL", new string[] {
            "Номер as \'Номер\'",
            "Дата as \'Дата\'",
            "Время as \'Время\'",
            "СпрКонтрАг.Наименование as \'Организация\'",
            "СпрОбъектСтр.Наименование as \'Объект строительства\'",
            "СпрПользов.ФИО as \'Автор\'"})]
    public class ДокПланЗаНаД : ICSSoft.STORMNET.DataObject
    {
        
        private string fВремя;
        
        private int fНомер;
        
        private System.DateTime fДата;
        
        private IIS.Prilozhenie.СпрПользов fСпрПользов;
        
        private IIS.Prilozhenie.СпрОбъектСтр fСпрОбъектСтр;
        
        private IIS.Prilozhenie.СпрКонтрАг fСпрКонтрАг;
        
        // *** Start programmer edit section *** (ДокПланЗаНаД CustomMembers)

        // *** End programmer edit section *** (ДокПланЗаНаД CustomMembers)

        
        /// <summary>
        /// Время.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.Время CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.Время CustomAttributes)
        [StrLen(255)]
        public virtual string Время
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Время Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Время Get start)
                string result = this.fВремя;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Время Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Время Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Время Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Время Set start)
                this.fВремя = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Время Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Время Set end)
            }
        }
        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.Дата CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Дата Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Дата Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Дата Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Дата Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Дата Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.Номер CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Номер Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Номер Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.Номер Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.Номер Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.Номер Set end)
            }
        }
        
        /// <summary>
        /// Док план за на Д.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрКонтрАг"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрКонтрАг СпрКонтрАг
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Get start)
                IIS.Prilozhenie.СпрКонтрАг result = this.fСпрКонтрАг;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Set start)
                this.fСпрКонтрАг = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрКонтрАг Set end)
            }
        }
        
        /// <summary>
        /// Док план за на Д.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрОбъектСтр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрОбъектСтр СпрОбъектСтр
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Get start)
                IIS.Prilozhenie.СпрОбъектСтр result = this.fСпрОбъектСтр;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Set start)
                this.fСпрОбъектСтр = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрОбъектСтр Set end)
            }
        }
        
        /// <summary>
        /// Док план за на Д.
        /// </summary>
        // *** Start programmer edit section *** (ДокПланЗаНаД.СпрПользов CustomAttributes)

        // *** End programmer edit section *** (ДокПланЗаНаД.СпрПользов CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрПользов"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрПользов СпрПользов
        {
            get
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрПользов Get start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрПользов Get start)
                IIS.Prilozhenie.СпрПользов result = this.fСпрПользов;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрПользов Get end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрПользов Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрПользов Set start)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрПользов Set start)
                this.fСпрПользов = value;
                // *** Start programmer edit section *** (ДокПланЗаНаД.СпрПользов Set end)

                // *** End programmer edit section *** (ДокПланЗаНаД.СпрПользов Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокПланЗаНаДE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокПланЗаНаДE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокПланЗаНаДE", typeof(IIS.Prilozhenie.ДокПланЗаНаД));
                }
            }
            
            /// <summary>
            /// "ДокПланЗаНаДL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокПланЗаНаДL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокПланЗаНаДL", typeof(IIS.Prilozhenie.ДокПланЗаНаД));
                }
            }
        }
    }
}
