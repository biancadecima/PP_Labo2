﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public abstract class Parser
    {
        /// <summary>
        /// convert object to string
        /// </summary>
        /// <returns></returns>
        public abstract string ObjectToString();

        /// <summary>
        /// parse into an object
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public abstract Parser Parse(string line);
    }
}
