using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool succes, string message) : this(succes)
        {
            message = message;        //Not: "" Get olan ifadeler Constractorda Set edilebilir ""
            succes = succes;
        }
        public Result(bool succes)
        {                           
            succes = succes;		
        }

        public bool Succes { get; }

        public string message { get; }
    }
}
