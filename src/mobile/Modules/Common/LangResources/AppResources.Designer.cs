﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.LangResources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Common.LangResources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string Scores {
            get {
                return ResourceManager.GetString("Scores", resourceCulture);
            }
        }
        
        public static string Live {
            get {
                return ResourceManager.GetString("Live", resourceCulture);
            }
        }
        
        public static string Leagues {
            get {
                return ResourceManager.GetString("Leagues", resourceCulture);
            }
        }
        
        public static string Favorites {
            get {
                return ResourceManager.GetString("Favorites", resourceCulture);
            }
        }
        
        public static string TVSchedule {
            get {
                return ResourceManager.GetString("TVSchedule", resourceCulture);
            }
        }
        
        public static string News {
            get {
                return ResourceManager.GetString("News", resourceCulture);
            }
        }
        
        public static string FullTime {
            get {
                return ResourceManager.GetString("FullTime", resourceCulture);
            }
        }
    }
}