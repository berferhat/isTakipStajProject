﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.RaporDtos
{
    public class RaporUpdateDto
    {
        public int Id { get; set; }
        //[Display(Name = "Tanım : ")]
        //[Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        public string Tanim { get; set; }
        //[Required(ErrorMessage = "Detay alanı boş geçilemez")]
        //[Display(Name = "Detay : ")]
        public string Detay { get; set; }
        public int GorevId { get; set; }

        //public Gorev Gorev { get; set; }
    }
}
