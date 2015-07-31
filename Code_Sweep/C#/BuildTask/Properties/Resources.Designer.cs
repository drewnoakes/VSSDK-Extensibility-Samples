﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20911.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.VisualStudio.CodeSweep.BuildTask.Properties {
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Microsoft.Samples.VisualStudio.CodeSweep.BuildTask.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column field could not be parsed as an integer..
        /// </summary>
        internal static string BadColumnField {
            get {
                return ResourceManager.GetString("BadColumnField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CodeSweep task scans over text files in project and finds sensitive terms as specified in chosen term tables..
        /// </summary>
        internal static string CodeSweepTaskEntry {
            get {
                return ResourceManager.GetString("CodeSweepTaskEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column index must be &gt;= 0 and &lt; lineText.Length..
        /// </summary>
        internal static string ColumnOutOfRange {
            get {
                return ResourceManager.GetString("ColumnOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file field cannot be an empty string..
        /// </summary>
        internal static string EmptyFileField {
            get {
                return ResourceManager.GetString("EmptyFileField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument cannot be an empty string..
        /// </summary>
        internal static string EmptyString {
            get {
                return ResourceManager.GetString("EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: could not open CodeSweep term table specified: {0}.
        /// </summary>
        internal static string FileNotScannedError {
            get {
                return ResourceManager.GetString("FileNotScannedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}({1},{2}): {3} (Priority {4}, {5}): {6}.
        /// </summary>
        internal static string HitFormat {
            get {
                return ResourceManager.GetString("HitFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}({1},{2}): {3} (Priority {4}, {5}): {6} (Replacement: {7}).
        /// </summary>
        internal static string HitFormatWithReplacement {
            get {
                return ResourceManager.GetString("HitFormatWithReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid serialization string passed to IgnoreInstance constructor..
        /// </summary>
        internal static string InvalidSerializationStringForIgnoreInstance {
            get {
                return ResourceManager.GetString("InvalidSerializationStringForIgnoreInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load term table {0}.
        /// </summary>
        internal static string TermTableLoadFailed {
            get {
                return ResourceManager.GetString("TermTableLoadFailed", resourceCulture);
            }
        }
    }
}