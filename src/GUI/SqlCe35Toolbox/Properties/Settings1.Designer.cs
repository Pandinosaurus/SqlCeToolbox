﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErikEJ.SqlCeToolbox {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DropTargetTables {
            get {
                return ((bool)(this["DropTargetTables"]));
            }
            set {
                this["DropTargetTables"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowBinaryValuesInResult {
            get {
                return ((bool)(this["ShowBinaryValuesInResult"]));
            }
            set {
                this["ShowBinaryValuesInResult"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowResultInGrid {
            get {
                return ((bool)(this["ShowResultInGrid"]));
            }
            set {
                this["ShowResultInGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayDescriptionTable {
            get {
                return ((bool)(this["DisplayDescriptionTable"]));
            }
            set {
                this["DisplayDescriptionTable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IncludeSystemTablesInDocumentation {
            get {
                return ((bool)(this["IncludeSystemTablesInDocumentation"]));
            }
            set {
                this["IncludeSystemTablesInDocumentation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisplayObjectProperties {
            get {
                return ((bool)(this["DisplayObjectProperties"]));
            }
            set {
                this["DisplayObjectProperties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int MaxRowsToEdit {
            get {
                return ((int)(this["MaxRowsToEdit"]));
            }
            set {
                this["MaxRowsToEdit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IgnoreIdentityInInsertScript {
            get {
                return ((bool)(this["IgnoreIdentityInInsertScript"]));
            }
            set {
                this["IgnoreIdentityInInsertScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeepSchemaNames {
            get {
                return ((bool)(this["KeepSchemaNames"]));
            }
            set {
                this["KeepSchemaNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MaxColumnWidth {
            get {
                return ((int)(this["MaxColumnWidth"]));
            }
            set {
                this["MaxColumnWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PreferDDEX {
            get {
                return ((bool)(this["PreferDDEX"]));
            }
            set {
                this["PreferDDEX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PreserveSqlDates {
            get {
                return ((bool)(this["PreserveSqlDates"]));
            }
            set {
                this["PreserveSqlDates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PromptToSaveChangedScript {
            get {
                return ((bool)(this["PromptToSaveChangedScript"]));
            }
            set {
                this["PromptToSaveChangedScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MultiLineTextEntry {
            get {
                return ((bool)(this["MultiLineTextEntry"]));
            }
            set {
                this["MultiLineTextEntry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.sdf")]
        public string FileFilterSqlCe {
            get {
                return ((string)(this["FileFilterSqlCe"]));
            }
            set {
                this["FileFilterSqlCe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.db;*.db3;*.sqlite;*.sqlite3;*.dat")]
        public string FileFilterSqlite {
            get {
                return ((string)(this["FileFilterSqlite"]));
            }
            set {
                this["FileFilterSqlite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TruncateSQLiteStrings {
            get {
                return ((bool)(this["TruncateSQLiteStrings"]));
            }
            set {
                this["TruncateSQLiteStrings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowNullValuesAsNULL {
            get {
                return ((bool)(this["ShowNullValuesAsNULL"]));
            }
            set {
                this["ShowNullValuesAsNULL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ParticipateInTelemetry {
            get {
                return ((bool)(this["ParticipateInTelemetry"]));
            }
            set {
                this["ParticipateInTelemetry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableEditorKeyboardShortcuts {
            get {
                return ((bool)(this["DisableEditorKeyboardShortcuts"]));
            }
            set {
                this["DisableEditorKeyboardShortcuts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseClassicGrid {
            get {
                return ((bool)(this["UseClassicGrid"]));
            }
            set {
                this["UseClassicGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MakeSQLiteDatetimeReadOnly {
            get {
                return ((bool)(this["MakeSQLiteDatetimeReadOnly"]));
            }
            set {
                this["MakeSQLiteDatetimeReadOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GetObjectExplorerDatabases {
            get {
                return ((bool)(this["GetObjectExplorerDatabases"]));
            }
            set {
                this["GetObjectExplorerDatabases"] = value;
            }
        }
    }
}
