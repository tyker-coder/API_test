﻿using System.ComponentModel;

namespace SistemasDeTarefas.Enums
{
    public enum StatusTarefa
    {

        [Description("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        EmAndamento =2,
        [Description("Concluido")]
        Concluido = 3

    }
}
