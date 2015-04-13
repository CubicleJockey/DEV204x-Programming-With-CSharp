using System;

namespace ModuleFourAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        #region Structs

        /// <summary>
        /// I am using properties even though the assignment says not to.
        /// Here's why:
        /// 
        /// 1. To educate, I believe the teacher didn't say to use properties because there 
        ///    is a trick to getting a struct to work with Auto Properites.
        ///         1. if you create a struct without this trick you will get this error messsage 
        ///            "The 'this' object cannot be used before all of its fields are assigned to"
        ///         2. You get this message because the "backing property" for the auto property must be
        ///            initialized before the constructor tries to use it. Chicken in the egg problem right?
        ///         3. There are things known as default constructors for every object Value Type (struct) or Reference Type(class)
        ///            To invoke the default constructor for a struct before YOUR paramertized Constructor you need to do this
        ///                 i. public Student(some parameters) : this(), the key here is triggering the default constructor with : this()
        ///
        /// Hope this information was helpfult to whoever grades this
        ///         
        /// </summary>
        public struct Student
        {
            #region Members

            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public DateTime Birthday { get; private set; }
            public string Address { get; private set; }
            public string Address1 { get; private set; }
            public string City { get; private set; }
            public State State { get; private set; }
            public string Zip { get; private set; }
            public Country Country { get; private set; }
            public string Notes { get; private set; }

            #endregion Members

            public Student(string fName, string lName, DateTime bDay, string address, string address1, 
                           string city, State state, string zip, Country country, string notes) : this()
            {
                FirstName = fName;
                LastName = lName;
                Birthday = bDay;
                Address = address;
                Address1 = address1;
                City = city;
                State = state;
                Zip = zip;
                Country = country;
                Notes = notes;
            }
        }


        #endregion Structs

        #region Enums

        public enum State
        {
            AL,
            AK,
            AZ,
            AR,
            CA,
            CO,
            CT,
            DE,
            FL,
            GA,
            HI,
            ID,
            IL,
            IN,
            IA,
            KS,
            KY,
            LA,
            ME,
            MD,
            MA,
            MI,
            MN,
            MS,
            MO,
            MT,
            NE,
            NV,
            NH,
            NJ,
            NM,
            NY,
            NC,
            ND,
            OH,
            OK,
            OR,
            PA,
            RI,
            SC,
            SD,
            TN,
            TX,
            UT,
            VT,
            VA,
            WA,
            WV,
            WI,
            WY,
            NonUS
        }

        public enum Country
        {
            AFG,
            ALB,
            DZA,
            ASM,
            AND,
            AGO,
            AIA,
            ATA,
            ATG,
            ARG,
            ARM,
            ABW,
            AUS,
            AUT,
            AZE,
            BHS,
            BHR,
            BGD,
            BRB,
            BLR,
            BEL,
            BLZ,
            BEN,
            BMU,
            BTN,
            BOL,
            BIH,
            BWA,
            BVT,
            BRA,
            IOT,
            BRN,
            BGR,
            BFA,
            BDI,
            KHM,
            CMR,
            CAN,
            CPV,
            CYM,
            CAF,
            TCD,
            CHL,
            CHN,
            CXR,
            CCK,
            COL,
            COM,
            COG,
            COD,
            COK,
            CRI,
            CIV,
            HRV,
            CUB,
            CYP,
            CZE,
            DNK,
            DJI,
            DMA,
            DOM,
            TMP,
            ECU,
            EGY,
            SLV,
            GNQ,
            ERI,
            EST,
            ETH,
            FLK,
            FRO,
            FJI,
            FIN,
            FRA,
            FXX,
            GUF,
            PYF,
            ATF,
            GAB,
            GMB,
            GEO,
            DEU,
            GHA,
            GIB,
            GRC,
            GRL,
            GRD,
            GLP,
            GUM,
            GTM,
            GIN,
            GNB,
            GUY,
            HTI,
            HMD,
            VAT,
            HND,
            HKG,
            HUN,
            ISL,
            IND,
            IDN,
            IRN,
            IRQ,
            IRL,
            ISR,
            ITA,
            JAM,
            JPN,
            JOR,
            KAZ,
            KEN,
            KIR,
            PRK,
            KOR,
            KWT,
            KGZ,
            LAO,
            LVA,
            LBN,
            LSO,
            LBR,
            LBY,
            LIE,
            LTU,
            LUX,
            MAC,
            MKD,
            MDG,
            MWI,
            MYS,
            MDV,
            MLI,
            MLT,
            MHL,
            MTQ,
            MRT,
            MUS,
            MYT,
            MEX,
            FSM,
            MDA,
            MCO,
            MNG,
            MNE,
            MSR,
            MAR,
            MOZ,
            MMR,
            NAM,
            NRU,
            NPL,
            NLD,
            ANT,
            NCL,
            NZL,
            NIC,
            NER,
            NGA,
            NIU,
            NFK,
            MNP,
            NOR,
            OMN,
            PAK,
            PLW,
            PAN,
            PNG,
            PRY,
            PER,
            PHL,
            PCN,
            POL,
            PRT,
            PRI,
            QAT,
            REU,
            ROM,
            RUS,
            RWA,
            KNA,
            LCA,
            VCT,
            WSM,
            SMR,
            STP,
            SAU,
            SEN,
            SRB,
            SYC,
            SLE,
            SGP,
            SVK,
            SVN,
            SLB,
            SOM,
            ZAF,
            SSD,
            SGS,
            ESP,
            LKA,
            SHN,
            SPM,
            SDN,
            SUR,
            SJM,
            SWZ,
            SWE,
            CHE,
            SYR,
            TWN,
            TJK,
            TZA,
            THA,
            TGO,
            TKL,
            TON,
            TTO,
            TUN,
            TUR,
            TKM,
            TCA,
            TUV,
            UGA,
            UKR,
            ARE,
            GBR,
            USA,
            UMI,
            URY,
            UZB,
            VUT,
            VEN,
            VNM,
            VGB,
            VIR,
            WLF,
            ESH,
            YEM,
            ZMB,
            ZWE
        }

        #endregion Enums
    }
}
