﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deregistering id={0}.
        /// </summary>
        public static string CommunicationServer_Deregister_ {
            get {
                return ResourceManager.GetString("CommunicationServer_Deregister_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Register Message, Sending Register Response id={0}.
        /// </summary>
        public static string CommunicationServer_MsgHandler_Register_ {
            get {
                return ResourceManager.GetString("CommunicationServer_MsgHandler_Register_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status Message id={0}, sending {1}.
        /// </summary>
        public static string CommunicationServer_MsgHandler_Status_ {
            get {
                return ResourceManager.GetString("CommunicationServer_MsgHandler_Status_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sent {0} bytes to client..
        /// </summary>
        public static string CommunicationServer_SendCallback_Sent__0__bytes_to_client_ {
            get {
                return ResourceManager.GetString("CommunicationServer_SendCallback_Sent__0__bytes_to_client_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accepted connection from {0}.
        /// </summary>
        public static string CommunicationServer_StartListening_Accepted_connection_from__0_ {
            get {
                return ResourceManager.GetString("CommunicationServer_StartListening_Accepted_connection_from__0_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started listening on: {0}.
        /// </summary>
        public static string CommunicationServer_StartListening_Started_listening_on___0_ {
            get {
                return ResourceManager.GetString("CommunicationServer_StartListening_Started_listening_on___0_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;xs:element name=&quot;DivideProblem&quot;&gt;
        ///  &lt;xs:complexType&gt;
        ///    &lt;xs:sequence&gt;
        ///      &lt;!-- the problem type name as given by TaskSolver and Client --&gt;
        ///      &lt;xs:element name=&quot;ProblemType&quot; type=&quot;xs:string&quot; /&gt;
        ///      &lt;!-- the ID of the problem instance assigned by the server --&gt;
        ///      &lt;xs:element name=&quot;Id&quot; type= [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DivideProblem {
            get {
                return ResourceManager.GetString("DivideProblem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!-- The Error message is used to inform components that they or their tasks are unknown to the server
        ///(possibly because the data have not been synchronized and switch to BackupCS occured)
        ///--&gt;
        ///&lt;!-- Another case when Error message is used is when an exception occures on a component (TM or CN)
        ///to inform the CS or the client to inform about the exception that occured on the CS  --&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetN [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Computational Node started successfully.
        /// </summary>
        public static string NodeUserInterface_Main_Computational_Node_started_successfully {
            get {
                return ResourceManager.GetString("NodeUserInterface_Main_Computational_Node_started_successfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;NoOperation&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- The list of backup servers --&gt;
        ///        &lt;xs:element name=&quot;BackupCommunicationServers&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element name=&quot;BackupCommunicationServer&quot; minOccurs=&quot;0&quot;&gt;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string NoOperation {
            get {
                return ResourceManager.GetString("NoOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; 
        ///           targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;xs:element name=&quot;SolvePartialProblems&quot;&gt;
        ///  &lt;xs:complexType&gt;
        ///    &lt;xs:sequence&gt;
        ///      &lt;!-- the problem type name as given by TaskSolver and Client --&gt;
        ///      &lt;xs:element name=&quot;ProblemType&quot; type=&quot;xs:string&quot; /&gt;
        ///      &lt;!-- the ID of the problem instance assigned by the server --&gt;
        ///      &lt;xs:eleme [rest of string was truncated]&quot;;.
        /// </summary>
        public static string PartialProblems {
            get {
                return ResourceManager.GetString("PartialProblems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Register&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- defines the type of node (either TM, CN or CS) --&gt;
        ///        &lt;xs:element name=&quot;Type&quot;&gt;
        ///          &lt;xs:simpleType&gt;
        ///            &lt;xs:restriction base=&quot;xs:string&quot;&gt;
        ///              &lt;xs:enumeration value=&quot;TaskManager&quot; /&gt;
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Register {
            get {
                return ResourceManager.GetString("Register", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;RegisterResponse&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- the ID assigned by the Communication Server --&gt;
        ///        &lt;xs:element name=&quot;Id&quot; type=&quot;xs:unsignedLong&quot; /&gt;
        ///        &lt;!-- the communication timeout in seconds configured on Communication Server --&gt;
        ///        &lt;xs:elem [rest of string was truncated]&quot;;.
        /// </summary>
        public static string RegisterResponse {
            get {
                return ResourceManager.GetString("RegisterResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Communication Server started successfully.
        /// </summary>
        public static string ServerUserInterface_Main_Communication_Server_started_successfully {
            get {
                return ResourceManager.GetString("ServerUserInterface_Main_Communication_Server_started_successfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong Arguments.
        /// </summary>
        public static string ServerUserInterface_Main_Wrong_Arguments {
            get {
                return ResourceManager.GetString("ServerUserInterface_Main_Wrong_Arguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Solutions&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- the problem type name as given by TaskSolver and Client --&gt;
        ///        &lt;xs:element name=&quot;ProblemType&quot; type=&quot;xs:string&quot; /&gt;
        ///        &lt;!-- the ID of the problem instance assigned by the server --&gt;
        ///        &lt;xs:element name= [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Solution {
            get {
                return ResourceManager.GetString("Solution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;SolutionRequest&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- the ID of the problem instance assigned by the server --&gt;
        ///        &lt;xs:element name=&quot;Id&quot; type=&quot;xs:unsignedLong&quot; /&gt;
        ///      &lt;/xs:sequence&gt;
        ///    &lt;/xs:complexType&gt;
        ///  &lt;/xs:element&gt;
        ///&lt;/xs:schema&gt;.
        /// </summary>
        public static string SolutionRequest {
            get {
                return ResourceManager.GetString("SolutionRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;xs:element name=&quot;SolveRequest&quot;&gt;
        ///  &lt;xs:complexType&gt;
        ///    &lt;xs:sequence&gt;
        ///      &lt;!-- the name of the type as given by TaskSolver --&gt;
        ///      &lt;xs:element name=&quot;ProblemType&quot; type=&quot;xs:string&quot; /&gt;
        ///      &lt;!-- the optional time restriction for solving the problem (in ms) --&gt;
        ///      &lt;xs:element minOccurs=&quot;0&quot; name=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string SolveRequest {
            get {
                return ResourceManager.GetString("SolveRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot;
        ///           xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;SolveRequestResponse&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;!-- the ID of the problem instance assigned by the server --&gt;
        ///        &lt;xs:element name=&quot;Id&quot; type=&quot;xs:unsignedLong&quot; /&gt;
        ///      &lt;/xs:sequence&gt;
        ///    &lt;/xs:complexType&gt;
        ///  &lt;/xs:element&gt;
        ///&lt;/xs:schema&gt;.
        /// </summary>
        public static string SolveRequestResponse {
            get {
                return ResourceManager.GetString("SolveRequestResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot;  targetNamespace=&quot;http://www.mini.pw.edu.pl/ucc/&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;xs:element name=&quot;Status&quot;&gt;
        ///  &lt;xs:complexType&gt;
        ///    &lt;xs:sequence&gt;
        ///      &lt;!-- the ID of node (the one assigned by server) --&gt;
        ///      &lt;xs:element name=&quot;Id&quot; type=&quot;xs:unsignedLong&quot; /&gt;
        ///      &lt;!-- list of statuses for different threads --&gt;
        ///      &lt;xs:element name=&quot;Threads&quot;&gt;
        ///        &lt;xs:complexType&gt;
        ///          &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Status {
            get {
                return ResourceManager.GetString("Status", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Message.
        /// </summary>
        public static string SystemComponent_MsgHandler_Error_Error_Message {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_Error_Error_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NoOperation Message.
        /// </summary>
        public static string SystemComponent_MsgHandler_NoOperation_NoOperation_Message {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_NoOperation_NoOperation_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RegisterResponse Message id={0}.
        /// </summary>
        public static string SystemComponent_MsgHandler_RegisterResponse_ {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_RegisterResponse_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message Not send for component type {0} with id {1}.
        /// </summary>
        public static string SystemComponent_MsgHandler_RegisterResponse_Message_Not_send_for_component_type__0__with_id__1_ {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_RegisterResponse_Message_Not_send_for_component_type__" +
                        "0__with_id__1_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Negative Id for component.
        /// </summary>
        public static string SystemComponent_MsgHandler_RegisterResponse_Negative_Id_for_component {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_RegisterResponse_Negative_Id_for_component", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending Status.
        /// </summary>
        public static string SystemComponent_MsgHandler_RegisterResponse_Sending_Status {
            get {
                return ResourceManager.GetString("SystemComponent_MsgHandler_RegisterResponse_Sending_Status", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection was killed by host.
        /// </summary>
        public static string SystemComponent_ReceiveResponse_Connection_was_killed_by_host {
            get {
                return ResourceManager.GetString("SystemComponent_ReceiveResponse_Connection_was_killed_by_host", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Register Message Not Send.
        /// </summary>
        public static string SystemComponent_SendRegisterMessage_Register_Message_Not_Send {
            get {
                return ResourceManager.GetString("SystemComponent_SendRegisterMessage_Register_Message_Not_Send", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task Manager started successfully.
        /// </summary>
        public static string TaskManagerUserInterface_Main_Task_Manager_started_successfully {
            get {
                return ResourceManager.GetString("TaskManagerUserInterface_Main_Task_Manager_started_successfully", resourceCulture);
            }
        }
    }
}
