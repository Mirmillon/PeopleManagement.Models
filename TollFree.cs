﻿using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class TollFree : TollFreeNumber
    {
        int tollFreeId;
        TelephoneConfidentiality confidentiality;

        public int TollFreeId { get => tollFreeId; set => tollFreeId = value; }
        public TelephoneConfidentiality Confidentiality { get => confidentiality; set => confidentiality = value; }
    }
}
