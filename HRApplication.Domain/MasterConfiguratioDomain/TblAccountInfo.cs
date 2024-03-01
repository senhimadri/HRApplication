using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Domain.MasterConfiguratioDomain;

public class TblAccountInfo
{
    [Key]
    public int IntPrimaryId { get; set; }
    public string StrAccountName { get; set; } = string.Empty;

}

