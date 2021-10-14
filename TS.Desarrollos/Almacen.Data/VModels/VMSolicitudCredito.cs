using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Data.VModels
{
    public class VMCredito
    {
        public int Id { get; set; }
        public string Folio{ get; set; }
        public string Sucursal { get; set; }
        public string Enganche { get; set; }
        public string Plazo { get; set; }
        public string FormaPago { get; set; }
        public string Grupo { get; set; }
        public string Fecha { get; set; }
        public string Vendedor { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteDireccion { get; set; }
        public string ClienteRfc { get; set; }
        public string ClienteNoExt { get; set; }
        public string ClienteColonia { get; set; }
        public string ClienteCP { get; set; }
        public string ClienteCiudad { get; set; }
        public string ClienteEstado { get; set; }
        public string ClienteTelefono { get; set; }
        public string ClienteCorreoE { get; set; }
        public string ClienteEntreCalles { get; set; }
        public string ClienteAniosResidencia { get; set; }
        public string ClienteCasaPropia { get; set; }
        public string ClienteCasaRenta { get; set; }
        public string ClienteCasaVivePadres { get; set; }
        public string ClienteCasaOtros { get; set; }
        public string ClientePagoMensualRenta { get; set; }
        public string ClienteFechaNacimiento { get; set; }
        public string ClienteDependientes{ get; set; }
        public string ClienteEstadoCivil { get; set; }
        public string ClienteTelefonoCelular { get; set; }
        public string ClienteDomicilioAnterior { get; set; }
        public string ClienteCiudadAnterior { get; set; }
        public string ClienteEstadoAnterior { get; set; }
        public string ClienteAniosResidenciaAnterior { get; set; }
        public string EmpleoEmpresa{ get; set; }
        public string EmpleoAntiguedad { get; set; }
        public string EmpleoTelefonoFijo { get; set; }
        public string EmpleoTelefonoExt { get; set; }
        public string EmpleoDomicilio { get; set; }
        public string EmpleoColonia { get; set; }
        public string EmpleoCiudad { get; set; }
        public string EmpleoCodigoPsotal { get; set; }
        public string EmpleoEstado { get; set; }
        public string EmpleoIngresoMensual { get; set; }
        public string EmpleoOtrosIngresos { get; set; }
        public string EmpresaAnterior { get; set; }
        public string EmpresaAnteriorAntiguedad { get; set; }
        public string EmpresaAnteriorTelefono { get; set; }
        public string FamiliarNombre { get; set; }
        public string FamiliarParesntesco { get; set; }
        public string FamiliarDomicilio { get; set; }
        public string FamiliarTelefono { get; set; }


    }
}
