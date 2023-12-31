﻿using System.ComponentModel.DataAnnotations;

namespace BasketTask.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set;}

        [StringLength(255)]
        public string? UpdatedBy { get; set; }

        public Nullable<DateTime> UpdatedDate { get; set; }

        [StringLength(255)]
        public string? DeletedBy { get; set; }

        public Nullable<DateTime> DeletedDate { get; set;}

    }
}
