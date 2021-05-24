using System;

namespace AartCamperinbouwAPI.Routes
{
    public static class V1
    {
        public const String Base = "/v1/";

        public static class General 
        {
            public const String Contact = Base + "Contact/";
            public const String Info = Base + "Info/";
        }

        public static class Campers
        {
            public const String GetCampers = Base + "Campers/";
            public const String GetCamper = Base + "Campers/{id}";
            public const String CreateCamper = Base + "Campers/";
            public const String EditCamper = Base + "Campers/{id}";
            public const String DeleteCamper = Base + "Campers/{id}";
        }
    }
}