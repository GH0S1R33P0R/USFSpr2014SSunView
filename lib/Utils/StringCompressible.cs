﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject
{
    // String version of the ICompressible ticket entity
    public class StringCompressible : ICompressible
    {
        private int complexity;    // Size of the compressed ticket
        private byte[] data;       // Data field of the ticket
        private string itemID;     // Item ID of the ticket
        private string summary;
        private string oid;

        /// <summary>
        /// Default StringCompressible constructor
        /// </summary>
        public StringCompressible()
        {
            complexity = 0;
            data = new byte[0];
        }
       
        /// <summary>
        /// Overloaded constructor that takes one string
        /// </summary>
        /// <param name="summary">String value to set the "data" data member</param>
        public StringCompressible(string summaryValue)
        {
            data = Encoding.ASCII.GetBytes(summaryValue.ToUpper());
            summary = summaryValue;
        }

        /// <summary>
        /// Constructor that takes two strings
        /// </summary>
        /// <param name="ID">String to set the itemID data member</param>
        /// <param name="summary">String to set the "data" data member</param>
        public StringCompressible(string ID, string summaryValue)
        {
            data = Encoding.ASCII.GetBytes(summaryValue.ToUpper());
            oid = ID;
            summary = summaryValue;
        }

        // Return the data as a byte array
        byte[] ICompressible.ToByteArray()
        {
            return data;
        }

        // Accessor and mutator for Complexity value
        int ICompressible.Complexity
        {
            get { return this.complexity; }
            set { this.complexity = value; }
        }

        /// <summary>
        /// Accessor and mutator for itemID value
        /// </summary>
        public string ItemID
        {
            get {return this.itemID; }
            set { this.itemID = value; }
        }

        public string OID
        {
            get { return this.oid; }
        }

        public string Summary
        {
            get { return this.summary; }
        }
    }
}
