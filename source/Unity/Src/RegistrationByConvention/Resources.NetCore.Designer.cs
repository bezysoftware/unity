﻿
// This output was generated based on a format similar to the one used by resx resource generation.
namespace Microsoft.Practices.Unity
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like or ResGen Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.Security.SecuritySafeCriticalAttribute()]
    internal class Resources
    {

        private static global::Windows.ApplicationModel.Resources.ResourceLoader resourceMan;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Using resx generated code as template")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::Windows.ApplicationModel.Resources.ResourceLoader ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::Windows.ApplicationModel.Resources.ResourceLoader temp = new global::Windows.ApplicationModel.Resources.ResourceLoader("Microsoft.Practices.Unity.RegistrationByConvention/Resources");
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
		
		/// <summary>
		/// An attempt to override an existing mapping was detected for type {1} wit...
		/// </summary>
        internal static string DuplicateTypeMappingException
        {
            get
            {
                return ResourceManager.GetString("DuplicateTypeMappingException");
            }
        }
	
		/// <summary>
		/// The set of assemblies contains a null element.
		/// </summary>
        internal static string ExceptionNullAssembly
        {
            get
            {
                return ResourceManager.GetString("ExceptionNullAssembly");
            }
        }
	}
}

