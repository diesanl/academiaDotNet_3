using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst;

public partial class Email
{
    public int id { get; set; }

    public string email { get; set; } = null!;

    public int? Pessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
