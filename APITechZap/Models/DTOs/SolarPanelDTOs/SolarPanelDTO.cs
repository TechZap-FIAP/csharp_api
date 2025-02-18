﻿namespace APITechZap.Models.DTOs.SolarPanelDTOs;

/// <summary>
/// DTO para o painel solar
/// </summary>
public class SolarPanelDTO
{
    /// <summary>
    /// Tamanho do painel solar
    /// </summary>
    public double? DsSize { get; set; }

    /// <summary>
    /// Material do painel solar
    /// </summary>
    public string? DsMaterial { get; set; }

    /// <summary>
    /// Preço do painel solar
    /// </summary>
    public double? DsPrice { get; set; }
}
