//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPSuiteServer {
    using System;
    using System.Collections.Generic;
    using RemObjects.SDK;
    using RemObjects.SDK.Types;
    using RemObjects.SDK.Server;
    using RemObjects.SDK.Server.ClassFactories;
    using RemObjects.DataAbstract.Server;
    
    [System.Reflection.ObfuscationAttribute(Exclude=true)]
    public class RPLoginService_Invoker : RemObjects.DataAbstract.Server.SimpleLoginService_Invoker {
        public RPLoginService_Invoker() : 
                base() {
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=false)]
    public class RPLoginService_Activator : object, RemObjects.SDK.Server.IServiceActivator {
        public RPLoginService_Activator() {
        }
        public RemObjects.SDK.IROService CreateInstance() {
            return new RPLoginService();
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true)]
    public class RPDataService_Invoker : RemObjects.DataAbstract.Server.DataAbstractService_Invoker {
        public RPDataService_Invoker() : 
                base() {
        }
        public static void Invoke_GuardaFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TFactura Datos = ((TFactura)(@__Message.Read("Datos", typeof(TFactura), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                bool Result;
                Result = ((IRPDataService)(@__Instance)).GuardaFactura(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaFacturaResponse");
                @__Message.WriteBoolean("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_NotaCredito(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                string NewParam = @__Message.ReadAnsiString("NewParam");
                string NewParam1 = @__Message.ReadAnsiString("NewParam1");
                string NewParam2 = @__Message.ReadAnsiString("NewParam2");
                string NewParam3 = @__Message.ReadAnsiString("NewParam3");
                TFactura Result;
                Result = ((IRPDataService)(@__Instance)).NotaCredito(NewParam, NewParam1, NewParam2, NewParam3);
                @__ObjectDisposer.Add(Result);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "NotaCreditoResponse");
                @__Message.Write("Result", Result, typeof(TFactura), RemObjects.SDK.StreamingFormat.Default);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_Fecha(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            System.DateTime Result;
            Result = ((IRPDataService)(@__Instance)).Fecha();
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "FechaResponse");
            @__Message.WriteDateTime("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_Folio(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            string Campo = @__Message.ReadAnsiString("Campo");
            string Serie = @__Message.ReadAnsiString("Serie");
            int Result;
            Result = ((IRPDataService)(@__Instance)).Folio(Campo, Serie);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "FolioResponse");
            @__Message.WriteInt32("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_GuardaClienteNuevo(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TClienteNuevo Datos = ((TClienteNuevo)(@__Message.Read("Datos", typeof(TClienteNuevo), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                int Result;
                Result = ((IRPDataService)(@__Instance)).GuardaClienteNuevo(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaClienteNuevoResponse");
                @__Message.WriteInt32("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_BuscarCliente(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                int ClienteID = @__Message.ReadInt32("ClienteID");
                TCliente Result;
                Result = ((IRPDataService)(@__Instance)).BuscarCliente(ClienteID);
                @__ObjectDisposer.Add(Result);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "BuscarClienteResponse");
                @__Message.Write("Result", Result, typeof(TCliente), RemObjects.SDK.StreamingFormat.Default);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_GenerarConsumo(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TConsumo Datos = ((TConsumo)(@__Message.Read("Datos", typeof(TConsumo), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                bool Result;
                Result = ((IRPDataService)(@__Instance)).GenerarConsumo(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GenerarConsumoResponse");
                @__Message.WriteBoolean("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=false)]
    public class RPDataService_Activator : object, RemObjects.SDK.Server.IServiceActivator {
        public RPDataService_Activator() {
        }
        public RemObjects.SDK.IROService CreateInstance() {
            return new RPDataService();
        }
    }
}
