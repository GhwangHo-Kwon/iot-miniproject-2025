using System;
using System.Collections.Generic;

namespace WpfMrpSimulatorApp.Models;

public partial class ScheduleNew
{
    public int SchIdx { get; set; }

    public string PlantCode { get; set; } = null!;

    // 데이터그리드에 표현하려면 새로운 속성이 필요!!
    public string PlantName { get; set; }

    public DateOnly SchDate { get; set; }

    public int LoadTime { get; set; }

    public TimeOnly? SchStartTime { get; set; }

    public TimeOnly? SchEndTime { get; set; }

    public string? SchFacillityId { get; set; }

    public string? SchFacillityName { get; set; }

    public int SchAmount { get; set; }

    public DateTime? RegDt { get; set; }

    public DateTime? ModDt { get; set; }
}
