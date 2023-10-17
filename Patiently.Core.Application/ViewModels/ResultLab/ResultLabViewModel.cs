﻿using Patiently.Core.Application.ViewModels.Patients;
using Patiently.Core.Application.ViewModels.TestLab;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.ViewModels.ResultLab
{
    public class ResultLabViewModel
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int LabTestID { get; set; }
        public string Result { get; set; }
        public bool Status { get; set; }

        public PatientViewModel Patient { get; set; }
        public TestLabViewModel TestLab { get; set; }
    }
}
