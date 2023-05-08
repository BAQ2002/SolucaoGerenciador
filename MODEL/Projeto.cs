using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MODEL;

public partial class Projeto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Gerente { get; set; } = null!;

    public DateTime DataDeInicio { get; set; }

    public DateTime DataFinal { get; set; }

    public string Resumo { get; set; } = null!;

    public string Status { get; set; } = null!;
}
