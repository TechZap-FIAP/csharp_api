﻿namespace APITechZap.Models.DTOs.SolarPanelDTOs;

/// <summary>
/// DTO para o painel solar detalhado
/// </summary>
public class SolarPanelDetailedDTO
{
    public int IdSolarPanel { get; set; }
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

    /// <summary>
    /// Tipo do Painel Solar
    /// </summary>
    public SolarPanelTypeDetailedDTO? SolarPanelTypeDTO { get; set; }
}
