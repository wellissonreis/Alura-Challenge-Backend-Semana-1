﻿using System.ComponentModel.DataAnnotations;

namespace Alura_Challenge_Backend_Semana_1.Data.Dtos;

public class ReadVideoDto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Url { get; set; }
}
