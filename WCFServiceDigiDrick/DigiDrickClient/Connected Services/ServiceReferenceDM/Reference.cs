﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigiDrickClient.ServiceReferenceDM {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost", ConfigurationName="ServiceReferenceDM.IDigiDrickModel")]
    public interface IDigiDrickModel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IDigiDrickModel/ModelSetup", ReplyAction="http://localhost/IDigiDrickModel/ModelSetupResponse")]
        void ModelSetup(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://localhost/IDigiDrickModel/ModelSetup", ReplyAction="http://localhost/IDigiDrickModel/ModelSetupResponse")]
        System.IAsyncResult BeginModelSetup(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS, System.AsyncCallback callback, object asyncState);
        
        void EndModelSetup(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IDigiDrickModel/ExecuteDModXCalc", ReplyAction="http://localhost/IDigiDrickModel/ExecuteDModXCalcResponse")]
        float ExecuteDModXCalc(float[] rawWater);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://localhost/IDigiDrickModel/ExecuteDModXCalc", ReplyAction="http://localhost/IDigiDrickModel/ExecuteDModXCalcResponse")]
        System.IAsyncResult BeginExecuteDModXCalc(float[] rawWater, System.AsyncCallback callback, object asyncState);
        
        float EndExecuteDModXCalc(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IDigiDrickModel/ExecuteDoseCalc", ReplyAction="http://localhost/IDigiDrickModel/ExecuteDoseCalcResponse")]
        float ExecuteDoseCalc(float[] rawWater);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://localhost/IDigiDrickModel/ExecuteDoseCalc", ReplyAction="http://localhost/IDigiDrickModel/ExecuteDoseCalcResponse")]
        System.IAsyncResult BeginExecuteDoseCalc(float[] rawWater, System.AsyncCallback callback, object asyncState);
        
        float EndExecuteDoseCalc(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDigiDrickModelChannel : DigiDrickClient.ServiceReferenceDM.IDigiDrickModel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteDModXCalcCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteDModXCalcCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteDoseCalcCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteDoseCalcCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DigiDrickModelClient : System.ServiceModel.ClientBase<DigiDrickClient.ServiceReferenceDM.IDigiDrickModel>, DigiDrickClient.ServiceReferenceDM.IDigiDrickModel {
        
        private BeginOperationDelegate onBeginModelSetupDelegate;
        
        private EndOperationDelegate onEndModelSetupDelegate;
        
        private System.Threading.SendOrPostCallback onModelSetupCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteDModXCalcDelegate;
        
        private EndOperationDelegate onEndExecuteDModXCalcDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteDModXCalcCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteDoseCalcDelegate;
        
        private EndOperationDelegate onEndExecuteDoseCalcDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteDoseCalcCompletedDelegate;
        
        public DigiDrickModelClient() {
        }
        
        public DigiDrickModelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DigiDrickModelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DigiDrickModelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DigiDrickModelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> ModelSetupCompleted;
        
        public event System.EventHandler<ExecuteDModXCalcCompletedEventArgs> ExecuteDModXCalcCompleted;
        
        public event System.EventHandler<ExecuteDoseCalcCompletedEventArgs> ExecuteDoseCalcCompleted;
        
        public void ModelSetup(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS) {
            base.Channel.ModelSetup(PATH_TO_PLS_MODEL_FILE, PATH_TO_PYTHON_INTERP, PATH_TO_PYTHON_SCRIPTS);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginModelSetup(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginModelSetup(PATH_TO_PLS_MODEL_FILE, PATH_TO_PYTHON_INTERP, PATH_TO_PYTHON_SCRIPTS, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndModelSetup(System.IAsyncResult result) {
            base.Channel.EndModelSetup(result);
        }
        
        private System.IAsyncResult OnBeginModelSetup(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string PATH_TO_PLS_MODEL_FILE = ((string)(inValues[0]));
            string PATH_TO_PYTHON_INTERP = ((string)(inValues[1]));
            string PATH_TO_PYTHON_SCRIPTS = ((string)(inValues[2]));
            return this.BeginModelSetup(PATH_TO_PLS_MODEL_FILE, PATH_TO_PYTHON_INTERP, PATH_TO_PYTHON_SCRIPTS, callback, asyncState);
        }
        
        private object[] OnEndModelSetup(System.IAsyncResult result) {
            this.EndModelSetup(result);
            return null;
        }
        
        private void OnModelSetupCompleted(object state) {
            if ((this.ModelSetupCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ModelSetupCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ModelSetupAsync(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS) {
            this.ModelSetupAsync(PATH_TO_PLS_MODEL_FILE, PATH_TO_PYTHON_INTERP, PATH_TO_PYTHON_SCRIPTS, null);
        }
        
        public void ModelSetupAsync(string PATH_TO_PLS_MODEL_FILE, string PATH_TO_PYTHON_INTERP, string PATH_TO_PYTHON_SCRIPTS, object userState) {
            if ((this.onBeginModelSetupDelegate == null)) {
                this.onBeginModelSetupDelegate = new BeginOperationDelegate(this.OnBeginModelSetup);
            }
            if ((this.onEndModelSetupDelegate == null)) {
                this.onEndModelSetupDelegate = new EndOperationDelegate(this.OnEndModelSetup);
            }
            if ((this.onModelSetupCompletedDelegate == null)) {
                this.onModelSetupCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnModelSetupCompleted);
            }
            base.InvokeAsync(this.onBeginModelSetupDelegate, new object[] {
                        PATH_TO_PLS_MODEL_FILE,
                        PATH_TO_PYTHON_INTERP,
                        PATH_TO_PYTHON_SCRIPTS}, this.onEndModelSetupDelegate, this.onModelSetupCompletedDelegate, userState);
        }
        
        public float ExecuteDModXCalc(float[] rawWater) {
            return base.Channel.ExecuteDModXCalc(rawWater);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginExecuteDModXCalc(float[] rawWater, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteDModXCalc(rawWater, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public float EndExecuteDModXCalc(System.IAsyncResult result) {
            return base.Channel.EndExecuteDModXCalc(result);
        }
        
        private System.IAsyncResult OnBeginExecuteDModXCalc(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float[] rawWater = ((float[])(inValues[0]));
            return this.BeginExecuteDModXCalc(rawWater, callback, asyncState);
        }
        
        private object[] OnEndExecuteDModXCalc(System.IAsyncResult result) {
            float retVal = this.EndExecuteDModXCalc(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteDModXCalcCompleted(object state) {
            if ((this.ExecuteDModXCalcCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteDModXCalcCompleted(this, new ExecuteDModXCalcCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteDModXCalcAsync(float[] rawWater) {
            this.ExecuteDModXCalcAsync(rawWater, null);
        }
        
        public void ExecuteDModXCalcAsync(float[] rawWater, object userState) {
            if ((this.onBeginExecuteDModXCalcDelegate == null)) {
                this.onBeginExecuteDModXCalcDelegate = new BeginOperationDelegate(this.OnBeginExecuteDModXCalc);
            }
            if ((this.onEndExecuteDModXCalcDelegate == null)) {
                this.onEndExecuteDModXCalcDelegate = new EndOperationDelegate(this.OnEndExecuteDModXCalc);
            }
            if ((this.onExecuteDModXCalcCompletedDelegate == null)) {
                this.onExecuteDModXCalcCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteDModXCalcCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteDModXCalcDelegate, new object[] {
                        rawWater}, this.onEndExecuteDModXCalcDelegate, this.onExecuteDModXCalcCompletedDelegate, userState);
        }
        
        public float ExecuteDoseCalc(float[] rawWater) {
            return base.Channel.ExecuteDoseCalc(rawWater);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginExecuteDoseCalc(float[] rawWater, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteDoseCalc(rawWater, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public float EndExecuteDoseCalc(System.IAsyncResult result) {
            return base.Channel.EndExecuteDoseCalc(result);
        }
        
        private System.IAsyncResult OnBeginExecuteDoseCalc(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float[] rawWater = ((float[])(inValues[0]));
            return this.BeginExecuteDoseCalc(rawWater, callback, asyncState);
        }
        
        private object[] OnEndExecuteDoseCalc(System.IAsyncResult result) {
            float retVal = this.EndExecuteDoseCalc(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteDoseCalcCompleted(object state) {
            if ((this.ExecuteDoseCalcCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteDoseCalcCompleted(this, new ExecuteDoseCalcCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteDoseCalcAsync(float[] rawWater) {
            this.ExecuteDoseCalcAsync(rawWater, null);
        }
        
        public void ExecuteDoseCalcAsync(float[] rawWater, object userState) {
            if ((this.onBeginExecuteDoseCalcDelegate == null)) {
                this.onBeginExecuteDoseCalcDelegate = new BeginOperationDelegate(this.OnBeginExecuteDoseCalc);
            }
            if ((this.onEndExecuteDoseCalcDelegate == null)) {
                this.onEndExecuteDoseCalcDelegate = new EndOperationDelegate(this.OnEndExecuteDoseCalc);
            }
            if ((this.onExecuteDoseCalcCompletedDelegate == null)) {
                this.onExecuteDoseCalcCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteDoseCalcCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteDoseCalcDelegate, new object[] {
                        rawWater}, this.onEndExecuteDoseCalcDelegate, this.onExecuteDoseCalcCompletedDelegate, userState);
        }
    }
}
