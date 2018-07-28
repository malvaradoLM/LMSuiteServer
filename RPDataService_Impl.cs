﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPSuiteServer
{
    using System;
    using System.Collections.Generic;
    using RemObjects.SDK;
    using RemObjects.SDK.Types;
    using RemObjects.SDK.Server;
    using RemObjects.SDK.Server.ClassFactories;
    using System.Data;

    [RemObjects.SDK.Server.ClassFactories.StandardClassFactory()]
    [RemObjects.SDK.Server.Service(Name = "RPDataService", InvokerClass = typeof(RPDataService_Invoker), ActivatorClass = typeof(RPDataService_Activator))]
    public class RPDataService : RemObjects.DataAbstract.Server.DataAbstractService, IRPDataService
    {
        private RemObjects.DataAbstract.Bin2DataStreamer dataStreamer;
        private System.ComponentModel.IContainer components;

        public RPDataService() :
                this(null, null)
        {
        }
        public RPDataService(ISessionManager sessionManager, IEventSinkManager eventManager) :
                base(sessionManager, eventManager)
        {
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataStreamer = new RemObjects.DataAbstract.Bin2DataStreamer(this.components);
            // 
            // dataStreamer
            // 
            this.dataStreamer.SendReducedDelta = false;
            // 
            // RPDataService
            // 
            this.AcquireConnection = true;
            this.RequireSession = true;
            this.ServiceDataStreamer = this.dataStreamer;
            this.ServiceSchemaName = "RPSuiteServer";

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((this.components != null))
                {
                    this.components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        public System.DateTime Fecha()
        {
            return System.DateTime.Now;
        }

        public bool GuardaFactura(TFactura Datos)
        {
            IDbCommand command;
            using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spFolio", new string[] { "Campo", "Serie" }, new object[] { "user", "password" }, out command))
            {
                while (reader.Read())
                {


                    // do something
                }
            }
            

            using (IDbCommand lCommand = this.ServiceSchema.NewCommand(this.Connection, "spInserta", new string[] { }, new object[] { }))
            {
                lCommand.ExecuteNonQuery();
            }
                return true;
        }

        public TFactura NotaCredito(string NewParam, string NewParam1, string NewParam2, string NewParam3)
        {
            GuardaFactura(null);
            Fecha();
            return null;          
        }

        public int Folio(string Campo, string Serie)
        {
            int Res = -1;
            IDbCommand command;
            using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spFolio", new string[] { "Campo", "Serie" }, new object[] { Campo, Serie }, out command))
            {
                while (reader.Read())
                {
                    Res = (int)reader["Folio"];
                }
            }
            return Res;
        }

        public int GuardaClienteNuevo(TClienteNuevo Datos)
        {
            //string[] Params;
            //Params = new string[32];
            Datos.ClienteId = Folio("ClienteID", "");

            int Res = -1;
            //bool Res = false;
            try
            {
                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] { }, new object[] { }))
                                                               
                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] {"ClienteID", "Codigo"
                //     ,"Nombre" ,"Grupo" ,"Calle" ,"Colonia" ,"Ciudad" ,"Telefono" ,"CodigoPostal" ,"RFC" ,"Curp" ,"LimiteCredito" ,"email" 
                //     ,"Localidad" ,"Estado" ,"NoExterior" ,"NoInterior"  ,"CuentaBancaria" }, new object[] {
                //         Datos.ClienteId, Datos.Codigo,Datos.Nombre,Datos.Grupo,Datos.Calle,Datos.Colonia,Datos.Ciudad,Datos.Telefono,Datos.CodigoPostal,Datos.RFC,
                //      Datos.CURP,Datos.LimiteCredito, Datos.Email,Datos.Localidad,Datos.Estado,Datos.NoExterior,Datos.NoInterior,Datos.CuentaBancaria}))


                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] {"ClienteID", "Codigo"
                     ,"Nombre" ,"Grupo" ,"Calle" ,"Colonia" ,"Ciudad" ,"Telefono" ,"CodigoPostal" ,"RFC",
                       "Curp","Status","AutorizaCheque","TicketBoucher","AutorizaValeCredito"  ,"LimiteCredito" ,"email"
                     ,"Localidad" ,"Estado" ,"NoExterior" ,"NoInterior"  ,"CuentaBancaria" }, new object[] {
                         Datos.ClienteId,Datos.Codigo,Datos.Nombre,Datos.Grupo,Datos.Calle,Datos.Colonia,Datos.Ciudad,Datos.Telefono,Datos.CodigoPostal,Datos.RFC,
                      Datos.CURP,Datos.Status,Datos.AutorizaCheque,Datos.TicketBoucher,Datos.AutorizaValeCredito, 0,Datos.Email,Datos.Localidad,Datos.Estado,Datos.NoExterior,Datos.NoInterior,Datos.CuentaBancaria}))
                {
                    lcommand.ExecuteNonQuery();
                    Res = Datos.ClienteId;
                }
               // Res = true;
            }
            catch (Exception ex)
            {
                Res = -1;
               // Res = false;
            }
           
            return Res;
        }

        public int GuardaDocumentoNuevo(TDocumentoNuevo Datos)
        {
            //string[] Params;
            //Params = new string[32];
            Datos.DocumentoId = Folio("DocumentoID", "");
            byte[] Imagen= System.Text.Encoding.Default.GetBytes(Datos.Imagen);
            int Res = -1;
            //bool Res = false;
            try
            {
                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] { }, new object[] { }))

                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] {"ClienteID", "Codigo"
                //     ,"Nombre" ,"Grupo" ,"Calle" ,"Colonia" ,"Ciudad" ,"Telefono" ,"CodigoPostal" ,"RFC" ,"Curp" ,"LimiteCredito" ,"email" 
                //     ,"Localidad" ,"Estado" ,"NoExterior" ,"NoInterior"  ,"CuentaBancaria" }, new object[] {
                //         Datos.ClienteId, Datos.Codigo,Datos.Nombre,Datos.Grupo,Datos.Calle,Datos.Colonia,Datos.Ciudad,Datos.Telefono,Datos.CodigoPostal,Datos.RFC,
                //      Datos.CURP,Datos.LimiteCredito, Datos.Email,Datos.Localidad,Datos.Estado,Datos.NoExterior,Datos.NoInterior,Datos.CuentaBancaria}))


                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertaDocumentoNuevo", new string[] {"DocumentoID", "Fecha"
                     ,"Observaciones" ,"Imagen" ,"EmpleadoID" ,"TipoDocumentoID" ,"UsuarioID"}, new object[] {
                         Datos.DocumentoId,Datos.Fecha,Datos.Observaciones,Imagen,Datos.EmpleadoId,Datos.TipoDocumentoId,Datos.UsuarioId}))
                {
                    lcommand.ExecuteNonQuery();
                    Res = Datos.DocumentoId;
                }
                // Res = true;
            }
            catch (Exception ex)
            {
                Res = -1;
                // Res = false;
            }

            return Res;
        }


        public TCliente BuscarCliente(int clienteID)
        {

             TCliente res= new TCliente();
           // TCliente res; // = new TCliente { ClienteID =};
            try
            {
                int x = 0;
                IDbCommand command;

                using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "BuscaCliente", new string[] { "ClienteID" }, new object[] { clienteID }, out command))
                {
                    while (reader.Read())
                    {
                        

                        // investigar si se puede pasar el Reader completo de manera directa a la variable res, la variable Res es de Tipo TCliente,
                        //Contiene todos los campos de la tabla cliente

                        res.ClienteID = (int)reader["ClienteID"];  // (TCliente)reader["Folio"];
                        if (reader["Nombre"] != DBNull.Value)
                        {
                            res.Nombre = (string)reader["Nombre"];
                        }
                        if (reader["codigo"] != DBNull.Value)
                        {
                            res.Codigo = (string)reader["Codigo"];
                        }
                        if (reader["Calle"] != DBNull.Value)
                            { res.Calle = (string)reader["Calle"]; }

                        if (reader["Colonia"] != DBNull.Value)
                        { res.Colonia = (string)reader["Colonia"]; }
                            
                        if (reader["Ciudad"] != DBNull.Value)
                        { res.Ciudad = (string)reader["Ciudad"]; }
                       
                        if (reader["Telefono"] != DBNull.Value)
                        { res.Telefono = (string)reader["Telefono"]; }

                        if (reader["CodigoPostal"] != DBNull.Value)
                        { res.CodigoPostal = (string)reader["CodigoPostal"]; }

                        if (reader["RFC"] != DBNull.Value)
                        { res.RFC = (string)reader["RFC"]; }

                        if (reader["CURP"] != DBNull.Value)
                        { res.CURP = (string)reader["CURP"]; }

                        if (reader["Status"] != DBNull.Value)
                        { res.Status = (bool)reader["Status"]; }

                        if (reader["AutorizaCheque"] != DBNull.Value)
                        { res.AutorizaCheque = (bool)reader["AutorizaCheque"]; }

                        //    if (reader["TicketBoucher"] != null)
                        //    { res.TicketBoucher = (bool)reader["TicketBoucher"]; }
                        //    if (reader["AutorizaValeCredito"] != null)
                        //    { res.AutorizaValeCredito = (bool)reader["AutorizaValeCredito"]; }

                        if (reader["CuentaContableCredito"] != DBNull.Value)
                        { res.CuentaContableCredito = (string)reader["CuentaContableCredito"]; }

                        //    if (reader["CuentaContableAnticipo"] != null)
                        //    { res.CuentaContableAnticipo = (string)reader["CuentaContableAnticipo"]; }
                        //    if (reader["LimiteCredito"] != null)
                        //    { res.LimiteCredito = (double)reader["LimiteCredito"]; }
                        //    if (reader["DiasCredito"] != null)
                        //    { res.DiasCredito = (int)reader["DiasCredito"]; }
                        //    if (reader["NIP"] != null)
                        //    { res.NIP = (int)reader["NIP"]; }
                        //    if (reader["FacturayLiquidacion"] != null)
                        //    { res.FacturayLiquidacion = (bool)reader["FacturayLiquidacion"]; }
                        //    if (reader["ApellidoPaterno"] != null)
                        //    { res.ApellidoPaterno = (string)reader["ApellidoPaterno"]; }
                        //    if (reader["ApellidoMaterno"] != null)
                        //    { res.ApellidoMaterno = (string)reader["ApellidoMaterno"]; }
                        //    if (reader["Email"] != null)
                        //    { res.Email = (string)reader["Email"]; }
                        //    if (reader["Referencia"] != null)
                        //    { res.Referencia = (string)reader["Referencia"]; }
                        //    if (reader["Telefonos"] != null)
                        //    { res.Telefonos = (string)reader["Telefonos"]; }
                        //    if (reader["FacturaExpress"] != null)
                        //    { res.FacturaExpress = (bool)reader["FacturaExpress"]; }
                        //    if (reader["saldo"] != null)
                        //    { res.Saldo = (double)reader["saldo"]; }
                        //    if (reader["PuntosCategoriaID"] != null)
                        //    { res.PuntosCategoriaID = (int)reader["PuntosCategoriaID"]; }
                        //    if (reader["Localidad"] != null)
                        //    { res.Localidad = (string)reader["Localidad"]; }
                        //    
                            //if (reader["Estado"] != null)
                            //{ res.Estado = (string)reader["Estado"]; }
                            //if (reader["NoExterior"] != null)
                            //{ res.NoExterior = (string)reader["NoExterior"]; }
                            //if (reader["NoInterior"] != null)
                            //{ res.NoInterior = (string)reader["NoInterior"]; }
                            //if (reader["Actualizado"] != null)
                            //{ res.Actualizado = (bool)reader["Actualizado"]; }
                            //if (reader["CuentaBancaria"] != null)
                            //{ res.CuentaBancaria = (string)reader["CuentaBancaria"]; }
                       
                            //if (reader["Sexo"] != null)
                            //{ res.Sexo = (string)reader["Sexo"]; }
                            //if (reader["Clasificacion"] != null)
                            //{ res.Clasificacion = (double)reader["Clasificacion"]; }
                            //if (reader["INE"] != null)
                            //{ res.INE = (bool)reader["INE"]; }
                            //if (reader["INETipoProceso"] != null)
                            //{ res.INETipoProceso = (string)reader["INETipoProceso"]; }
                            //if (reader["INETipoComite"] != null)
                            //{ res.INETipoComite = (string)reader["INETipoComite"]; }
                            //if (reader["INEidContabilidad"] != null)
                            //{ res.INEidContabilidad = (int)reader["INEidContabilidad"]; }
                            //if (reader["INEClaveEntidad"] != null)
                            //{ res.INEClaveEntidad = (string)reader["INEClaveEntidad"]; }
                            //if (reader["INEEntidadAmbito"] != null)
                            //{ res.INEEntidadAmbito = (string)reader["INEEntidadAmbito"]; }
                            //if (reader["INEEntidadContabilidad"] != null)
                            //{ res.INEEntidadContabilidad = (int)reader["INEEntidadContabilidad"]; }
                            //if (reader["UUID"] != null)
                            //{ res.UUID = (string)reader["UUID"]; }
                        

                    }
                }

            }
            
            catch (Exception ex)
            {
                //

                res.ClienteID = -1;
                // Res = false;
            }
            return res;
        }


        public bool EntregarPremio(int ClienteID,string Descripcion, double Cargo, double Abono, string Observaciones,int PuntosPremioID)
        {
            IDbCommand command;
            using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spFolio", new string[] { "Campo", "Serie" }, new object[] { "user", "password" }, out command))
            {
                while (reader.Read())
                {


                    // do something
                }
            }
            return false;
        }

       
    }
}
