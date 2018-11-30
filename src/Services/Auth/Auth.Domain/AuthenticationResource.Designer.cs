﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Riverside.Cms.Services.Auth.Domain {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AuthenticationResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AuthenticationResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Riverside.Cms.Services.Auth.Domain.AuthenticationResource", typeof(AuthenticationResource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address is invalid.
        /// </summary>
        internal static string LogonEmailInvalidMessage {
            get {
                return ResourceManager.GetString("LogonEmailInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        internal static string LogonEmailLabel {
            get {
                return ResourceManager.GetString("LogonEmailLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address cannot be more than {1} characters in length.
        /// </summary>
        internal static string LogonEmailMaxLengthMessage {
            get {
                return ResourceManager.GetString("LogonEmailMaxLengthMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address is required.
        /// </summary>
        internal static string LogonEmailRequiredMessage {
            get {
                return ResourceManager.GetString("LogonEmailRequiredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        internal static string LogonPasswordLabel {
            get {
                return ResourceManager.GetString("LogonPasswordLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is required.
        /// </summary>
        internal static string LogonPasswordRequiredMessage {
            get {
                return ResourceManager.GetString("LogonPasswordRequiredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remember me?.
        /// </summary>
        internal static string LogonRememberMeLabel {
            get {
                return ResourceManager.GetString("LogonRememberMeLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address or password is invalid.
        /// </summary>
        internal static string LogonUserCredentialsInvalidMessage {
            get {
                return ResourceManager.GetString("LogonUserCredentialsInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address or password is invalid.
        /// </summary>
        internal static string LogonUserDisabledMessage {
            get {
                return ResourceManager.GetString("LogonUserDisabledMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account locked out. Please try again later..
        /// </summary>
        internal static string LogonUserLockedOutMessage {
            get {
                return ResourceManager.GetString("LogonUserLockedOutMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address or password is invalid.
        /// </summary>
        internal static string LogonUserUnconfirmedMessage {
            get {
                return ResourceManager.GetString("LogonUserUnconfirmedMessage", resourceCulture);
            }
        }
    }
}
