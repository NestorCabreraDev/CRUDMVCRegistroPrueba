using System;
using System.Collections.Generic;

namespace CRUDMVCRegistroPrueba.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int StudentAge { get; set; }

    public string StudentCountry { get; set; } = null!;
}
