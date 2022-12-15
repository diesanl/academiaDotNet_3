using System;
using System.Collections.Generic;

namespace EntityDatabaseFirst;

public partial class Pessoa
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<Email> listaEmails { get; set; } = new List<Email>();
}
