using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Galenort.Dominio
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Required]
        public bool EstaEliminado { get; set; }
    }
}
