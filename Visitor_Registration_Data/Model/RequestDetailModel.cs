﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Registration_Data.Model
{
    public class RequestDetailModel
    {
        public int Id { get; set; }

        public Guid Taxi_Request_Infor_Id { get; set; }

        [Required]
        public int Process { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string SLM_Name { get; set; }

        public DateTime? SwipeTime { get; set; }

        public int? CarNumber { get; set; }

        public decimal? Cost { get; set; }

        //public string CostString { get; set; }

        public int? CardNumber { get; set; }

        public long? RefNumber { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        [StringLength(150)]
        public string Remark { get; set; }
    }
}
