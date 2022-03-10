using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Clases
{
    public class ActivoFijo
    {

        string id;
        int vidaUtil;
        int valorDeSalvamento;
        string nombreActivo;
        int  valorActivo;
        string tipoActivoFijo;

        public ActivoFijo()
        {
            Id = string.Empty;
            nombreActivo = string.Empty;
            valorActivo = 0;
            tipoActivoFijo = string.Empty;
            VidaUtil = 0;
            ValorDeSalvamento = 0;

        }

        public ActivoFijo(string id,string nombreActivo, int valorActivo, string tipoactivo,int vidaUtil, int valordeSalvage)
        {

            this.Id = id;
            this.NombreActivo = nombreActivo;
            this.ValorActivo = valorActivo;
            this.TipoActivofijo = tipoactivo;
            this.VidaUtil = vidaUtil;
            this.ValorDeSalvamento = valordeSalvage;
        }

        public string NombreActivo { get => nombreActivo; set => nombreActivo = value; }
        public int ValorActivo { get => valorActivo; set => valorActivo = value; }

        public string TipoActivofijo { get => tipoActivoFijo; set => tipoActivoFijo = value; }
        public int VidaUtil { get => vidaUtil; set => vidaUtil = value; }
        public int ValorDeSalvamento { get => valorDeSalvamento; set => valorDeSalvamento = value; }
        public string Id { get => id; set => id = value; }




        public string getInfoBasicaActivoBusqueda()
        {

            return Id + " " + NombreActivo +"\r\n";
        }


    }
    }

