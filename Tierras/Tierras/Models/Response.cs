using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tierras.Models
{
    public class Response
    {
        #region Atributos

        public bool IsSuccess
        {
            get;
            set;

        }

        public string Message
        {
            get;
            set;

        }
        public object Result
        {
            get;
            set;

        }
        #endregion


    }
}
