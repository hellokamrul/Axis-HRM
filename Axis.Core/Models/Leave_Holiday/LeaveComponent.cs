using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.Leave_Holiday
{
    public class LeaveComponent : BaseModel
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [StringLength(250)]
        public string Definition { get; set; }   
        
        [StringLength(7)]
        public string? Color { get; set; } 

        public decimal? MaximumAllocationPerPeriod { get; set; }
        public int? ApplicationAfterWorkingDays { get; set; } 
        public int? MaximumConsecutiveLeaves { get; set; }
        public LeaveUnitType UnitType { get; set; }
        public bool IsActive { get; set; }

      //  public CarryForwardSettings CarryForward { get; set; } = new();
        public bool? IsCarryForward { get; set; } = false;
        public int? MaxCarryForwardedLeaves { get; set; }
        public int? ExpiryInDays { get; set; }



        //   public EncashmentSettings Encashment { get; set; } = new();
        public bool? IsEncashment { get; set; } = false;
        public int? MaxEncashableLeaves { get; set; }
        public string? EarningComponentId { get; set; } 
        public int? NonEncashableLeaves { get; set; }

        // public EarnedLeaveSettings EarnedLeave { get; set; } = new();

        public bool? IsEarnedLeave { get; set; } = false;

        public EarnFrequency? Frequency { get; set; }

        public AllocateOnDayOption? AllocateOnDay { get; set; }

        public double? RoundingRule { get; set; }

        // public AdditionalLeaveSettings Flags { get; set; } = new();

        public bool? IsWithoutPay { get; set; } = false;
        public bool? IsOptional { get; set; } = false;
        public bool? IsPartiallyPaid { get; set; } = false;
        public bool? AllowNegativeBalance { get; set; } = false;    
        public bool? AllowOverAllocation { get; set; } = false;
        public bool? IncludeHolidaysWithinLeaves { get; set; } = false;
        public bool? IsCompensatory { get; set; } = false;


        public decimal? FractionOfDailySalary { get; set; } = 0;

    }

  

    public enum LeaveUnitType
    {
        Hourly,
        Daily,
    }

    public enum EarnFrequency
    {
        Monthly,
        Quarterly,
        Yearly
    }

    public enum AllocateOnDayOption
    {
        StartOfPeriod,
        EndOfPeriod,
        SpecificDay
    }
}