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
    /// ТЧПлЗаНаД.
    /// </summary>
    // *** Start programmer edit section *** (ТЧПлЗаНаД CustomAttributes)

    // *** End programmer edit section *** (ТЧПлЗаНаД CustomAttributes)
    [AutoAltered()]
    [Caption("Табличная часть плановая заявка на день")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТчПлЗаНаДE", new string[] {
            "СтЗатрат as \'Статья Затрат\'",
            "СпрНомен as \'Номенклатура\'",
            "СпрНомен.Наименование as \'Номенклатура\'",
            "СпрВидыРаб as \'Виды работы\'",
            "СпрВидыРаб.Наименование as \'Виды работы\'",
            "СпрКонтрАг as \'Контрагенты\' on \'Контрагенты\'",
            "СпрКонтрАг.Наименование as \'Контрагенты\'",
            "СпрТранспСр as \'Транспортное средство\'",
            "СпрТранспСр.Наименование as \'Транспортное средство\'",
            "СпрТипТрансСр as \'Типы транспортного средства\'",
            "СпрТипТрансСр.Наименование as \'Типы транспортного средства\'",
            "СпрЕдИзмер as \'Единицы измерения\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'",
            "ОбъемРаботы as \'ОбъемРаботы\'",
            "ВрПрибытия as \'Время Прибытия\'",
            "КолЧасРаб as \'Количество часов работы\'",
            "ОбГруз as \'Объем работы\'"})]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрНомен", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Номенклатура")]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрВидыРаб", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Виды работы")]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрКонтрАг", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Контрагенты")]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрТранспСр", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Транспортное средство")]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрТипТрансСр", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Типы транспортного средства")]
    [MasterViewDefineAttribute("ТчПлЗаНаДE", "СпрЕдИзмер", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Единицы измерения")]
    public class ТЧПлЗаНаД : ICSSoft.STORMNET.DataObject
    {
        
        private string fСтЗатрат;
        
        private string fОбъемРаботы;
        
        private float fОбГруз;
        
        private float fКолЧасРаб;
        
        private string fВрПрибытия;
        
        private System.DateTime fДатПрибыт;
        
        private IIS.Prilozhenie.СпрНомен fСпрНомен;
        
        private IIS.Prilozhenie.СпрТранспСр fСпрТранспСр;
        
        private IIS.Prilozhenie.СпрКонтрАг fСпрКонтрАг;
        
        private IIS.Prilozhenie.СпрТипТрансСр fСпрТипТрансСр;
        
        private IIS.Prilozhenie.СпрВидыРаб fСпрВидыРаб;
        
        private IIS.Prilozhenie.СпрЕдИзмер fСпрЕдИзмер;
        
        private IIS.Prilozhenie.ДокПланЗаНаД fДокПланЗаНаД;
        
        // *** Start programmer edit section *** (ТЧПлЗаНаД CustomMembers)

        // *** End programmer edit section *** (ТЧПлЗаНаД CustomMembers)

        
        /// <summary>
        /// ВрПрибытия.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия CustomAttributes)
        [StrLen(255)]
        public virtual string ВрПрибытия
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Get start)
                string result = this.fВрПрибытия;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Set start)
                this.fВрПрибытия = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ВрПрибытия Set end)
            }
        }
        
        /// <summary>
        /// ДатПрибыт.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт CustomAttributes)
        public virtual System.DateTime ДатПрибыт
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Get start)
                System.DateTime result = this.fДатПрибыт;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Set start)
                this.fДатПрибыт = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДатПрибыт Set end)
            }
        }
        
        /// <summary>
        /// КолЧасРаб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб CustomAttributes)
        public virtual float КолЧасРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Get start)
                float result = this.fКолЧасРаб;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Set start)
                this.fКолЧасРаб = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.КолЧасРаб Set end)
            }
        }
        
        /// <summary>
        /// ОбГруз.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбГруз CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.ОбГруз CustomAttributes)
        public virtual float ОбГруз
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбГруз Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбГруз Get start)
                float result = this.fОбГруз;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбГруз Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбГруз Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбГруз Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбГруз Set start)
                this.fОбГруз = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбГруз Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбГруз Set end)
            }
        }
        
        /// <summary>
        /// ОбъемРаботы.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы CustomAttributes)
        [StrLen(255)]
        public virtual string ОбъемРаботы
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Get start)
                string result = this.fОбъемРаботы;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Set start)
                this.fОбъемРаботы = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ОбъемРаботы Set end)
            }
        }
        
        /// <summary>
        /// СтЗатрат.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СтЗатрат CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СтЗатрат CustomAttributes)
        [StrLen(255)]
        public virtual string СтЗатрат
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Get start)
                string result = this.fСтЗатрат;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Set start)
                this.fСтЗатрат = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СтЗатрат Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрВидыРаб"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрВидыРаб СпрВидыРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Get start)
                IIS.Prilozhenie.СпрВидыРаб result = this.fСпрВидыРаб;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Set start)
                this.fСпрВидыРаб = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрВидыРаб Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрЕдИзмер"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрЕдИзмер СпрЕдИзмер
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Get start)
                IIS.Prilozhenie.СпрЕдИзмер result = this.fСпрЕдИзмер;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Set start)
                this.fСпрЕдИзмер = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрЕдИзмер Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрКонтрАг"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрКонтрАг СпрКонтрАг
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Get start)
                IIS.Prilozhenie.СпрКонтрАг result = this.fСпрКонтрАг;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Set start)
                this.fСпрКонтрАг = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрКонтрАг Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрНомен CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрНомен CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрНомен"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрНомен СпрНомен
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрНомен Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрНомен Get start)
                IIS.Prilozhenie.СпрНомен result = this.fСпрНомен;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрНомен Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрНомен Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрНомен Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрНомен Set start)
                this.fСпрНомен = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрНомен Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрНомен Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрТипТрансСр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрТипТрансСр СпрТипТрансСр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Get start)
                IIS.Prilozhenie.СпрТипТрансСр result = this.fСпрТипТрансСр;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Set start)
                this.fСпрТипТрансСр = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТипТрансСр Set end)
            }
        }
        
        /// <summary>
        /// ТЧПлЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрТранспСр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.СпрТранспСр СпрТранспСр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Get start)
                IIS.Prilozhenie.СпрТранспСр result = this.fСпрТранспСр;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Set start)
                this.fСпрТранспСр = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.СпрТранспСр Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Prilozhenie.ДокПланЗаНаД.
        /// </summary>
        // *** Start programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД CustomAttributes)

        // *** End programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ДокПланЗаНаД"})]
        public virtual IIS.Prilozhenie.ДокПланЗаНаД ДокПланЗаНаД
        {
            get
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Get start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Get start)
                IIS.Prilozhenie.ДокПланЗаНаД result = this.fДокПланЗаНаД;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Get end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Set start)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Set start)
                this.fДокПланЗаНаД = value;
                // *** Start programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Set end)

                // *** End programmer edit section *** (ТЧПлЗаНаД.ДокПланЗаНаД Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТчПлЗаНаДE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТчПлЗаНаДE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТчПлЗаНаДE", typeof(IIS.Prilozhenie.ТЧПлЗаНаД));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ТЧПлЗаНаД.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТЧПлЗаНаД CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТЧПлЗаНаД CustomAttributes)
    public class DetailArrayOfТЧПлЗаНаД : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Prilozhenie.DetailArrayOfТЧПлЗаНаД members)

        // *** End programmer edit section *** (IIS.Prilozhenie.DetailArrayOfТЧПлЗаНаД members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ТЧПлЗаНаД by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ТЧПлЗаНаД.
        /// </summary>
        public DetailArrayOfТЧПлЗаНаД(IIS.Prilozhenie.ДокПланЗаНаД fДокПланЗаНаД) : 
                base(typeof(ТЧПлЗаНаД), ((ICSSoft.STORMNET.DataObject)(fДокПланЗаНаД)))
        {
        }
        
        public IIS.Prilozhenie.ТЧПлЗаНаД this[int index]
        {
            get
            {
                return ((IIS.Prilozhenie.ТЧПлЗаНаД)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Prilozhenie.ТЧПлЗаНаД dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
