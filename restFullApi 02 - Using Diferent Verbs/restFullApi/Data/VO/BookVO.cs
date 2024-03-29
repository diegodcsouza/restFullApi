﻿using System;
using System.Runtime.Serialization;

namespace restFullApi.Data.VO
{
    [DataContract]
    public class BookVO
    {
        //DataContract é responsavel por serializar os objetos.
        [DataMember (Order = 1, Name ="Código")]
        public long? Id { get; set; }

        [DataMember(Order = 2, Name = "Título")]
        public string Title { get; set; }

        [DataMember(Order = 3, Name = "Autor")]
        public string Author { get; set; }

        [DataMember(Order = 5, Name = "Preço")]
        public decimal Price { get; set; }

        [DataMember(Order = 4, Name = "Lançamento")]
        public DateTime LaunchDate { get; set; }
    }
}
