﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property UserUnits() As String
            Get
                Return CType(Me("UserUnits"),String)
            End Get
            Set
                Me("UserUnits") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowTips() As Boolean
            Get
                Return CType(Me("ShowTips"),Boolean)
            End Get
            Set
                Me("ShowTips") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property BackupFolder() As String
            Get
                Return CType(Me("BackupFolder"),String)
            End Get
            Set
                Me("BackupFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property BackupActivated() As Boolean
            Get
                Return CType(Me("BackupActivated"),Boolean)
            End Get
            Set
                Me("BackupActivated") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property BackupInterval() As Integer
            Get
                Return CType(Me("BackupInterval"),Integer)
            End Get
            Set
                Me("BackupInterval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BackupFiles() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("BackupFiles"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("BackupFiles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("en")>  _
        Public Property CultureInfo() As String
            Get
                Return CType(Me("CultureInfo"),String)
            End Get
            Set
                Me("CultureInfo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property GeneralSettings() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("GeneralSettings"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("GeneralSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ChemSepDatabasePath() As String
            Get
                Return CType(Me("ChemSepDatabasePath"),String)
            End Get
            Set
                Me("ChemSepDatabasePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ReplaceComps() As Boolean
            Get
                Return CType(Me("ReplaceComps"),Boolean)
            End Get
            Set
                Me("ReplaceComps") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserDatabases() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserDatabases"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserDatabases") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ScriptPaths() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("ScriptPaths"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("ScriptPaths") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RedirectOutput() As Boolean
            Get
                Return CType(Me("RedirectOutput"),Boolean)
            End Get
            Set
                Me("RedirectOutput") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CheckForUpdates() As Boolean
            Get
                Return CType(Me("CheckForUpdates"),Boolean)
            End Get
            Set
                Me("CheckForUpdates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpgradeRequired() As Boolean
            Get
                Return CType(Me("UpgradeRequired"),Boolean)
            End Get
            Set
                Me("UpgradeRequired") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property EnableParallelProcessing() As Boolean
            Get
                Return CType(Me("EnableParallelProcessing"),Boolean)
            End Get
            Set
                Me("EnableParallelProcessing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-1")>  _
        Public Property MaxDegreeOfParallelism() As Integer
            Get
                Return CType(Me("MaxDegreeOfParallelism"),Integer)
            End Get
            Set
                Me("MaxDegreeOfParallelism") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnableGPUProcessing() As Boolean
            Get
                Return CType(Me("EnableGPUProcessing"),Boolean)
            End Get
            Set
                Me("EnableGPUProcessing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SelectedGPU() As String
            Get
                Return CType(Me("SelectedGPU"),String)
            End Get
            Set
                Me("SelectedGPU") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property CudafyTarget() As Integer
            Get
                Return CType(Me("CudafyTarget"),Integer)
            End Get
            Set
                Me("CudafyTarget") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CudafyDeviceID() As Integer
            Get
                Return CType(Me("CudafyDeviceID"),Integer)
            End Get
            Set
                Me("CudafyDeviceID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserInteractionsDatabases() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserInteractionsDatabases"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserInteractionsDatabases") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowCoolPropWarning() As Boolean
            Get
                Return CType(Me("ShowCoolPropWarning"),Boolean)
            End Get
            Set
                Me("ShowCoolPropWarning") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property SolverMode() As Integer
            Get
                Return CType(Me("SolverMode"),Integer)
            End Get
            Set
                Me("SolverMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServiceBusConnectionString() As String
            Get
                Return CType(Me("ServiceBusConnectionString"),String)
            End Get
            Set
                Me("ServiceBusConnectionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property DebugLevel() As Integer
            Get
                Return CType(Me("DebugLevel"),Integer)
            End Get
            Set
                Me("DebugLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServerIPAddress() As String
            Get
                Return CType(Me("ServerIPAddress"),String)
            End Get
            Set
                Me("ServerIPAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ServerPort() As String
            Get
                Return CType(Me("ServerPort"),String)
            End Get
            Set
                Me("ServerPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("360")>  _
        Public Property SolverTimeoutSeconds() As Integer
            Get
                Return CType(Me("SolverTimeoutSeconds"),Integer)
            End Get
            Set
                Me("SolverTimeoutSeconds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SolverBreakOnException() As Boolean
            Get
                Return CType(Me("SolverBreakOnException"),Boolean)
            End Get
            Set
                Me("SolverBreakOnException") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property StorePreviousSolutions() As Boolean
            Get
                Return CType(Me("StorePreviousSolutions"),Boolean)
            End Get
            Set
                Me("StorePreviousSolutions") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowWhatsNew() As Boolean
            Get
                Return CType(Me("ShowWhatsNew"),Boolean)
            End Get
            Set
                Me("ShowWhatsNew") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SaveBackupFile() As Boolean
            Get
                Return CType(Me("SaveBackupFile"),Boolean)
            End Get
            Set
                Me("SaveBackupFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property MaxThreadMultiplier() As Integer
            Get
                Return CType(Me("MaxThreadMultiplier"),Integer)
            End Get
            Set
                Me("MaxThreadMultiplier") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property TaskScheduler() As Integer
            Get
                Return CType(Me("TaskScheduler"),Integer)
            End Get
            Set
                Me("TaskScheduler") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseSIMDExtensions() As Boolean
            Get
                Return CType(Me("UseSIMDExtensions"),Boolean)
            End Get
            Set
                Me("UseSIMDExtensions") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowSimulationToolStrip() As Boolean
            Get
                Return CType(Me("ShowSimulationToolStrip"),Boolean)
            End Get
            Set
                Me("ShowSimulationToolStrip") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowFlowsheetToolStrip() As Boolean
            Get
                Return CType(Me("ShowFlowsheetToolStrip"),Boolean)
            End Get
            Set
                Me("ShowFlowsheetToolStrip") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowUnitsToolStrip() As Boolean
            Get
                Return CType(Me("ShowUnitsToolStrip"),Boolean)
            End Get
            Set
                Me("ShowUnitsToolStrip") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property ClipboardCopyMode_Compounds() As Integer
            Get
                Return CType(Me("ClipboardCopyMode_Compounds"),Integer)
            End Get
            Set
                Me("ClipboardCopyMode_Compounds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ClipboardCopyMode_PropertyPackages() As Integer
            Get
                Return CType(Me("ClipboardCopyMode_PropertyPackages"),Integer)
            End Get
            Set
                Me("ClipboardCopyMode_PropertyPackages") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UndoRedo_RecalculateFlowsheet() As Boolean
            Get
                Return CType(Me("UndoRedo_RecalculateFlowsheet"),Boolean)
            End Get
            Set
                Me("UndoRedo_RecalculateFlowsheet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("351")>  _
        Public Property ObjectSelectorSplitterDistance1() As Integer
            Get
                Return CType(Me("ObjectSelectorSplitterDistance1"),Integer)
            End Get
            Set
                Me("ObjectSelectorSplitterDistance1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("86")>  _
        Public Property ObjectSelectorSplitterDistance2() As Integer
            Get
                Return CType(Me("ObjectSelectorSplitterDistance2"),Integer)
            End Get
            Set
                Me("ObjectSelectorSplitterDistance2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("84")>  _
        Public Property ObjectSelectorSplitterDistance3() As Integer
            Get
                Return CType(Me("ObjectSelectorSplitterDistance3"),Integer)
            End Get
            Set
                Me("ObjectSelectorSplitterDistance3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CloseFormsOnDeselecting() As Boolean
            Get
                Return CType(Me("CloseFormsOnDeselecting"),Boolean)
            End Get
            Set
                Me("CloseFormsOnDeselecting") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property DefaultEditorLocation() As Integer
            Get
                Return CType(Me("DefaultEditorLocation"),Integer)
            End Get
            Set
                Me("DefaultEditorLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property AutomaticUpdates() As Boolean
            Get
                Return CType(Me("AutomaticUpdates"),Boolean)
            End Get
            Set
                Me("AutomaticUpdates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property EnableMultipleObjectEditors() As Boolean
            Get
                Return CType(Me("EnableMultipleObjectEditors"),Boolean)
            End Get
            Set
                Me("EnableMultipleObjectEditors") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SimulationUpgradeWarning() As Boolean
            Get
                Return CType(Me("SimulationUpgradeWarning"),Boolean)
            End Get
            Set
                Me("SimulationUpgradeWarning") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public ReadOnly Property PreviewVersion() As String
            Get
                Return CType(Me("PreviewVersion"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property HideSolidPhase_CO() As Boolean
            Get
                Return CType(Me("HideSolidPhase_CO"),Boolean)
            End Get
            Set
                Me("HideSolidPhase_CO") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property IgnoreCompoundPropertiesOnLoad() As Boolean
            Get
                Return CType(Me("IgnoreCompoundPropertiesOnLoad"),Boolean)
            End Get
            Set
                Me("IgnoreCompoundPropertiesOnLoad") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property OctavePath() As String
            Get
                Return CType(Me("OctavePath"),String)
            End Get
            Set
                Me("OctavePath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property OctaveProcessTimeout() As Double
            Get
                Return CType(Me("OctaveProcessTimeout"),Double)
            End Get
            Set
                Me("OctaveProcessTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CurrentPlatform() As String
            Get
                Return CType(Me("CurrentPlatform"),String)
            End Get
            Set
                Me("CurrentPlatform") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CurrentEnvironment() As Integer
            Get
                Return CType(Me("CurrentEnvironment"),Integer)
            End Get
            Set
                Me("CurrentEnvironment") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PythonPath() As String
            Get
                Return CType(Me("PythonPath"),String)
            End Get
            Set
                Me("PythonPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property PythonProcessTimeout() As Double
            Get
                Return CType(Me("PythonProcessTimeout"),Double)
            End Get
            Set
                Me("PythonProcessTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property InspectorEnabled() As Boolean
            Get
                Return CType(Me("InspectorEnabled"),Boolean)
            End Get
            Set
                Me("InspectorEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ObjectEditor() As Integer
            Get
                Return CType(Me("ObjectEditor"),Integer)
            End Get
            Set
                Me("ObjectEditor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DisplayPFDTip() As Boolean
            Get
                Return CType(Me("DisplayPFDTip"),Boolean)
            End Get
            Set
                Me("DisplayPFDTip") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property FlowsheetRenderer() As Integer
            Get
                Return CType(Me("FlowsheetRenderer"),Integer)
            End Get
            Set
                Me("FlowsheetRenderer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property FlowsheetAntiAliasing() As Boolean
            Get
                Return CType(Me("FlowsheetAntiAliasing"),Boolean)
            End Get
            Set
                Me("FlowsheetAntiAliasing") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DoubleClickToEdit() As Boolean
            Get
                Return CType(Me("DoubleClickToEdit"),Boolean)
            End Get
            Set
                Me("DoubleClickToEdit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsd=""http://www.w3."& _ 
            "org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" />")>  _
        Public Property MostRecentFiles() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("MostRecentFiles"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("MostRecentFiles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property WeatherPanelVisible() As Boolean
            Get
                Return CType(Me("WeatherPanelVisible"),Boolean)
            End Get
            Set
                Me("WeatherPanelVisible") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CurrentVersion() As String
            Get
                Return CType(Me("CurrentVersion"),String)
            End Get
            Set
                Me("CurrentVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UserTypeSent() As Boolean
            Get
                Return CType(Me("UserTypeSent"),Boolean)
            End Get
            Set
                Me("UserTypeSent") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property LoadExtensionsAndPlugins() As Boolean
            Get
                Return CType(Me("LoadExtensionsAndPlugins"),Boolean)
            End Get
            Set
                Me("LoadExtensionsAndPlugins") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.DWSIM.My.MySettings
            Get
                Return Global.DWSIM.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
