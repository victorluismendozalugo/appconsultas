using apiServices.Models;
using System;
using System.Data;
using WarmPack.Classes;
using WarmPack.Database;

namespace apiServices.DA
{
    public class DAReportes
    {
        private readonly Conexion _conexion = null;

        public DAReportes()
        {
            _conexion = new Conexion(ConexionType.MSSQLServer, Globales.ConexionPrincipal);
        }

        //public Result<DataModel> FamiliasCat()
        //{
        //    var parametros = new ConexionParameters();
        //    DataSet dsRep;
        //    try
        //    {
        //        parametros.Add("@pResultado", ConexionDbType.Bit, System.Data.ParameterDirection.Output);
        //        parametros.Add("@pMsg", ConexionDbType.VarChar, 300, System.Data.ParameterDirection.Output, 300);
        //        parametros.Add("@pCodError", ConexionDbType.Int, System.Data.ParameterDirection.Output);

        //        var r = _conexion.ExecuteWithResults("rptFamiliasCat", parametros, out dsRep);

        //        return new Result<DataModel>()
        //        {
        //            Value = parametros.Value("@pResultado").ToBoolean(),
        //            Message = parametros.Value("@pMsg").ToString(),
        //            Data = new DataModel()
        //            {
        //                CodigoError = parametros.Value("@pCodError").ToInt32(),
        //                MensajeBitacora = parametros.Value("@pMsg").ToString(),
        //                Data = dsRep
        //            }
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Result<DataModel>()
        //        {
        //            Value = false,
        //            Message = "Problemas en reporte de familias",
        //            Data = new DataModel()
        //            {
        //                CodigoError = 101,
        //                MensajeBitacora = ex.Message,
        //                Data = ""
        //            }
        //        };
        //    }
        //}
    }
}