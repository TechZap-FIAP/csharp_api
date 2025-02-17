﻿namespace APITechZap.Models.DTOs.WindTurbineDTOs;

/// <summary>
/// DTO de Turbina Eólica
/// </summary>
public class WindTurbineDTO
{
    /// <summary>
    /// Tamanho da Turbina Eólica
    /// </summary>
    public double? DsSize { get; set; }

    /// <summary>
    /// Material da Turbina Eólica
    /// </summary>
    public string? DsMaterial { get; set; }

    /// <summary>
    /// Preço da Turbina Eólica
    /// </summary>
    public double? DsPrice { get; set; }
}
