using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary.Models;

public class CustomerModel
{
    public int CusId { get; set; }
    public string CusName { get; set; }
    public string CusAddress { get; set; }
    public string CusPhone { get; set; }
}
