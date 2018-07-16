using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {

        private int _id;
        private string _make;
        private string _model;
        private DateTime _year;

        public int id { get
            {
                return _id;

            }
            set
            {
                if (value < 0)
                {
                    _id = 0;

                }
                else
                {
                    _id = value;


                }


            }
        public string Make
        { 
                get
            {
                    return _make;

                }
                set
            {
                    if (value == "ford")
                    {
                        _make= "ford";

                    }
                    else
                    {
                        _make = value;


                    }


                }
            }
        public string Model {
            get
            {
                return _model;


            }
            set
            {
                if (value == "camaro")
                {
                    _model = "camaro";
                }
                else
                {

                    _model = value;

                }


            }


        }
        public DateTime Year {
            get
            {

                return _datetime;

            }
            set
            {
                if (value == 1986)
                {


                    _year = 1986;

                }
                else
                {


                    _year = value;



                }





            }

        
    }
}
