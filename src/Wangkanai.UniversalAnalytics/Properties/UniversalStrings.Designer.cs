﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics;
using System.Globalization;

namespace Wangkanai.UniversalAnalytics.Internal {
    using System;
    using System.Reflection;
    
    public static class UniversalStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;        
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Wangkanai.UniversalAnalytics.Properties.UniversalStrings", typeof(UniversalStrings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = ResourceManager.GetString(name);
            Debug.Assert(value != null);
            if(formatterNames != null)
                for (var i = 0; i < formatterNames.Length; i++)
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            return value;
        }

        /// <summary>
        ///    The string argument '{argumentName}' cannot be empty.
        /// </summary>
        public static string ArgumentIsEmpty (object argument){
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argument);            
        }
    }
}
