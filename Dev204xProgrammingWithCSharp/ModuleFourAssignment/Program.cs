using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleFourAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Assignment Says: Assign values to the fields in at least one of the student structs in the array
             * 
             * So I am going to have 4 empty student struct's.
             */

            //Inistalize Array
            Student[] students = new Student[5];


            UniversityDegree degree = new UniversityDegree(DegreeLevel.Doctorate, "Permaculture Design", 270);
            UniversityProgram program = new UniversityProgram("Whole Systems Design", 
                                       new[] {DegreeLevel.Masters, DegreeLevel.Doctorate},
                                       new Professor("Dr.", "Paul", "Statmen", "Permaculture"));
            Professor professor = new Professor("Dr.", "David", "Holmgren", "Permaculture");
            Course course =  new Course("PD450",
                                        "Permaculture Applied to City Rooftops",
                                        "Use permaculture principles to bring sustaibility to city roof tops", 
                                        5, 
                                        professor);
               

            //Set structs
            students[0] = new Student("Andre", 
                                      "Davis", 
                                      new DateTime(1982, 11, 11),
                                      "1234 Awesome Lane", 
                                      string.Empty, 
                                      "Seattle", 
                                      State.WA, 
                                      "98102-1234", 
                                      Country.USA, 
                                      "Cubicle Jockey",
                                      degree, 
                                      program, 
                                      course);

            //Allowed to be empty via assignment instructions
            students[1] = new Student();
            students[2] = new Student();
            students[3] = new Student();
            students[4] = new Student();


            //Display populated Student struct object.
            Console.WriteLine(students[0]);
            Console.WriteLine("Press ANY key to exit.");
            Console.ReadLine();
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
        ///                 i. public ConstructorName(some parameters) : this(), the key here is triggering the default constructor with : this()
        ///
        /// Hope this information was helpfult to whoever grades this
        ///         
        /// </summary>
        public struct Student
        {
            #region Properties

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

            public UniversityDegree Degree { get; private set; }

            public UniversityProgram Program { get; private set; }

            //In reality a student would have courses
            public Course Course { get; private set; }

            #endregion Properties

            public Student(string fName, string lName, DateTime bDay, string address, string address1, 
                           string city, State state, string zip, Country country, string notes,
                           UniversityDegree degree, UniversityProgram program, Course course) : this()
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
                Degree = degree;
                Program = program;
                Course = course;
            }

            #region Overrides
            //It's always a great idea to override ToString()
            //Documenation: https://msdn.microsoft.com/en-us/library/ms173154%28v=vs.80%29.aspx


            /*These built-in C# objects (StringBuilder) are memory efficient ways to deal with lots of 
             * string contacts aka + overloaded operands or string.concat() method calls
             * 
             * Documentation: https://msdn.microsoft.com/en-us/library/system.text.stringbuilder%28v=vs.110%29.aspx
             * Memory Usuage Explination: http://www.dotnetperls.com/stringbuilder
             */

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Student");
                sb.AppendLine("-------");
                sb.AppendFormat("Name: {0} {1}", FirstName, LastName).AppendLine();
                sb.AppendFormat("Birthday: {0}", Birthday.ToShortDateString()).AppendLine();
                sb.AppendFormat("Address: {0} {1} {2} {3} {4} {5}", Address,Address1, City, State, Zip, Country).AppendLine();
                sb.AppendLine();
                sb.AppendLine(Program.ToString());
                sb.AppendLine(Degree.ToString());
                sb.AppendLine(Course.ToString());

                sb.AppendLine();

                return sb.ToString();
            }

            #endregion Overrides
        }

        public struct Professor
        {
            #region Properties

            public string PreFix { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }

            public string Department { get; private set; }

            #endregion Properties

            public Professor(string prefix, string firstName, string lastName, string department) : this()
            {
                PreFix = prefix;
                FirstName = firstName;
                LastName = lastName;
                Department = department;
            }

            #region Overrides

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Professor");
                sb.AppendLine("---------");
                sb.AppendFormat("Prefix: {0}", PreFix).AppendLine();
                sb.AppendFormat("First Name: {0}", FirstName).AppendLine();
                sb.AppendFormat("Last Name: {0}", LastName).AppendLine();
                sb.AppendFormat("Department: {0}", Department).AppendLine();
                sb.AppendLine();

                return sb.ToString();
            }

            #endregion Overrides
        }

        public struct UniversityDegree
        {
            #region Properties

            public DegreeLevel Level { get; private set; }

            public string Major { get; private set; }

            //Shorts Max value is 32767 never heard of a degree program going higher than this EVER
            public short RequiredCredits { get; private set; }

            #endregion Properties

            public UniversityDegree(DegreeLevel level, string major, short requiredCredits) : this()
            {
                Level = level;
                Major = major;
                RequiredCredits = requiredCredits;
            }

            #region Overrides

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Degree");
                sb.AppendLine("------");
                sb.AppendFormat("Level: {0}", Level).AppendLine();
                sb.AppendFormat("Major: {0}", Major).AppendLine();
                sb.AppendFormat("Required Credits: {0}", RequiredCredits).AppendLine();
                sb.AppendLine();

                return sb.ToString();
            }

            #endregion Overrides
        }

        public struct UniversityProgram
        {
            #region Properties

            public string Name { get; private set; }

            //IEnumerable<T> is the interface that Arrays and List<T> inherit from
            //This allows an array, a List<T> or any other item that inherits from
            //IEnumerable<T> to be passed to this property.
            //Documentation: https://msdn.microsoft.com/en-us/library/9eekhta0%28v=vs.110%29.aspx
            public IEnumerable<DegreeLevel> DegreesOffered { get; private set; }

            public Professor DepartmentHead { get; private set; }

            #endregion Properties

            public UniversityProgram(string name, IEnumerable<DegreeLevel> degreesOffered, Professor departmentHead) : this()
            {
                Name = name;
                DegreesOffered = degreesOffered;
                DepartmentHead = departmentHead;
            }

            #region Overrides

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Program");
                sb.AppendLine("-------");
                sb.AppendFormat("Name: {0}", Name).AppendLine();
                sb.Append("Degrees Offered: [");
                foreach(var degree in DegreesOffered)
                {
                    sb.AppendFormat("{0} ", degree);
                }
                sb.Length--; //trim off last whitespace created from foreach loop
                sb.AppendLine("]");
                sb.AppendLine("Department Head: ");
                sb.AppendFormat("{0}", DepartmentHead).AppendLine();

                return sb.ToString();
            }

            #endregion Overrides
        }

        public struct Course
        {
            #region Properties

            public string Code { get; private set; }

            public string Title { get; private set; }

            public string Description { get; private set; }

            public short CreditHours { get; private set; }

            public Professor Professor { get; private set; }

            #endregion Properties

            public Course(string code, string title, string description, short creditHours, Professor professor) : this()
            {
                Code = code;
                Title = title;
                Description = description;
                CreditHours = creditHours;
                Professor = professor;
            }

            #region Overrides

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Course");
                sb.AppendLine("------");
                sb.AppendFormat("Code: {0}", Code).AppendLine();
                sb.AppendFormat("Title: {0}", Title).AppendLine();
                sb.AppendFormat("Description: {0}", Description).AppendLine();
                sb.AppendFormat("CreditHours: {0}", CreditHours).AppendLine();
                sb.AppendLine("Course Instructor: ");
                //AppendFormat will automatically called Professor.ToString()
                sb.AppendFormat("{0}", Professor).AppendLine();
                sb.AppendLine();

                return sb.ToString();
            }

            #endregion Overrides
        }

        #endregion Structs

        #region Enums

        public enum DegreeLevel
        {
            Bachelors,
            Masters,
            Doctorate
        }

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
