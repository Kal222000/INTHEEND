﻿using System;
using System.Collections.Generic;

namespace BACKEND.Modelos;

public partial class SolicitudReserva
{
    public int SolicitudId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public string EstadoSolicitud { get; set; } = "pendiente";

    public virtual ICollection<ReservaDetalle> ReservaDetalles { get; set; } = new List<ReservaDetalle>();

    public virtual Usuario Usuario { get; set; } = null!;
}
