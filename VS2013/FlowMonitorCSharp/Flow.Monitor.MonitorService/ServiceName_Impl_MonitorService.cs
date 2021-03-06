//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Requires RODL file FloBaseTypes (C:\dev\flow\trunk\rodl\FloBaseTypes.rodl) in the same namespace.
// Requires RODL file FloServerActions (C:\dev\flow\trunk\rodl\FloServerActions.rodl) in the same namespace.
namespace FlowMonitor {
    using System;
    using System.Collections.Generic;
    using RemObjects.SDK;
    using RemObjects.SDK.Types;
    using RemObjects.SDK.Server;
    using RemObjects.SDK.Server.ClassFactories;

    using FloBaseTypes;
    
    
    [RemObjects.SDK.Server.ClassFactories.StandardClassFactory()]
    [RemObjects.SDK.Server.Service(Name="MonitorAdmin", InvokerClass=typeof(MonitorAdmin_Invoker), ActivatorClass=typeof(MonitorAdmin_Activator))]
    public class MonitorAdmin : RemObjects.SDK.Server.Service, IMonitorAdmin {
        
        private System.ComponentModel.Container components = null;
        
        public MonitorAdmin() : 
                this(null, null) {
        }
        
        public MonitorAdmin(ISessionManager sessionManager, IEventSinkManager eventManager) : 
                base(sessionManager, eventManager) {
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
        }
        
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if ((this.components != null)) {
                    this.components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        public bool SetActionStatus(string aServiceId, int aIndex, TFloScheduledType aActionType, TFloActionSettingType aStatus)
        {
            throw new NotImplementedException();
        }

        public void AddTransformError(string aServiceId, string aID, string aURL, string aQuestion)
        {
            throw new NotImplementedException();
        }

        public void HandleTransformError(string aServiceId, string aID)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransformError(string aServiceId, string aID)
        {
            throw new NotImplementedException();
        }

        public bool IsServerStarted(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public bool IsMonitorStarted()
        {
            throw new NotImplementedException();
        }

        public bool RefreshActions(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public bool StartFlowServer(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public bool StopFlowServer(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public bool StopFlowServerEx(string aServiceID, string aUserID)
        {
            throw new NotImplementedException();
        }

        public bool KillFlowServer(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public string Login(string aUserId)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void ShowServerInfo(string aServiceId, string aMessage)
        {
            throw new NotImplementedException();
        }

        public void ShowServerError(string aServiceId, string aMessage)
        {
            throw new NotImplementedException();
        }

        public void ShowLicenseError(string aServiceId, string aMessage)
        {
            throw new NotImplementedException();
        }

        public void SetServerMenuOptions(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public string[][] GetScheduleActions(string aServiceId, bool aShowDisabled)
        {
            throw new NotImplementedException();
        }

        public string[][] GetMonitorActions(string aServiceId, bool aShowDisabled)
        {
            throw new NotImplementedException();
        }

        public string[][] GetExecutingActions(string aServiceId, bool aShowDisabled)
        {
            throw new NotImplementedException();
        }

        public string[][] GetTransportActions(string aServiceID, bool aShowDisabled)
        {
            throw new NotImplementedException();
        }

        public string[][] GetPendingFiles(string aServiceID)
        {
            throw new NotImplementedException();
        }

        public FloBaseTypes.ServiceInfo[] GetServices()
        {
            throw new NotImplementedException();
        }

        public void RegisterService(string aServiceId, string aDisplayName, string aPort, ServiceConnection aCon, string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }

        public bool UnRegisterService(string aServiceId)
        {
            throw new NotImplementedException();
        }

        public void ChangeService(string aServiceId, string aDisplayName, string aPort, string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }

        public void ChangeServiceUser(string aServiceId, string aDisplayName, string aPort, string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }

        public void ChangeServiceConnection(string aServiceId, ServiceConnection aCon)
        {
            throw new NotImplementedException();
        }

        public bool CheckServiceConnection(string aServiceId, ServiceConnection aCon)
        {
            throw new NotImplementedException();
        }

        public bool CheckServiceUser(string aServiceId, string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }

        public bool CheckServicePort(string aServiceId, string aPort)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserLogonServiceRight(string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }

        public bool SetUserLogonServiceRight(string aServiceUser, string aServiceUserPass)
        {
            throw new NotImplementedException();
        }
    }
}
