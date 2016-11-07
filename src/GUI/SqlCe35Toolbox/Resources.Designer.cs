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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ErikEJ.SqlCeToolbox.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SQLite/SQL Server Compact Toolbox.
        /// </summary>
        internal static string App {
            get {
                return ResourceManager.GetString("App", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer (whole number) data from –2^63 (–9,223,372,036,854,775,808) through 2^63–1 (9,223,372,036,854,775,807).
        ///Storage size is 8 bytes..
        /// </summary>
        internal static string bigint {
            get {
                return ResourceManager.GetString("bigint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fixed-length binary data with a maximum length of 8000 bytes. Default length = 1.
        ///Storage size is fixed, which is the length in bytes declared in the type..
        /// </summary>
        internal static string binary {
            get {
                return ResourceManager.GetString("binary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer data with a value of either 1 or 0.
        ///Storage size is 1 bit..
        /// </summary>
        internal static string bit {
            get {
                return ResourceManager.GetString("bit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create tool window..
        /// </summary>
        internal static string CanNotCreateWindow {
            get {
                return ResourceManager.GetString("CanNotCreateWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Data.SqlServerCe;
        ///using System.Text;
        ///
        ///public class MergeReplication
        ///{
        ///    public static void Synchronize()
        ///    {
        ///        SqlCeReplication repl = new SqlCeReplication();  
        ///
        ///#ReplParams#
        ///        try
        ///        {
        ///            repl.AddSubscription(AddOption.ExistingDatabase);
        ///            repl.Synchronize();
        ///        }
        ///        catch (SqlCeException e)
        ///        {
        ///            Console.WriteLine(ShowErrors(e));
        ///        }
        ///    }
        ///
        ///    private static string ShowErrors(SqlCeExce [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ClassTemplateCsharp {
            get {
                return ResourceManager.GetString("ClassTemplateCsharp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Date and time data from January 1, 1753, to December 31, 9999, with an accuracy of one three-hundredth second, or 3.33 milliseconds. Values are rounded to increments of .000, .003, or .007 milliseconds. 
        ///Stored as two 4-byte integers. 
        ///The first 4 bytes store the number of days before or after the base date , January 1, 1900. The base date is the system&apos;s reference date. 
        ///Values for datetime earlier than January 1, 1753, are not permitted. The other 4 bytes store the time of day represented as the number [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string datetime {
            get {
                return ResourceManager.GetString("datetime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Floating point number data from –1.79E +308 through 1.79E+308.
        ///Storage size is 8 bytes..
        /// </summary>
        internal static string floating {
            get {
                return ResourceManager.GetString("floating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!-- XSL Template for converting the XML documentation to HTML --&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;&gt;
        ///    &lt;xsl:output
        ///        method=&quot;html&quot;
        ///        indent=&quot;yes&quot;
        ///        omit-xml-declaration=&quot;yes&quot;
        ///        media-type=&quot;text/html&quot;
        ///        doctype-public=&quot;-//W3C//DTD XHTML 1.0 Strict//EN&quot;
        ///        doctype-system=&quot;http://www.w3.org/TR/xhtml1/DTD/x [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Html {
            get {
                return ResourceManager.GetString("Html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable-length binary data with a maximum length of 2^30–1 (1,073,741,823) bytes.
        ///Storage is the length of the value in bytes..
        /// </summary>
        internal static string image {
            get {
                return ResourceManager.GetString("image", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer (whole number) data from –2^31 (–2,147,483,648) through 2^31–1 (2,147,483,647).
        ///Storage size is 4 bytes..
        /// </summary>
        internal static string integer {
            get {
                return ResourceManager.GetString("integer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] LocalDatabaseConnectionStringBuilder {
            get {
                object obj = ResourceManager.GetObject("LocalDatabaseConnectionStringBuilder", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Monetary data values from (–2^63/10000) (–922,337,203,685,477.5808) through 2^63–1 (922,337,203,685,477.5807), with accuracy to a ten-thousandth of a monetary unit.
        ///Storage size is 8 bytes.
        /// </summary>
        internal static string money {
            get {
                return ResourceManager.GetString("money", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fixed-length Unicode data with a maximum length of 4000 characters. Default length = 1.
        ///Storage size, in bytes, is two times the number of characters entered..
        /// </summary>
        internal static string nchar {
            get {
                return ResourceManager.GetString("nchar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable-length Unicode data with a maximum length of (2^30–2)/2 (536,870,911) characters.
        ///Storage size, in bytes, is two times the number of characters entered..
        /// </summary>
        internal static string ntext {
            get {
                return ResourceManager.GetString("ntext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fixed-precision and scale-numeric data from –10^38+1 through 10^38–1. The p variable specifies precision and can vary between 1 and 38. The s variable specifies scale and can vary between 0 and p.
        ///Storage size is 19 bytes..
        /// </summary>
        internal static string numeric {
            get {
                return ResourceManager.GetString("numeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable-length Unicode data with a length of 1 to 4000 characters. Default length = 1.
        ///Storage size, in bytes, is two times the number of characters entered..
        /// </summary>
        internal static string nvarchar {
            get {
                return ResourceManager.GetString("nvarchar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Floating precision number data from –3.40E+38 through 3.40E+38.
        ///Storage size is 4 bytes..
        /// </summary>
        internal static string real {
            get {
                return ResourceManager.GetString("real", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap refresh_16xLG {
            get {
                object obj = ResourceManager.GetObject("refresh_16xLG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;!-- Stylesheet for creating ReportViewer RDLC documents --&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot;
        ///  xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        ///  xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot;
        ///  xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///  xmlns:msdata=&quot;urn:schemas-microsoft-com:xml-msdata&quot;
        ///  xmlns:rd=&quot;http://schemas.microsoft.com/SQLServer/reporting/reportdesigner&quot;  xmlns=&quot;http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition&quot;
        ///	  &gt;
        ///
        ///  &lt;xsl:variable name=&quot;mva [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string report {
            get {
                return ResourceManager.GetString("report", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is an automatically generated unique binary number.*
        ///Storage size is 8 bytes..
        /// </summary>
        internal static string rowversion {
            get {
                return ResourceManager.GetString("rowversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap saveHS {
            get {
                object obj = ResourceManager.GetObject("saveHS", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap search_glyph {
            get {
                object obj = ResourceManager.GetObject("search_glyph", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer data from –32,768 to 32,767.
        ///Storage size is 2 bytes..
        /// </summary>
        internal static string smallint {
            get {
                return ResourceManager.GetString("smallint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] SqlCe35AddinStore {
            get {
                object obj = ResourceManager.GetObject("SqlCe35AddinStore", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] SqlCe40AddinStore {
            get {
                object obj = ResourceManager.GetObject("SqlCe40AddinStore", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] SqlCeSyntax {
            get {
                object obj = ResourceManager.GetObject("SqlCeSyntax", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Data.SqlServerCe.3.5.
        /// </summary>
        internal static string SqlCompact35InvariantName {
            get {
                return ResourceManager.GetString("SqlCompact35InvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 303D8BB1-D62A-4560-9742-79C93E828222.
        /// </summary>
        internal static string SqlCompact35PrivateProvider {
            get {
                return ResourceManager.GetString("SqlCompact35PrivateProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 7c602b5b-accb-4acd-9dc0-ca66388c1533.
        /// </summary>
        internal static string SqlCompact35Provider {
            get {
                return ResourceManager.GetString("SqlCompact35Provider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Data.SqlServerCe.4.0.
        /// </summary>
        internal static string SqlCompact40InvariantName {
            get {
                return ResourceManager.GetString("SqlCompact40InvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 673BE80C-CB41-47A7-B0F3-9872B6DDE5E5.
        /// </summary>
        internal static string SqlCompact40PrivateProvider {
            get {
                return ResourceManager.GetString("SqlCompact40PrivateProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0cfb2eeb-3e0e-4909-99b7-8ae9e1c3e871.
        /// </summary>
        internal static string SqlCompact40Provider {
            get {
                return ResourceManager.GetString("SqlCompact40Provider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Data.SQLite.EF6.
        /// </summary>
        internal static string SQLiteEF6InvariantName {
            get {
                return ResourceManager.GetString("SQLiteEF6InvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Data.SQLite.
        /// </summary>
        internal static string SQLiteInvariantName {
            get {
                return ResourceManager.GetString("SQLiteInvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0ebaab6e-ca80-4b4a-8ddf-cbe6bf058c70.
        /// </summary>
        internal static string SQLiteProvider {
            get {
                return ResourceManager.GetString("SQLiteProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 91510608-8809-4020-8897-fba057e22d54.
        /// </summary>
        internal static string SqlServerDotNetProvider {
            get {
                return ResourceManager.GetString("SqlServerDotNetProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integer data from 0 to 255. 
        ///Storage size is 1 byte..
        /// </summary>
        internal static string tinyint {
            get {
                return ResourceManager.GetString("tinyint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQLite/SQL Server Compact Toolbox.
        /// </summary>
        internal static string ToolWindowTitle {
            get {
                return ResourceManager.GetString("ToolWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A globally unique identifier (GUID).
        ///Storage size is 16 bytes..
        /// </summary>
        internal static string uniqueidentifier {
            get {
                return ResourceManager.GetString("uniqueidentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable-length binary data with a maximum length of 8000 bytes. Default length = 1. 
        ///Storage size varies. It is the length of the value in bytes..
        /// </summary>
        internal static string varbinary {
            get {
                return ResourceManager.GetString("varbinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!-- XSL Template for converting the XML documentation to plain text with WikiPlex markup --&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;&gt;
        ///    &lt;xsl:output method=&quot;text&quot; indent=&quot;no&quot; encoding=&quot;utf-8&quot; /&gt;
        ///
        ///    &lt;xsl:template match=&quot;/&quot;&gt;
        ///        &lt;xsl:value-of select=&quot;concat(&apos;! &apos;, /database/@name, &apos; Database Schema&amp;#13;&amp;#10;&amp;#13;&amp;#10;&apos;)&quot; /&gt;
        ///        &lt;!-- Proces [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WikiPlex {
            get {
                return ResourceManager.GetString("WikiPlex", resourceCulture);
            }
        }
    }
}
