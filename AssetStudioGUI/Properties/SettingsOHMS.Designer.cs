﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetStudioGUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class SettingsOHMS : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsOHMS defaultInstance = ((SettingsOHMS)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsOHMS())));
        
        public static SettingsOHMS Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ohmsCreateNew {
            get {
                return ((bool)(this["ohmsCreateNew"]));
            }
            set {
                this["ohmsCreateNew"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ohmsLastFolder {
            get {
                return ((string)(this["ohmsLastFolder"]));
            }
            set {
                this["ohmsLastFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool indentedJson {
            get {
                return ((bool)(this["indentedJson"]));
            }
            set {
                this["indentedJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint language {
            get {
                return ((uint)(this["language"]));
            }
            set {
                this["language"] = value;
            }
        }
    }
}
