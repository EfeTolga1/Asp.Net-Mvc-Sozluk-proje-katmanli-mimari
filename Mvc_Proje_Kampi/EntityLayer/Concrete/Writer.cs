﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(250)]
        public string WriterImage { get; set; }
        [StringLength(250)]
        public string WriterAbout { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }
        [StringLength(30)]
        public string WriterTitle { get; set; }
        public bool WriterStatus { get; set; }


        public ICollection<Heading> Headings { get; set; }  // yazar işin bir kısmında,heading işin çok tarafında olacak(bire çok ilişki)
        public ICollection<Content>  Contents { get; set; }

    }
}
