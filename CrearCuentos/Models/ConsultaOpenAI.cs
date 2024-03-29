﻿using System.ComponentModel.DataAnnotations;

namespace CrearCuentos.Models
{
    public class ConsultaOpenAI
    {
        [Required(ErrorMessage = "El campo Título es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El campo Nivel de Grado es obligatorio")]
        public string NivelGrado { get; set; }

        [Required(ErrorMessage = "El campo Objetivo es obligatorio")]
        public string CantidadPreguntas { get; set; }

        [Required(ErrorMessage = "El campo Objetivo es obligatorio")]
        public string Competencia { get; set; }

        [Required(ErrorMessage = "El campo Objetivo es obligatorio")]
        public string Area { get; set; }
        [Required(ErrorMessage = "El campo Objetivo es obligatorio")]
        public string TiempoSesion { get; set; }
    }
}
