﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.FlexberryOrmMongoDbDataServiceDemo
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Event.
    /// </summary>
    // *** Start programmer edit section *** (Event CustomAttributes)

    // *** End programmer edit section *** (Event CustomAttributes)
    [PublishName("Event")]
    [ClassStorage("events")]
    [PrimaryKeyStorage("uid")]
    [AutoAltered()]
    [Caption("События")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("EventE", new string[] {
            "Typeid as \'Typeid\'",
            "Photo_id as \'Photo_id\'",
            "Timestamp as \'Timestamp\'",
            "Datetime as \'Datetime\'",
            "Object_id as \'Object_id\'",
            "Camera_direction_id as \'Camera_direction_id\'",
            "Camera_id as \'Camera_id\'",
            "Grz as \'Grz\'",
            "Speed as \'Speed\'",
            "Year as \'Year\'",
            "Month as \'Month\'",
            "Day as \'Day\'",
            "Hour as \'Hour\'",
            "Min as \'Min\'",
            "Sec as \'Sec\'",
            "RegObject as \'Reg object\'",
            "RegObject.Town as \'Town\'",
            "Camera as \'Camera\'",
            "Camera.CameraId as \'Camera id\'"})]
    [View("EventL", new string[] {
            "Typeid as \'Typeid\'",
            "Photo_id as \'Photo_id\'",
            "Timestamp as \'Timestamp\'",
            "Datetime as \'Datetime\'",
            "Object_id as \'Object_id\'",
            "Camera_direction_id as \'Camera_direction_id\'",
            "Camera_id as \'Camera_id\'",
            "Grz as \'Grz\'",
            "Speed as \'Speed\'",
            "Year as \'Year\'",
            "Month as \'Month\'",
            "Day as \'Day\'",
            "Hour as \'Hour\'",
            "Min as \'Min\'",
            "Sec as \'Sec\'",
            "RegObject.Town as \'Town\'",
            "Camera.CameraId as \'Camera id\'"})]
    public class Event : ICSSoft.STORMNET.DataObject
    {
        
        private string fTypeid;
        
        private string fPhoto_id;
        
        private long fTimestamp;
        
        private System.DateTime fDatetime;
        
        private string fObject_id;
        
        private int fCamera_direction_id;
        
        private string fCamera_id;
        
        private string fGrz;
        
        private int fSpeed;
        
        private int fYear;
        
        private int fMonth;
        
        private int fDay;
        
        private int fHour;
        
        private int fMin;
        
        private int fSec;
        
        private NewPlatform.FlexberryOrmMongoDbDataServiceDemo.RegObject fRegObject;
        
        private NewPlatform.FlexberryOrmMongoDbDataServiceDemo.Camera fCamera;
        
        // *** Start programmer edit section *** (Event CustomMembers)

        // *** End programmer edit section *** (Event CustomMembers)

        
        /// <summary>
        /// Typeid.
        /// </summary>
        // *** Start programmer edit section *** (Event.Typeid CustomAttributes)

        // *** End programmer edit section *** (Event.Typeid CustomAttributes)
        [PropertyStorage("typeid")]
        [StrLen(255)]
        public virtual string Typeid
        {
            get
            {
                // *** Start programmer edit section *** (Event.Typeid Get start)

                // *** End programmer edit section *** (Event.Typeid Get start)
                string result = this.fTypeid;
                // *** Start programmer edit section *** (Event.Typeid Get end)

                // *** End programmer edit section *** (Event.Typeid Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Typeid Set start)

                // *** End programmer edit section *** (Event.Typeid Set start)
                this.fTypeid = value;
                // *** Start programmer edit section *** (Event.Typeid Set end)

                // *** End programmer edit section *** (Event.Typeid Set end)
            }
        }
        
        /// <summary>
        /// Photo_id.
        /// </summary>
        // *** Start programmer edit section *** (Event.Photo_id CustomAttributes)

        // *** End programmer edit section *** (Event.Photo_id CustomAttributes)
        [PropertyStorage("photo_id")]
        [StrLen(255)]
        public virtual string Photo_id
        {
            get
            {
                // *** Start programmer edit section *** (Event.Photo_id Get start)

                // *** End programmer edit section *** (Event.Photo_id Get start)
                string result = this.fPhoto_id;
                // *** Start programmer edit section *** (Event.Photo_id Get end)

                // *** End programmer edit section *** (Event.Photo_id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Photo_id Set start)

                // *** End programmer edit section *** (Event.Photo_id Set start)
                this.fPhoto_id = value;
                // *** Start programmer edit section *** (Event.Photo_id Set end)

                // *** End programmer edit section *** (Event.Photo_id Set end)
            }
        }
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        // *** Start programmer edit section *** (Event.Timestamp CustomAttributes)

        // *** End programmer edit section *** (Event.Timestamp CustomAttributes)
        [PropertyStorage("timestamp")]
        public virtual long Timestamp
        {
            get
            {
                // *** Start programmer edit section *** (Event.Timestamp Get start)

                // *** End programmer edit section *** (Event.Timestamp Get start)
                long result = this.fTimestamp;
                // *** Start programmer edit section *** (Event.Timestamp Get end)

                // *** End programmer edit section *** (Event.Timestamp Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Timestamp Set start)

                // *** End programmer edit section *** (Event.Timestamp Set start)
                this.fTimestamp = value;
                // *** Start programmer edit section *** (Event.Timestamp Set end)

                // *** End programmer edit section *** (Event.Timestamp Set end)
            }
        }
        
        /// <summary>
        /// Datetime.
        /// </summary>
        // *** Start programmer edit section *** (Event.Datetime CustomAttributes)

        // *** End programmer edit section *** (Event.Datetime CustomAttributes)
        [PropertyStorage("datetime")]
        public virtual System.DateTime Datetime
        {
            get
            {
                // *** Start programmer edit section *** (Event.Datetime Get start)

                // *** End programmer edit section *** (Event.Datetime Get start)
                System.DateTime result = this.fDatetime;
                // *** Start programmer edit section *** (Event.Datetime Get end)

                // *** End programmer edit section *** (Event.Datetime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Datetime Set start)

                // *** End programmer edit section *** (Event.Datetime Set start)
                this.fDatetime = value;
                // *** Start programmer edit section *** (Event.Datetime Set end)

                // *** End programmer edit section *** (Event.Datetime Set end)
            }
        }
        
        /// <summary>
        /// Object_id.
        /// </summary>
        // *** Start programmer edit section *** (Event.Object_id CustomAttributes)

        // *** End programmer edit section *** (Event.Object_id CustomAttributes)
        [PropertyStorage("object_id")]
        [StrLen(255)]
        public virtual string Object_id
        {
            get
            {
                // *** Start programmer edit section *** (Event.Object_id Get start)

                // *** End programmer edit section *** (Event.Object_id Get start)
                string result = this.fObject_id;
                // *** Start programmer edit section *** (Event.Object_id Get end)

                // *** End programmer edit section *** (Event.Object_id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Object_id Set start)

                // *** End programmer edit section *** (Event.Object_id Set start)
                this.fObject_id = value;
                // *** Start programmer edit section *** (Event.Object_id Set end)

                // *** End programmer edit section *** (Event.Object_id Set end)
            }
        }
        
        /// <summary>
        /// Camera_direction_id.
        /// </summary>
        // *** Start programmer edit section *** (Event.Camera_direction_id CustomAttributes)

        // *** End programmer edit section *** (Event.Camera_direction_id CustomAttributes)
        [PropertyStorage("camera_direction_id")]
        public virtual int Camera_direction_id
        {
            get
            {
                // *** Start programmer edit section *** (Event.Camera_direction_id Get start)

                // *** End programmer edit section *** (Event.Camera_direction_id Get start)
                int result = this.fCamera_direction_id;
                // *** Start programmer edit section *** (Event.Camera_direction_id Get end)

                // *** End programmer edit section *** (Event.Camera_direction_id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Camera_direction_id Set start)

                // *** End programmer edit section *** (Event.Camera_direction_id Set start)
                this.fCamera_direction_id = value;
                // *** Start programmer edit section *** (Event.Camera_direction_id Set end)

                // *** End programmer edit section *** (Event.Camera_direction_id Set end)
            }
        }
        
        /// <summary>
        /// Camera_id.
        /// </summary>
        // *** Start programmer edit section *** (Event.Camera_id CustomAttributes)

        // *** End programmer edit section *** (Event.Camera_id CustomAttributes)
        [PropertyStorage("camera_id")]
        [StrLen(255)]
        public virtual string Camera_id
        {
            get
            {
                // *** Start programmer edit section *** (Event.Camera_id Get start)

                // *** End programmer edit section *** (Event.Camera_id Get start)
                string result = this.fCamera_id;
                // *** Start programmer edit section *** (Event.Camera_id Get end)

                // *** End programmer edit section *** (Event.Camera_id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Camera_id Set start)

                // *** End programmer edit section *** (Event.Camera_id Set start)
                this.fCamera_id = value;
                // *** Start programmer edit section *** (Event.Camera_id Set end)

                // *** End programmer edit section *** (Event.Camera_id Set end)
            }
        }
        
        /// <summary>
        /// Grz.
        /// </summary>
        // *** Start programmer edit section *** (Event.Grz CustomAttributes)

        // *** End programmer edit section *** (Event.Grz CustomAttributes)
        [PropertyStorage("grz")]
        [StrLen(255)]
        public virtual string Grz
        {
            get
            {
                // *** Start programmer edit section *** (Event.Grz Get start)

                // *** End programmer edit section *** (Event.Grz Get start)
                string result = this.fGrz;
                // *** Start programmer edit section *** (Event.Grz Get end)

                // *** End programmer edit section *** (Event.Grz Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Grz Set start)

                // *** End programmer edit section *** (Event.Grz Set start)
                this.fGrz = value;
                // *** Start programmer edit section *** (Event.Grz Set end)

                // *** End programmer edit section *** (Event.Grz Set end)
            }
        }
        
        /// <summary>
        /// Speed.
        /// </summary>
        // *** Start programmer edit section *** (Event.Speed CustomAttributes)

        // *** End programmer edit section *** (Event.Speed CustomAttributes)
        [PropertyStorage("speed")]
        public virtual int Speed
        {
            get
            {
                // *** Start programmer edit section *** (Event.Speed Get start)

                // *** End programmer edit section *** (Event.Speed Get start)
                int result = this.fSpeed;
                // *** Start programmer edit section *** (Event.Speed Get end)

                // *** End programmer edit section *** (Event.Speed Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Speed Set start)

                // *** End programmer edit section *** (Event.Speed Set start)
                this.fSpeed = value;
                // *** Start programmer edit section *** (Event.Speed Set end)

                // *** End programmer edit section *** (Event.Speed Set end)
            }
        }
        
        /// <summary>
        /// Year.
        /// </summary>
        // *** Start programmer edit section *** (Event.Year CustomAttributes)

        // *** End programmer edit section *** (Event.Year CustomAttributes)
        [PropertyStorage("year")]
        public virtual int Year
        {
            get
            {
                // *** Start programmer edit section *** (Event.Year Get start)

                // *** End programmer edit section *** (Event.Year Get start)
                int result = this.fYear;
                // *** Start programmer edit section *** (Event.Year Get end)

                // *** End programmer edit section *** (Event.Year Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Year Set start)

                // *** End programmer edit section *** (Event.Year Set start)
                this.fYear = value;
                // *** Start programmer edit section *** (Event.Year Set end)

                // *** End programmer edit section *** (Event.Year Set end)
            }
        }
        
        /// <summary>
        /// Month.
        /// </summary>
        // *** Start programmer edit section *** (Event.Month CustomAttributes)

        // *** End programmer edit section *** (Event.Month CustomAttributes)
        [PropertyStorage("month")]
        public virtual int Month
        {
            get
            {
                // *** Start programmer edit section *** (Event.Month Get start)

                // *** End programmer edit section *** (Event.Month Get start)
                int result = this.fMonth;
                // *** Start programmer edit section *** (Event.Month Get end)

                // *** End programmer edit section *** (Event.Month Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Month Set start)

                // *** End programmer edit section *** (Event.Month Set start)
                this.fMonth = value;
                // *** Start programmer edit section *** (Event.Month Set end)

                // *** End programmer edit section *** (Event.Month Set end)
            }
        }
        
        /// <summary>
        /// Day.
        /// </summary>
        // *** Start programmer edit section *** (Event.Day CustomAttributes)

        // *** End programmer edit section *** (Event.Day CustomAttributes)
        [PropertyStorage("day")]
        public virtual int Day
        {
            get
            {
                // *** Start programmer edit section *** (Event.Day Get start)

                // *** End programmer edit section *** (Event.Day Get start)
                int result = this.fDay;
                // *** Start programmer edit section *** (Event.Day Get end)

                // *** End programmer edit section *** (Event.Day Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Day Set start)

                // *** End programmer edit section *** (Event.Day Set start)
                this.fDay = value;
                // *** Start programmer edit section *** (Event.Day Set end)

                // *** End programmer edit section *** (Event.Day Set end)
            }
        }
        
        /// <summary>
        /// Hour.
        /// </summary>
        // *** Start programmer edit section *** (Event.Hour CustomAttributes)

        // *** End programmer edit section *** (Event.Hour CustomAttributes)
        [PropertyStorage("hour")]
        public virtual int Hour
        {
            get
            {
                // *** Start programmer edit section *** (Event.Hour Get start)

                // *** End programmer edit section *** (Event.Hour Get start)
                int result = this.fHour;
                // *** Start programmer edit section *** (Event.Hour Get end)

                // *** End programmer edit section *** (Event.Hour Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Hour Set start)

                // *** End programmer edit section *** (Event.Hour Set start)
                this.fHour = value;
                // *** Start programmer edit section *** (Event.Hour Set end)

                // *** End programmer edit section *** (Event.Hour Set end)
            }
        }
        
        /// <summary>
        /// Min.
        /// </summary>
        // *** Start programmer edit section *** (Event.Min CustomAttributes)

        // *** End programmer edit section *** (Event.Min CustomAttributes)
        [PropertyStorage("min")]
        public virtual int Min
        {
            get
            {
                // *** Start programmer edit section *** (Event.Min Get start)

                // *** End programmer edit section *** (Event.Min Get start)
                int result = this.fMin;
                // *** Start programmer edit section *** (Event.Min Get end)

                // *** End programmer edit section *** (Event.Min Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Min Set start)

                // *** End programmer edit section *** (Event.Min Set start)
                this.fMin = value;
                // *** Start programmer edit section *** (Event.Min Set end)

                // *** End programmer edit section *** (Event.Min Set end)
            }
        }
        
        /// <summary>
        /// Sec.
        /// </summary>
        // *** Start programmer edit section *** (Event.Sec CustomAttributes)

        // *** End programmer edit section *** (Event.Sec CustomAttributes)
        [PropertyStorage("sec")]
        public virtual int Sec
        {
            get
            {
                // *** Start programmer edit section *** (Event.Sec Get start)

                // *** End programmer edit section *** (Event.Sec Get start)
                int result = this.fSec;
                // *** Start programmer edit section *** (Event.Sec Get end)

                // *** End programmer edit section *** (Event.Sec Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Sec Set start)

                // *** End programmer edit section *** (Event.Sec Set start)
                this.fSec = value;
                // *** Start programmer edit section *** (Event.Sec Set end)

                // *** End programmer edit section *** (Event.Sec Set end)
            }
        }
        
        /// <summary>
        /// Event.
        /// </summary>
        // *** Start programmer edit section *** (Event.RegObject CustomAttributes)

        // *** End programmer edit section *** (Event.RegObject CustomAttributes)
        [PropertyStorage(new string[] {
                "object_uid"})]
        public virtual NewPlatform.FlexberryOrmMongoDbDataServiceDemo.RegObject RegObject
        {
            get
            {
                // *** Start programmer edit section *** (Event.RegObject Get start)

                // *** End programmer edit section *** (Event.RegObject Get start)
                NewPlatform.FlexberryOrmMongoDbDataServiceDemo.RegObject result = this.fRegObject;
                // *** Start programmer edit section *** (Event.RegObject Get end)

                // *** End programmer edit section *** (Event.RegObject Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.RegObject Set start)

                // *** End programmer edit section *** (Event.RegObject Set start)
                this.fRegObject = value;
                // *** Start programmer edit section *** (Event.RegObject Set end)

                // *** End programmer edit section *** (Event.RegObject Set end)
            }
        }
        
        /// <summary>
        /// Event.
        /// </summary>
        // *** Start programmer edit section *** (Event.Camera CustomAttributes)

        // *** End programmer edit section *** (Event.Camera CustomAttributes)
        [PropertyStorage(new string[] {
                "camera_uid"})]
        public virtual NewPlatform.FlexberryOrmMongoDbDataServiceDemo.Camera Camera
        {
            get
            {
                // *** Start programmer edit section *** (Event.Camera Get start)

                // *** End programmer edit section *** (Event.Camera Get start)
                NewPlatform.FlexberryOrmMongoDbDataServiceDemo.Camera result = this.fCamera;
                // *** Start programmer edit section *** (Event.Camera Get end)

                // *** End programmer edit section *** (Event.Camera Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Camera Set start)

                // *** End programmer edit section *** (Event.Camera Set start)
                this.fCamera = value;
                // *** Start programmer edit section *** (Event.Camera Set end)

                // *** End programmer edit section *** (Event.Camera Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "EventE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EventE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EventE", typeof(NewPlatform.FlexberryOrmMongoDbDataServiceDemo.Event));
                }
            }
            
            /// <summary>
            /// "EventL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EventL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EventL", typeof(NewPlatform.FlexberryOrmMongoDbDataServiceDemo.Event));
                }
            }
        }
    }
}
