using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjeCv.Models.Entity;

namespace ProjeCv.Models
{
    public class Class1
    {
        public IEnumerable<TblAbout> about { get; set; }
        public IEnumerable<TblExperience> exp { get; set; }
        public IEnumerable<TblEducation> edu { get; set; }
        public IEnumerable<TblAwards> awards { get; set; }
        public IEnumerable<TblInterests> interest { get; set; }
        public IEnumerable<TblSkills> skills { get; set; }
        
    }
}